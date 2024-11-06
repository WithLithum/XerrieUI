// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;
using XerrieUI.Drawing.Interop;
using XerrieUI.Native;
using XerrieUI.Native.Windowing;

namespace XerrieUI.Drawing;

public class XcbCairoSurface : CairoSurface
{
    private readonly uint _drawable;
    private readonly XcbConnection _connection;
    
    private XcbCairoSurface(IntPtr handle, uint drawable, XcbConnection connection) : base(handle)
    {
        _drawable = drawable;
        _connection = connection;
    }
    
    public void SetSize(Size size)
    {
        LibCairo.cairo_xcb_surface_set_size(Handle,
            size.Width,
            size.Height);
    }
    
    public static unsafe XcbCairoSurface Create(XcbConnection connection, 
        XcbWindowHandle handle,
        Size size)
    {
        var screen = connection.GetScreen(connection.DefaultScreen);

        var visualType = connection.GetVisualType(connection.DefaultScreen,
            screen->root_visual);

        Console.WriteLine("{0}/{1}", size.Width, size.Height);
        
        return new XcbCairoSurface(LibCairo.cairo_xcb_surface_create(connection.Handle,
            handle.Handle,
            visualType,
            size.Width - 10,
            size.Height - 10),
            handle.Handle,
            connection);
    }

    public override void Flush()
    {
        base.Flush();
        Xcb.xcb_flush(_connection.Handle);
    }
}