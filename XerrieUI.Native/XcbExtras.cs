// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
//
// SPDX-License-Identifier: Apache-2.0

#pragma warning disable CA1041
#pragma warning disable SYSLIB1054

using System.Runtime.InteropServices;

namespace XerrieUI.Native
{
    public static unsafe partial class XcbExtras
    {
        [DllImport("libxcb-util.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* xcb_atom_name_by_screen([NativeTypeName("const char *")] sbyte* @base, [NativeTypeName("uint8_t")] byte screen);

        [DllImport("libxcb-util.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* xcb_atom_name_by_resource([NativeTypeName("const char *")] sbyte* @base, [NativeTypeName("uint32_t")] uint resource);

        [DllImport("libxcb-util.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* xcb_atom_name_unique([NativeTypeName("const char *")] sbyte* @base, [NativeTypeName("uint32_t")] uint id);

        [DllImport("libxcb-util.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* xcb_event_get_label([NativeTypeName("uint8_t")] byte type);

        [DllImport("libxcb-util.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* xcb_event_get_error_label([NativeTypeName("uint8_t")] byte type);

        [DllImport("libxcb-util.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* xcb_event_get_request_label([NativeTypeName("uint8_t")] byte type);
    }
}
