// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
//
// SPDX-License-Identifier: LGPL-3.0-or-later

using System.Drawing;
using XerrieUI.Core.Drawing;
using XerrieUI.Core.Forms.Controls;
using XerrieUI.Drawing.Fonts;
using XerrieUI.Drawing.Math;
using XerrieUI.Drawing.Patterns;

namespace XerrieUI.Controls;

public class Label : UiControl
{
    private string? _lastText = "Label";
    private TextExtents _extents;
    private string _text = "Label";

    private string? _fontPattern;

    public Label()
    {
        Text = "Label";
    }

    public string FontPattern
    {
        get => _fontPattern ?? Theme.FontPattern;
        set => _fontPattern = value;
    }

    public string Text
    {
        get => _text;
        set
        {
            _text = value;
            Refresh(true);
        }
    }

    public override Color BackgroundColor { get; set; } = Color.Transparent;

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

        var targetX = Location.X - _extents.XBearing;
        var targetY = Location.Y - _extents.YBearing;
        
        using var pattern = new SolidPattern(ForegroundColor);
        renderer.DrawText(pattern, new PointD(targetX, targetY), Text);
    }
    
}
