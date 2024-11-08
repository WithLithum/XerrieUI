// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;

namespace XerrieUI.Controls.Theming;

public sealed class DefaultTheme : ITheme
{
    public Color BackgroundColor => Color.White;
    public Color ForegroundColor => Color.Black;

    public string FontPattern => "sans-serif";

    public static DefaultTheme Instance { get; } = new();
}