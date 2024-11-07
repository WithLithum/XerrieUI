// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.InteropServices;
using XerrieUI.Native.Extensions.RAndR;

namespace XerrieUI.Native.Interop;

internal static partial class LibXcbRandR
{
    private const string LibName = "libxcb-randr.so.0";

    [StructLayout(LayoutKind.Sequential)]
    internal struct XRandRCookie
    {
        public uint Sequence;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct XRandRGetScreenResourcesReply
    {
        public byte ResponseType;
        public byte Pad0;
        public ushort Sequence;
        public uint Length;
        public uint Timestamp;
        public uint ConfigTimestamp;
        public ushort NumCrtcs;
        public ushort NumOutputs;
        public ushort NumModes;
        public ushort NamesLen;
        public fixed byte Pad1[8];
    }

    [LibraryImport(LibName)]
    internal static partial XRandRCookie xcb_randr_get_screen_resources(IntPtr connection, uint window);

    [LibraryImport(LibName)]
    [return: MustFree]
    internal static unsafe partial XRandRGetScreenResourcesReply* xcb_randr_get_screen_resources_reply(
        IntPtr connection,
        XRandRCookie cookie,
        xcb_generic_error_t** e);

    [LibraryImport(LibName)]
    internal static unsafe partial int
        xcb_randr_get_screen_resources_modes_length(XRandRGetScreenResourcesReply* reply);

    [LibraryImport(LibName)]
    internal static unsafe partial ScreenModeInfo* xcb_randr_get_screen_resources_modes(
        XRandRGetScreenResourcesReply* reply);

    [LibraryImport(LibName)]
    internal static unsafe partial uint* xcb_randr_get_screen_resources_crtcs(XRandRGetScreenResourcesReply* reply);

    [LibraryImport(LibName)]
    internal static unsafe partial int
        xcb_randr_get_screen_resources_crtcs_length(XRandRGetScreenResourcesReply* reply);

    #region GetMonitors

    [StructLayout(LayoutKind.Sequential)]
    internal struct XRandRGetMonitorsCookie
    {
        public uint Sequence;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct XRandRGetMonitorsReply
    {
        public byte ResponseType;
        public byte Pad0;
        public ushort Sequence;
        public uint Length;
        public uint Timestamp;
        public uint MonitorsCount;
        public uint OutputsCount;
        public fixed byte Pad1[12];
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct XRandRMonitorInfoIterator
    {
        public MonitorInfo* Data;
        public int Remaining;
        public int Index;
    }

    [LibraryImport(LibName)]
    internal static partial XRandRGetMonitorsCookie xcb_randr_get_monitors(IntPtr connection,
        uint window,
        byte getActive);

    [LibraryImport(LibName)]
    [return: MustFree]
    internal static unsafe partial XRandRGetMonitorsReply* xcb_randr_get_monitors_reply_t(IntPtr connection,
        XRandRGetMonitorsCookie cookie,
        xcb_generic_error_t** e);

    [LibraryImport(LibName)]
    internal static unsafe partial int xcb_randr_get_monitors_monitors_length(XRandRGetMonitorsReply* reply);

    [LibraryImport(LibName)]
    internal static unsafe partial XRandRMonitorInfoIterator xcb_randr_get_monitors_monitors_iterator(
        XRandRGetMonitorsReply* reply);

    [LibraryImport(LibName)]
    internal static partial void xcb_randr_monitor_info_next(ref XRandRMonitorInfoIterator iterator);

    #endregion

    #region GetCtrcInfo

    [StructLayout(LayoutKind.Sequential)]
    internal struct XcbGetCrtcInfoReply
    {
        public byte response_type;
        public byte status;
        public ushort sequence;
        public uint length;
        public uint timestamp;
        public short x;
        public short y;
        public ushort width;
        public ushort height;
        public uint mode;
        public ushort rotation;
        public ushort rotations;
        public ushort num_outputs;
        public ushort num_possible_outputs;
    }

    [LibraryImport(LibName)]
    internal static unsafe partial XRandRCookie xcb_randr_get_crtc_info(IntPtr connection,
        uint crtc,
        uint timestamp);

    [LibraryImport(LibName)]
    internal static unsafe partial XcbGetCrtcInfoReply* xcb_randr_get_crtc_info_reply(IntPtr connection,
        XRandRCookie cookie,
        xcb_generic_error_t** error);

    #endregion
}