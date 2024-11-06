// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using XerrieUI.Native.Windowing;

namespace XerrieUI.Native.Extensions;

public sealed class XcbInterClient
{
    private const string WmProtocols = "WM_PROTOCOLS";
    
    private readonly XcbConnection _connection;

    internal XcbInterClient(XcbConnection connection)
    {
        _connection = connection;
    }

    public void SetWindowMessageClass(XcbWindowHandle handle, string className)
    {
        var request = InterClientNative.xcb_icccm_set_wm_class_checked(_connection.Handle,
            handle.Handle,
            (uint)className.Length,
            className);
        
        _connection.RequestCheck(request);
    }

    public unsafe void SetWindowMessageProtocols(XcbWindowHandle handle, uint[] protocols)
    {
        var wmProtocolsAtom = _connection.Intern.GetAtom(WmProtocols);
        if (wmProtocolsAtom == 0)
        {
            throw new NotSupportedException("Window message protocols are not supported.");
        }
        
        fixed (uint* protocolP = protocols)
        {
            var request = InterClientNative.xcb_icccm_set_wm_protocols_checked(_connection.Handle,
                handle.Handle,
                wmProtocolsAtom,
                (uint)protocols.Length,
                protocolP);
            _connection.RequestCheck(request);
        }
    }
}