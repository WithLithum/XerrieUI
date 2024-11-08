// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: LGPL-3.0-or-later

using System.Drawing;
using XerrieUI.Drawing;
using XerrieUI.Drawing.Math;
using XerrieUI.Drawing.Patterns;

namespace XerrieUI.Core.Drawing;

public interface IRenderer
{
    CairoFont? CurrentFont { get; }
    CairoContext Graphics { get; }
    
    void DrawText(CairoPattern pattern, PointD point, string text, bool correctBounds = false);
    void SetFont(string pattern);
}