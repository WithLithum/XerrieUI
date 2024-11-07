// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace XerrieUI.Core.Forms.Controls;

public sealed class MouseButtonEventArgs : EventArgs
{
    [SetsRequiredMembers]
    public MouseButtonEventArgs(Point location, MouseButton button)
    {
        Location = location;
        Button = button;
    }
    
    public required Point Location { get; init; }
    public required MouseButton Button { get; init; }
}