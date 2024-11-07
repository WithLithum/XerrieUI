// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

namespace XerrieUI.Native;

public sealed class UnGrabToken : IDisposable
{
    private readonly XcbConnection _connection;
    private bool _disposed;

    internal UnGrabToken(XcbConnection connection)
    {
        _connection = connection;
    }

    private void ReleaseUnmanagedResources()
    {
        Xcb.xcb_ungrab_server(_connection.Handle);
        _disposed = true;
    }

    public void Dispose()
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }

    ~UnGrabToken()
    {
        ReleaseUnmanagedResources();
    }
}