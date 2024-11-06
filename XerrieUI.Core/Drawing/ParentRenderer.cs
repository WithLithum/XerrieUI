// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;
using XerrieUI.Core.Forms.Controls;
using XerrieUI.Drawing;

namespace XerrieUI.Core.Drawing;

public abstract class ParentRenderer : ControlRenderer
{
    private readonly AbstractParentControl _parentControl;

    protected ParentRenderer(AbstractParentControl parentControl)
    {
        _parentControl = parentControl;
    }

    public void Render(Rectangle rectangle)
    {
        foreach (var control in _parentControl.Children.Where(control => control.Updated))
        {
            control.Render(this);
        }
    }

    public abstract override CairoContext Graphics { get; }
}