// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using XerrieUI.Drawing.Interop;

namespace XerrieUI.Drawing;

public abstract class CairoFont : IDisposable
{
    protected CairoFont(IntPtr handle)
    {
        Handle = handle;
    }
    
    protected internal IntPtr Handle { get; }

    private void ReleaseUnmanagedResources()
    {
        LibCairo.cairo_font_face_destroy(Handle);
    }

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }

    ~CairoFont()
    {
        ReleaseUnmanagedResources();
    }
}