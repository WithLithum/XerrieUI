// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using XerrieUI.Native;
using XerrieUI.Native.Extensions;
using XerrieUI.Native.Interop;
using XerrieUI.Native.Windowing;

namespace XerrieUI.Core.Platform;

internal static class NativeWindows
{
    internal static unsafe XcbWindowHandle CreateNativeWindow(Size size)
    {
        var connection = Application.EnsureConnection();

        var iterator = connection.Setup.GetRootsIterator();
        var screen = iterator.data;
        
        var id = connection.GenerateId();

        const CreateWindowValueMask valueMask = CreateWindowValueMask.EventMask;
        const WindowEventMask eventMask = WindowEventMask.Exposure |
                                          WindowEventMask.ButtonPress |
                                          WindowEventMask.ButtonRelease |
                                          WindowEventMask.PropertyChange |
                                          WindowEventMask.StructureNotify |
                                          WindowEventMask.VisibilityChange;
        
        var handle = connection.Windows.Create(screen->root_depth,
            new XcbWindowHandle(screen->root),
            20,
            200,
            (ushort)size.Width,
            (ushort)size.Height,
            10,
            WindowClass.InputOutput,
            screen->root_visual,
            valueMask,
            [(uint)eventMask]);
        
        ConfigureWindow(connection, handle);
        Xcb.xcb_screen_end(iterator);
        
        return handle;
    }
    
    private static void ConfigureWindow(XcbConnection connection, XcbWindowHandle handle)
    {
        // Set message class name
        var baseName = Path.GetFileName(Environment.ProcessPath) ??
                       Assembly.GetExecutingAssembly().GetName().Name ?? "xerrie-client";
        var className = $"{baseName}\0{Application.ApplicationClass}\0";
        connection.InterClient.SetWindowMessageClass(handle, className);
        
        var deleteWindow = connection.Intern.GetAtom("WM_DELETE_WINDOW");
        
        connection.InterClient.SetWindowMessageProtocols(handle, [deleteWindow]);
    }
}