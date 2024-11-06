// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.InteropServices;
using XerrieUI.Native.Exceptions;

namespace XerrieUI.Native.Interop;

public sealed class XcbIntern
{
    private readonly XcbConnection _connection;
    private readonly Dictionary<string, uint> _atomCache = [];
    
    internal XcbIntern(XcbConnection connection)
    {
        _connection = connection;
    }
    
    public uint GetAtom(string atomName, bool onlyIfExists = true)
    {
        if (_atomCache.TryGetValue(atomName, out var atom))
        {
            return atom;
        }
        
        var atomValue = GetAtomInternal(atomName, onlyIfExists);
        _atomCache[atomName] = atomValue;
        return atomValue;
    }
    
    private unsafe uint GetAtomInternal(string atomName, bool onlyIfExists = true)
    {
        var cookie = XCoreInvoke.xcb_intern_atom(_connection.Handle,
            (byte)(onlyIfExists ? 1 : 0),
            (ushort)atomName.Length,
            atomName);

        xcb_generic_error_t error = default;
        var errorPtr = &error;
        var ptrToErrorPtr = &errorPtr;
        
        var reply = Xcb.xcb_intern_atom_reply(_connection.Handle,
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