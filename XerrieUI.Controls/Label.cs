// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
//
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;
using XerrieUI.Core.Drawing;
using XerrieUI.Core.Forms.Controls;
using XerrieUI.Drawing.Patterns;

namespace XerrieUI.Controls;

public class Label : AbstractControl
{
    public Label()
    {
        BackgroundColor = Color.Transparent;
        ForegroundColor = Color.Black;
    }

    public string FontPattern { get; set; } = "sans-serif";

    public string Text { get; set; } = "Label";
    
    public override void Render(IRenderer renderer)
    {
        base.Render(renderer);
        
        using var pattern = new SolidPattern(ForegroundColor);
        renderer.SetFont(FontPattern);
        renderer.DrawText(pattern, Location, Text);
    }
}