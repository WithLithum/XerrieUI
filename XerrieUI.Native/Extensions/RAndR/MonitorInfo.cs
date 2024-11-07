// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.InteropServices;

namespace XerrieUI.Native.Extensions.RAndR;

[StructLayout(LayoutKind.Sequential)]
public struct MonitorInfo
{
    public uint Atom;
    public byte Primary;
    public byte Automatic;
    public ushort OutputCount;
    public short X;
    public short Y;
    public ushort Width;
    public ushort Height;
    public uint WidthInMillimeters;
    public uint HeightInMillimeters;
}