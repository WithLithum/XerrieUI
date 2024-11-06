// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;
using XerrieUI.Core.Forms.Controls;

namespace XerrieUI.Controls;

public class BaseControl : AbstractControl
{
    protected override void ApplyControlSize(Size size)
    {
        var oldRect = new Rectangle(Location, Size);
        
        Size = size;
        Refresh();
        Parent?.RefreshArea(oldRect);
    }

    protected override void ApplyControlLocation(Point location)
    {
        var oldRect = new Rectangle(Location, Size);
        
        Location = location;
        Refresh();
        Parent?.RefreshArea(oldRect);
    }

    private void Refresh()
    {
        Parent?.RefreshArea(new Rectangle(Location, Size));
    }
}