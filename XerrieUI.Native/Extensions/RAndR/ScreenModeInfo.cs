// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.InteropServices;

namespace XerrieUI.Native.Extensions.RAndR;

[StructLayout(LayoutKind.Sequential)]
public struct ScreenModeInfo
{
    public uint Id;
    public ushort Width;
    public ushort Height;
    public uint DotClock;
    public ushort HSyncStart;
    public ushort HSyncEnd;
    public ushort HTotal;
    public ushort HSkew;
    public ushort VsyncStart;
    public ushort VsyncEnd;
    public ushort VTotal;
    public ushort NameLen;
    public uint ModeFlags;
}