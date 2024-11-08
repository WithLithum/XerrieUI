// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;
using XerrieUI.Controls;
using XerrieUI.Controls.Theming;
using XerrieUI.Core;
using XerrieUI.Demo;

var dracula = new DraculaTheme();

Application.Initialize();

using var window = new Window();
ThemeControl.Theme = dracula;

var label = new Label
{
    Location = new Point(20, 20),
    Text = "Hello World!",
};

window.Children.Add(label);

window.MouseUp += (_, args) =>
{
    if (args.Button == MouseButton.Left)
    {
        label.Location = args.Location;
        ThemeControl.Theme = ReferenceEquals(ThemeControl.Theme, dracula)
            ? DefaultTheme.Instance
            : dracula;
    }
};

label.Refresh(false);

Application.Run(window);