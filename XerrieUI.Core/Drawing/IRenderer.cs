// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;
using XerrieUI.Drawing;
using XerrieUI.Drawing.Patterns;

namespace XerrieUI.Core.Drawing;

public interface IRenderer
{
    CairoFont? CurrentFont { get; }
    CairoContext Graphics { get; }
    
    void DrawText(CairoPattern pattern, Point point, string text);
    void SetFont(string pattern);
}