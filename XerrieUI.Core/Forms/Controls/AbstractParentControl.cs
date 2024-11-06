// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using XerrieUI.Core.Drawing;

namespace XerrieUI.Core.Forms.Controls;

public abstract class AbstractParentControl : AbstractControl
{
    public IList<AbstractControl> Children { get; } = new List<AbstractControl>();

    public override void Render(IRenderer renderer)
    {
        base.Render(renderer);
        
        foreach (var child in Children)
        {
            if (child.Updated) child.Render(renderer);
        } 
        renderer.Graphics.Flush();
    }
}