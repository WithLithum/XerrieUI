// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.InteropServices;

namespace XerrieUI.Drawing.Fonts;

[StructLayout(LayoutKind.Sequential)]
public struct TextExtents
{
    public double XBearing;
    public double YBearing;
    public double Width;
    public double Height;
    public double XAdvance;
    public double YAdvance;
}