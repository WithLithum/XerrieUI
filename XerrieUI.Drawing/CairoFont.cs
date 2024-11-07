// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using XerrieUI.Drawing.Interop;

namespace XerrieUI.Drawing;

public abstract class CairoFont : IDisposable
{
    private bool _disposed;
    
    protected virtual void Dispose(bool disposing)
    {
        ReleaseUnmanagedResources();
        if (disposing)
        {
            // The base class doesn't have managed resources to release.
            // However, the subclasses may have.
        }
    }

    protected CairoFont(IntPtr handle)
    {
        Handle = handle;
    }
    
    protected internal IntPtr Handle { get; }

    protected internal void EnsureNotDisposed()
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
    }

    private void ReleaseUnmanagedResources()
    {
        LibCairo.cairo_font_face_destroy(Handle);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);

        _disposed = true;
    }

    ~CairoFont()
    {
        Dispose(false);
    }
}