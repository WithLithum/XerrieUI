// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: LGPL-3.0-or-later

using System.Drawing;
using XerrieUI.Core.Drawing;
using XerrieUI.Drawing;
using XerrieUI.Drawing.Patterns;

namespace XerrieUI.Core.Forms.Controls;

public delegate void MouseButtonEventHandler(object sender, MouseButtonEventArgs e);

public abstract class AbstractControl : IRenderable
{
    private Point _location;
    private Size _size;
    
    #region Events

    public event EventHandler? Moved;
    public event EventHandler? Resized;
    public event MouseButtonEventHandler? MouseDown;
    public event MouseButtonEventHandler? MouseUp;
    public event MouseButtonEventHandler? MouseWheel;
    
    #endregion

    public Rectangle Bounds => new(Location, Size);

    public virtual Color BackgroundColor { get; set; } = Color.White;
    public virtual Color ForegroundColor { get; set; } = Color.Black;
    
    public bool Updated { get; protected set; }
    
    public IRenderable? Parent { get; protected internal set; }

    public Point Location
    {
        get => _location;
        set => ApplyControlLocation(value);
    }

    public Size Size
    {
        get => _size;
        set => ApplyControlSize(value);
    }
    
    public virtual void Render(IRenderer renderer)
    { 
        var graphics = renderer.Graphics;
        using var color = new SolidPattern(BackgroundColor);
        
        graphics.FillRectangle(color, new RectangleF(PointF.Empty, Size));
        graphics.DrawRectangle(new Pen(color, 3), new RectangleF(PointF.Empty, Size));

        Updated = true;
    }

    public virtual void Refresh(bool doNotPropagate)
    {
        Updated = false;
        Parent?.Refresh(true);
    }

    public virtual void RefreshArea(Rectangle rectangle)
    {
        if (rectangle.IntersectsWith(Bounds))
        {
            Refresh(true);
        }
    }

    /// <summary>
    /// Updates the value of the <see cref="Location"/> property, and triggers the
    /// <see cref="Moved"/> event.
    /// </summary>
    /// <param name="moveTo">The location value to set to.</param>
    protected virtual void UpdateLocation(Point moveTo)
    {
        _location = moveTo;
        Moved?.Invoke(this, EventArgs.Empty);
    }

    /// <summary>
    /// Updates the value of the <see cref="Size"/> property, and triggers the
    /// <see cref="Resized"/> event.
    /// </summary>
    /// <param name="size"></param>
    protected virtual void UpdateSize(Size size)
    {
        _size = size;
        Resized?.Invoke(this, EventArgs.Empty);
    }

    /// <summary>
    /// When overriden, causes the "effective" size (to the OS) to be updated.
    /// </summary>
    /// <param name="size">The size to apply.</param>
    protected virtual void ApplyControlSize(Size size)
    {
        _size = size;
        Resized?.Invoke(this, EventArgs.Empty);
    }

    /// <summary>
    /// When overriden, causes the "effective" location (to the OS) to be updated.
    /// </summary>
    /// <param name="location">The location to apply.</param>
    protected virtual void ApplyControlLocation(Point location)
    {
        _location = location;
        Moved?.Invoke(this, EventArgs.Empty);
        Refresh(true);
    }

    protected internal virtual void OnMouseUp(Point location, MouseButton button)
    {
        MouseUp?.Invoke(this, new MouseButtonEventArgs(location, button));
    }
    
    protected internal virtual void OnMouseDown(Point location, MouseButton button)
    {
        MouseDown?.Invoke(this, new MouseButtonEventArgs(location, button));
    }

    protected internal virtual void OnMouseWheel(Point location, MouseButton button)
    {
        MouseWheel?.Invoke(this, new MouseButtonEventArgs(location, button));
    }
}
