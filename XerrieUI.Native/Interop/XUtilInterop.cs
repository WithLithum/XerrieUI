// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.InteropServices;

namespace XerrieUI.Native.Interop;

internal static partial class XUtilInterop
{
    private const string LibName = "libxcb-util.so.1";

    [LibraryImport(LibName)]
    internal static unsafe partial xcb_visualtype_t* xcb_aux_get_visualtype(IntPtr connection,
        int screen,
        uint visualId);

    [LibraryImport(LibName)]
    internal static unsafe partial xcb_screen_t* xcb_aux_get_screen(IntPtr connection,
        int screen);
}