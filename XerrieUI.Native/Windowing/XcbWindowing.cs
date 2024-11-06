// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.InteropServices;

namespace XerrieUI.Native.Windowing;

public class XcbWindowing
{
    private readonly XcbConnection _connection;

    internal XcbWindowing(XcbConnection connection)
    {
        _connection = connection;
    }

    public unsafe void ChangeProperty(XcbWindowHandle window,
        uint propertyAtom,
        string value,
        WindowPropertySetMode mode = WindowPropertySetMode.Replace)
    {
        var data = Marshal.StringToHGlobalAnsi(value);

        var request = Xcb.xcb_change_property_checked(_connection.Handle,
            (byte)mode,
            window.Handle,
            propertyAtom,
            (uint)PrimitiveAtoms.String,
            8,
            (uint)value.Length,
            (void*)data);
        
        _connection.RequestCheck(request);
        
        Marshal.FreeHGlobal(data);
    }
    
    public unsafe void Configure(XcbWindowHandle window, ConfigureWindowValueMask valueMask, uint[] values)
    {
        fixed (uint* valuePtr = values)
        {
            var request = Xcb.xcb_configure_window_checked(_connection.Handle,
                window.Handle,
                (ushort)valueMask,
                valuePtr);
            _connection.RequestCheck(request);
        }
    }
    
    public unsafe XcbWindowHandle Create(byte depth, 
        XcbWindowHandle parent, 
        short x, 
        short y, 
        ushort width, 
        ushort height,
        ushort borderWidth,
        WindowClass windowClass,
        uint visual,
        CreateWindowValueMask valueMask,
        uint[] values)
    {
        var id = _connection.GenerateId();

        fixed (uint* dataP = values)
        {
            var request = Xcb.xcb_create_window_checked(_connection.Handle,
                depth,
                id,
                parent.Handle,
                x,
                y,
                width,
                height,
                borderWidth,
                (ushort)windowClass,
                visual,
                (uint)valueMask,
                dataP);
            _connection.RequestCheck(request);
        }

        return new XcbWindowHandle
        {
            Handle = id
        };
    }
    
    public void Destroy(XcbWindowHandle handle)
    {
        var request = Xcb.xcb_destroy_window_checked(_connection.Handle, handle.Handle);
        _connection.RequestCheck(request);
    }

    public void Map(XcbWindowHandle handle)
    {
        _connection.RequestCheck(Xcb.xcb_map_window_checked(_connection.Handle, handle.Handle));
    }
    
    public void Unmap(XcbWindowHandle handle)
    {
        _connection.RequestCheck(Xcb.xcb_unmap_window_checked(_connection.Handle, handle.Handle));
    }
}