// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

namespace XerrieUI.Controls.Theming;

public static class ThemeControl
{
    private static ITheme _themeValue = DefaultTheme.Instance;

    public static event EventHandler? ThemeChanged;

    public static ITheme Theme
    {
        get => _themeValue;
        set
        {
            ArgumentNullException.ThrowIfNull(value);
            _themeValue = value;
            ThemeChanged?.Invoke(null, EventArgs.Empty);
        }
    }
}