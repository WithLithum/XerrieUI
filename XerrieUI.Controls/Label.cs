// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
//
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;
using XerrieUI.Core.Drawing;
using XerrieUI.Core.Forms.Controls;
using XerrieUI.Drawing.Fonts;
using XerrieUI.Drawing.Patterns;

namespace XerrieUI.Controls;

public class Label : AbstractControl
{
    private string? _lastText = "Label";
    private TextExtents _extents;
    private string _text = "Label";

    public Label()
    {
        BackgroundColor = Color.Transparent;
        ForegroundColor = Color.Black;
        Text = "Label";
    }

    public string FontPattern { get; set; } = "sans-serif";

    public string Text
    {
        get => _text;
        set
        {
            _text = value;
            Refresh(true);
        }
    }

    public bool AutoSize { get; set; } = true;
    
    public override void Render(IRenderer renderer)
    {
        base.Render(renderer);
        renderer.SetFont(FontPattern);

        if (Text != _lastText && renderer.CurrentFont != null)
        {
            _lastText = Text;
            _extents = renderer.Graphics.GetTextExtents(renderer.CurrentFont, Text);
            ApplyControlSize(new Size((int)Math.Ceiling(_extents.Width), 
                (int)Math.Ceiling(_extents.Height)));
        }

        
        using var pattern = new SolidPattern(ForegroundColor);
        renderer.DrawText(pattern, Location, Text);
    }
    
}
