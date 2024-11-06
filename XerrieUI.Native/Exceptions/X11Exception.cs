// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.InteropServices;

namespace XerrieUI.Native.Exceptions;

/// <summary>
/// Thrown when an X protocol error occurs.
/// </summary>
public class X11Exception : Exception
{
    public X11Exception(string? message, byte errorCode) : base(message)
    {
        ErrorCode = errorCode;
    }
    
    public byte ErrorCode { get; }

    public static unsafe void RequestCheck(IntPtr connection, xcb_void_cookie_t cookie)
    {
        var error = Xcb.xcb_request_check(connection, cookie);
        if (error != null)
        {
            throw CreateFromError(error);
        }
    }

    public static unsafe X11Exception CreateFromError(xcb_generic_error_t error)
    {
        var name = XcbExtras.xcb_event_get_error_label(error.error_code);
        var message = Marshal.PtrToStringAnsi((IntPtr)name);
        return new X11Exception(message, error.error_code);
    }
    
    public static unsafe X11Exception CreateFromError(xcb_generic_error_t* error)
    {
        var name = XcbExtras.xcb_event_get_error_label(error->error_code);
        var message = Marshal.PtrToStringAnsi((IntPtr)name);
        return new X11Exception(message, error->error_code);
    }
}