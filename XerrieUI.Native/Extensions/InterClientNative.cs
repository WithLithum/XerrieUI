// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.InteropServices;

namespace XerrieUI.Native.Extensions;

/// <summary>
/// Provides native interoperability functions for the Inter-Client Communication Conventions
/// implementation of the X C Bindings library. 
/// </summary>
/// <seealso href="https://x.org/releases/X11R7.6/doc/xorg-docs/specs/ICCCM/icccm.html#wm_class_property">Inter-Client Communication Conventions</seealso>
internal static partial class InterClientNative
{
    private const string NativeLibrary = "libxcb-icccm.so.4";
    
    [LibraryImport(NativeLibrary, StringMarshalling = StringMarshalling.Utf8)]
    internal static partial xcb_void_cookie_t xcb_icccm_set_wm_class_checked(IntPtr connection,
        uint window,
        uint classLength,
        string className);

    [LibraryImport(NativeLibrary)]
    internal static unsafe partial xcb_void_cookie_t xcb_icccm_set_wm_protocols_checked(IntPtr connection,
        uint window,
        uint wmProtocols,
        uint listLen,
        uint* list);
}