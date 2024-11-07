// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;
using System.Globalization;
using XerrieUI.Controls;
using XerrieUI.Core;
using XerrieUI.Core.Forms;
using XerrieUI.Drawing.Fonts.Config;

Application.Initialize();

using var window = new Window();

var label = new Label
{
    Location = new Point(20, 20),
    Text = "Hello World!"
};

window.Children.Add(label);

window.MouseUp += (_, args) =>
{
    if (args.Button == MouseButton.Left)
    {
        label.Location = args.Location;
    }
};

label.Refresh(false);

Application.Run(window);