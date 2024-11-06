// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.InteropServices;
using XerrieUI.Native.Exceptions;
using XerrieUI.Native.Windowing;

namespace XerrieUI.Native.Interop;

public static partial class XCoreInvoke
{
    [LibraryImport("libxcb.so.1", StringMarshalling = StringMarshalling.Utf8)]
    internal static partial xcb_intern_atom_cookie_t xcb_intern_atom(IntPtr c,
        byte onlyIfExists,
        ushort nameLen,
        string name);

    [LibraryImport("libxcb.so.1", StringMarshalling = StringMarshalling.Utf8)]
    internal static unsafe partial IntPtr xcb_connect(string? display,
        int* screenNum);
    
    /// <summary>
    /// Retrieves the identifier (<see cref="uint"/>) for the atom with the specified
    /// name. Atoms are used in protocols like EWMH, for example to store window titles
    /// (<c>_NET_WM_NAME</c> atom) as property of a window.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <param name="onlyIfExists">Return a valid atom id only if the atom already exists.</param>
    /// <param name="name">The name.</param>
    /// <returns>If <paramref name="onlyIfExists"/> is set to <see langword="true"/> and the specified atom doesn't exist, <c>0</c>; otherwise, the atom value.</returns>
    /// <exception cref="X11Exception">Atom request have failed.</exception>
    [Obsolete("Use XcbConnection.Intern.GetAtom instead.")]
    public static unsafe uint GetInternAtom(IntPtr connection, bool onlyIfExists, string name)
    {
        var cookie = xcb_intern_atom(connection,
            (byte)(onlyIfExists ? 1 : 0),
            (ushort)name.Length,
            name);

        xcb_generic_error_t error = default;
        var errorPtr = &error;
        var ptrToErrorPtr = &errorPtr;
        
        var reply = Xcb.xcb_intern_atom_reply(connection,
            cookie,
            ptrToErrorPtr);
        if (reply == null)
        {
            throw X11Exception.CreateFromError(error);
        }
        
        var result = reply->atom;
        Marshal.FreeHGlobal((IntPtr)reply);
        return result;
    }
}