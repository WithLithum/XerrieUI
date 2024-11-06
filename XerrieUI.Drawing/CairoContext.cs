// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;
using XerrieUI.Drawing.Exceptions;
using XerrieUI.Drawing.Interop;
using XerrieUI.Drawing.Patterns;

namespace XerrieUI.Drawing;

public class CairoContext : IDisposable, IEquatable<CairoContext>
{
    private readonly IntPtr _handle;
    private readonly CairoSurface? _target;
    
    public CairoContext(CairoSurface target)
    {
        _target = target;
        _handle = LibCairo.cairo_create(target.Handle);
    }

    public CairoContext(IntPtr handle)
    {
        _handle = LibCairo.cairo_reference(handle);
    }
    
    #region Utilities

    private void EnsureSuccess()
    {
        var status = LibCairo.cairo_status(_handle);
        if (status != CairoStatus.Success)
        {
            throw new CairoException(status);
        }
    }
    
    #endregion

    #region Grouping

    public void DoGroup(Action action)
    {
        LibCairo.cairo_push_group(_handle);
        action.Invoke();
        LibCairo.cairo_pop_group_to_source(_handle);
    }
    
    #endregion

    public void FillText(CairoPattern pattern, CairoFont font, double size, Point point, string text)
    {
        LibCairo.cairo_set_font_face(_handle, font.Handle);
        
        EnsureSuccess();
        
        LibCairo.cairo_set_font_size(_handle, size);
        
        EnsureSuccess();
        
        LibCairo.cairo_set_source(_handle, pattern.Handle);
        
        LibCairo.cairo_move_to(_handle, point.X, point.Y);
        LibCairo.cairo_show_text(_handle, text);
        
        // TODO extents
        
        LibCairo.cairo_fill(_handle);
        
        EnsureSuccess();
    }
    
    public void FillRectangle(CairoPattern pattern, RectangleF rect)
    {
        LibCairo.cairo_set_source(_handle, pattern.Handle);
        LibCairo.cairo_rectangle(_handle, rect.X, rect.Y, rect.Width, rect.Height);
        LibCairo.cairo_fill(_handle);
        EnsureSuccess();
    }
    
    public void DrawRectangle(Pen pen, RectangleF rect)
    {
        LibCairo.cairo_set_line_width(_handle, pen.Width);
        LibCairo.cairo_set_source(_handle, pen.Pattern.Handle);

        LibCairo.cairo_rectangle(_handle, rect.X, rect.Y, rect.Width, rect.Height);
        LibCairo.cairo_stroke(_handle);
        
        EnsureSuccess();
    }
    
    private void ReleaseUnmanagedResources()
    {
        LibCairo.cairo_destroy(_handle);
    }

    private void Dispose(bool disposing)
    {
        ReleaseUnmanagedResources();
        if (disposing)
        {
            _target?.Dispose();
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    ~CairoContext()
    {
        Dispose(false);
    }
    
    public bool Equals(CairoContext? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return _handle == other._handle;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as CairoContext);
    }

    public override int GetHashCode()
    {
        return _handle.GetHashCode();
    }

    public static bool operator ==(CairoContext? left, CairoContext? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(CairoContext? left, CairoContext? right)
    {
        return !Equals(left, right);
    }

    public void Flush()
    {
        _target?.Flush();
    }
}