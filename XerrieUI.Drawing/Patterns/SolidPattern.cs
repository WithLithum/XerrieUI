// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;
using XerrieUI.Drawing.Interop;

namespace XerrieUI.Drawing.Patterns;

public sealed class SolidPattern : CairoPattern
{
    public SolidPattern(Color color) : base(CreateSolidPatternInternal(color))
    {
    }

    private static IntPtr CreateSolidPatternInternal(Color color)
    {
        LibCairo.HelperConvertColor(color, out var r,
            out var g,
            out var b,
            out var a);
        
        return LibCairo.cairo_pattern_create_rgba(r, g, b, a);
    }
}