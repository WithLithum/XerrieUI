// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using XerrieUI.Drawing.Interop;

namespace XerrieUI.Drawing;

public abstract class CairoSurface : IDisposable
{
    protected CairoSurface(IntPtr handle)
    {
        Handle = handle;
    }
    
    public IntPtr Handle { get; }

    public virtual void Flush()
    {
        LibCairo.cairo_surface_flush(Handle);
    }
    
    public void Dispose()
    {
        LibCairo.cairo_surface_destroy(Handle);
        GC.SuppressFinalize(this);
    }
}