// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using XerrieUI.Drawing.Interop;

namespace XerrieUI.Drawing.Patterns;

public abstract class CairoPattern : IDisposable
{
    private bool _disposed;
    
    protected CairoPattern(IntPtr handle)
    {
        Handle = handle;
    }
    
    protected internal IntPtr Handle { get; }
    public void EnsureNotDisposed()
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
    }
    
    private void ReleaseUnmanagedResources()
    {
        LibCairo.cairo_pattern_destroy(Handle);
        _disposed = true;
    }

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }

    ~CairoPattern()
    {
        ReleaseUnmanagedResources();
    }
}