// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

// SPDX-FileCopyrightText: (c) 2023 Dracula Theme
// SPDX-License-Identifier: MIT

using System.Drawing;
using XerrieUI.Controls.Theming;

namespace XerrieUI.Demo;

public class DraculaTheme : ITheme
{
    public Color BackgroundColor { get; } = Color.FromArgb(255, 40, 42, 54);
    public Color ForegroundColor { get; } = Color.FromArgb(255, 248, 248, 242);
    public string FontPattern => "sans-serif";
}