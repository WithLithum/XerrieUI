// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using XerrieUI.Native.Exceptions;
using XerrieUI.Native.Extensions;
using XerrieUI.Native.Interop;
using XerrieUI.Native.Windowing;

namespace XerrieUI.Native;

public sealed class XcbConnection : IDisposable
{
    private unsafe XcbConnection(IntPtr handle, int defaultScreen)
    {
        Handle = handle;

        InterClient = new XcbInterClient(this);
        Intern = new XcbIntern(this);
        Setup = new XcbSetup(Xcb.xcb_get_setup(handle));
        Windows = new XcbWindowing(this);

        DefaultScreen = defaultScreen;
    }
    
    public IntPtr Handle { get; }
    
    public int DefaultScreen { get; }
    
    public XcbInterClient InterClient { get; }
    
    public XcbIntern Intern { get; }
    
    public XcbSetup Setup { get; }
    
    public XcbWindowing Windows { get; }
    
    public uint GenerateId()
    {
        return Xcb.xcb_generate_id(Handle);
    }

    public UnGrabToken Grab()
    {
        Xcb.xcb_grab_server(Handle);
        return new UnGrabToken(this);
    }

    public unsafe xcb_screen_t* GetScreen(int screen)
    {
        var result = XUtilInterop.xcb_aux_get_screen(Handle, screen);
        Console.WriteLine("{1} -> {0}", (IntPtr)result, screen);
        return result;
    }
    
    public unsafe xcb_visualtype_t* GetVisualType(int screen, uint id)
    {
        return XUtilInterop.xcb_aux_get_visualtype(Handle, screen, id);
    }
    
    public void RequestCheck(xcb_void_cookie_t cookie)
    {
        X11Exception.RequestCheck(Handle, cookie);
    }

    public static unsafe XcbConnection Connect(string? display)
    {
        var outScreen = 0;
        
        var handle = XCoreInvoke.xcb_connect(display, &outScreen);
        var result = new XcbConnection(handle, outScreen);
        result.CheckForErrors();
        
        return result;
    }

    private void CheckForErrors()
    {
        var error = Xcb.xcb_connection_has_error(Handle);
        if (error == 0)
        {
            return;
        }
        
        Dispose();
        throw error switch
        {
            NativeConstants.XCB_CONN_ERROR => new IOException("Failed to establish connection to the X server."),
            NativeConstants.XCB_CONN_CLOSED_REQ_LEN_EXCEED => new X11Exception(
                "Request length exceeded the limit set by X server.", NativeConstants.XCB_CONN_CLOSED_REQ_LEN_EXCEED),
            NativeConstants.XCB_CONN_CLOSED_PARSE_ERR =>
                // ReSharper disable once NotResolvedInText
                new ArgumentException("Invalid display string.", "display"),
            NativeConstants.XCB_CONN_CLOSED_EXT_NOTSUPPORTED => new X11Exception(
                "An extension was not supported by the X server.", NativeConstants.XCB_CONN_CLOSED_EXT_NOTSUPPORTED),
            NativeConstants.XCB_CONN_CLOSED_INVALID_SCREEN =>
                // ReSharper disable once NotResolvedInText
                new ArgumentException("The specified screen does not exist on X server.", "screen"),
            NativeConstants.XCB_CONN_CLOSED_MEM_INSUFFICIENT => new OutOfMemoryException(
                "Cannot allocate memory for creating a connection to the X server."),
            _ => new X11Exception("Unknown error when establishing connection", (byte)error)
        };
    }
    
    private void ReleaseUnmanagedResources()
    {
        Xcb.xcb_disconnect(Handle);
    }

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }

    ~XcbConnection()
    {
        ReleaseUnmanagedResources();
    }
}   