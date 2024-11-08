// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.InteropServices;
using XerrieUI.Native;

namespace XerrieUI.Core.Platform.Events;

internal static class EventLoop
{
    private const string DeleteWindow = "WM_DELETE_WINDOW";
    
    internal static unsafe void Pass(XcbConnection connection)
    {
        var e = Xcb.xcb_poll_for_event(connection.Handle);
        if (e == null)
        {
            return;
        }
                
        var id = (XEventType)NativeConstants.XCB_EVENT_RESPONSE_TYPE(e);
                
        switch (id)
        {
            case XEventType.ConfigureNotify:
                Application.WindowManager.OnConfigureNotify((xcb_configure_notify_event_t*)e);
                break;
            case XEventType.Expose:
                Application.WindowManager.OnExpose((xcb_expose_event_t*)e);
                break;
            case XEventType.MapNotify:
                var mapEvent = (xcb_map_notify_event_t*)e;
                Application.WindowManager.OnShown(mapEvent->window);
                break;
            case XEventType.DestroyNotify:
                break;
            case XEventType.UnmapNotify:
                var unmapEvent = (xcb_unmap_notify_event_t*)e;
                Application.WindowManager.OnHidden(unmapEvent->window);
                break;
            case XEventType.ClientMessage:
                HandleClientMessage(connection, e);
                break;
            case XEventType.PropertyNotify:
                var propArgs = (xcb_property_notify_event_t*)e;
                ProcessPropertyNotify(propArgs);
                break;
            case XEventType.ButtonPress:
                var btnPressArgs = (xcb_button_press_event_t*)e;
                ProcessButtonPress(btnPressArgs, true);
                break;
            case XEventType.ButtonRelease:
                var btnReleaseArgs = (xcb_button_press_event_t*)e;
                ProcessButtonPress(btnReleaseArgs, false);
                break;
        }
        
        Marshal.FreeHGlobal((IntPtr)e);
    }

    private static unsafe void ProcessButtonPress(xcb_button_press_event_t* btnPressArgs,
        bool isPressOrRelease)
    {
        var window = btnPressArgs->@event;
        if (window == 0)
        {
            return;
        }

        Application.WindowManager.OnButtonPress(window, 
            (MouseButton)btnPressArgs->detail, 
            btnPressArgs->event_x,
            btnPressArgs->event_y,
            isPressOrRelease);
    }

    private static unsafe void ProcessPropertyNotify(xcb_property_notify_event_t* propArgs)
    {
        var atom = propArgs->atom;
        var window = propArgs->window;

        Application.WindowManager.OnPropertyChange(window, atom);
    }

    private static unsafe void HandleClientMessage(XcbConnection connection, xcb_generic_event_t* e)
    {
        var message = (xcb_client_message_event_t*)e;

        // If no data, not our client message.
        if (message->data.data32 == null) return;
        
        var data32 = message->data.data32[0];
        if (data32 == connection.Intern.GetAtom(DeleteWindow))
        {
            HandleDestroyWindow(message->window);
        }
    }

    private static void HandleDestroyWindow(uint windowId)
    {
        Application.WindowManager.OnDeleteWindow(windowId);
    }
}