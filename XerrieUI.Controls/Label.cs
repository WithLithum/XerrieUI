// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
//
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;
using XerrieUI.Core.Drawing;
using XerrieUI.Drawing.Patterns;

namespace XerrieUI.Controls;

public class Label : BaseControl
{
    public Label()
    {
        BackgroundColor = Color.Transparent;
    }
    
    public string Text { get; set; }
    
    public override void Render(IRenderer renderer)
    {
        base.Render(renderer);

        using var pattern = new SolidPattern(ForegroundColor);
        // renderer.Graphics.FillText(pattern, Text, );
    }
}