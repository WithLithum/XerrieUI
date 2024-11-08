// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;

namespace XerrieUI.Controls.Theming;

public interface ITheme
{
    public Color BackgroundColor { get; }
    public Color ForegroundColor { get; }
    
    public string FontPattern { get; }
}