// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;
using XerrieUI.Controls.Theming;
using XerrieUI.Core.Forms;

namespace XerrieUI.Controls;

public class Window : CoreWindow
{
    private Color? _backgroundColor;
    private Color? _foregroundColor;
    private ITheme? _theme;

    /// <summary>
    /// Gets or sets the current effective theme of this control.
    /// </summary>
    public ITheme Theme
    {
        get => _theme ?? ThemeControl.Theme;
        set => _theme = value;
    }
    
    public override Color BackgroundColor
    {
        get => _backgroundColor ?? Theme.BackgroundColor;
        set => _backgroundColor = value;
    }

    public override Color ForegroundColor
    {
        get => _foregroundColor ?? Theme.ForegroundColor;
        set => _foregroundColor = value;
    }
}