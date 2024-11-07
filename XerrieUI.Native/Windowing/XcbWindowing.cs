// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.InteropServices;
using XerrieUI.Native.Exceptions;

namespace XerrieUI.Native.Windowing;

public class XcbWindowing
{
    private readonly XcbConnection _connection;

    internal XcbWindowing(XcbConnection connection)
    {
        _connection = connection;
    }

    public unsafe XcbWindowAttributes GetAttributes(XcbWindowHandle window)
    {
        var cookie = Xcb.xcb_get_window_attributes(_connection.Handle, window.Handle);
        
        xcb_generic_error_t error;
        var errorPtr = &error;

        var reply = Xcb.xcb_get_window_attributes_reply(_connection.Handle,
            cookie, &errorPtr);
        if (error.error_code != 0 || reply == null)
        {
            throw X11Exception.CreateFromError(error);
        }

        var result = new XcbWindowAttributes(reply);
        Marshal.FreeHGlobal((IntPtr)reply);
        return result;
    }

    public unsafe XcbWindowHandle GetSelectionOwner(uint atom)
    {
        var request = Xcb.xcb_get_selection_owner(_connection.Handle,
            atom);

        xcb_generic_error_t error;
        var errorPtr = &error;
        var reply = Xcb.xcb_get_selection_owner_reply(_connection.Handle,
            request,
            &errorPtr);

        if (error.error_code != 0 || reply == null)
        {
            if (error.error_code == (byte)XcbErrors.Atom)
            {
                throw new ArgumentException("The specified atom does not exist.", nameof(atom));
            }
            
            throw X11Exception.CreateFromError(error);
        }

        var result = new XcbWindowHandle(reply->owner);
        Marshal.FreeHGlobal((IntPtr)reply);
        return result;
    }
    
    public unsafe byte[] GetCustomProperty(XcbWindowHandle window,
        uint typeAtom,
        uint propertyAtom,
        out uint realType,
        int format = -1)
    {
        var request = Xcb.xcb_get_property(_connection.Handle,
            0,
            window.Handle,
            propertyAtom,
            (uint)PrimitiveAtoms.String,
            0,
            uint.MaxValue);

        xcb_generic_error_t error;
        var errorPtr = &error;
        
        var reply = Xcb.xcb_get_property_reply(_connection.Handle,
            request,
            &errorPtr);

        if (error.error_code != 0)
        {
            throw X11Exception.CreateFromError(error);
        }
        
        if (reply == null)
        {
            realType = 0;
            return [];
        }
        
        realType = reply->type;

        // Verify format if needed.
        if (format > 0 && reply->format != format)
        {
            throw new InvalidOperationException($"Caller requires format '{format}' but query returned format '{reply->format}'");
        }

        var length = Xcb.xcb_get_property_value_length(reply);
        var valuePtr = Xcb.xcb_get_property_value(reply);

        var result = new byte[length];
        
        // Copy data from the property_value to our array.
        fixed (byte* pResult = result)
        {
            var arrayPtr = (byte*)valuePtr;
            for (var i = 0; i < length; i++)
            {
                pResult[i] = arrayPtr[i];
            }   
        }
        
        // Free the reply data.
        Marshal.FreeHGlobal((IntPtr)reply);
        return result;
    }
    
    public unsafe string GetStringProperty(XcbWindowHandle window,
        uint propertyAtom)
    {
        var request = Xcb.xcb_get_property(_connection.Handle,
            0,
            window.Handle,
            propertyAtom,
            (uint)PrimitiveAtoms.String,
            0,
            uint.MaxValue);

        xcb_generic_error_t error;
        var errorPtr = &error;
        
        var reply = Xcb.xcb_get_property_reply(_connection.Handle,
            request,
            &errorPtr);

        if (error.error_code != 0)
        {
            throw X11Exception.CreateFromError(error);
        }
        
        if (reply == null)
        {
            return "<null>";
        }

        var length = Xcb.xcb_get_property_value_length(reply);
        var valuePtr = Xcb.xcb_get_property_value(reply);
        
        var result = Marshal.PtrToStringUTF8((IntPtr)valuePtr, length);
        Marshal.FreeHGlobal((IntPtr)reply);
        return result;
    }

    public unsafe void ChangeAttribute(XcbWindowHandle window,
        WindowAttributeMask attributes,
        params uint[] values)
    {
        fixed (uint* valuesPtr = values)
        {
            _connection.RequestCheck(Xcb.xcb_change_window_attributes(_connection.Handle, 
                window.Handle, 
                (uint)attributes, 
                valuesPtr));   
        }
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
        WindowAttributeMask attributeMask,
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
                (uint)attributeMask,
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