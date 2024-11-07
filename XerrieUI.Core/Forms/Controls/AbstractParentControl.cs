// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;
using XerrieUI.Core.Drawing;

namespace XerrieUI.Core.Forms.Controls;

public abstract class AbstractParentControl : AbstractControl
{
    protected AbstractParentControl()
    {
        Children = new ControlChildrenCollection(this);
    }
    
    public ControlChildrenCollection Children { get; }

    public override void Render(IRenderer renderer)
    {
        base.Render(renderer);
        
        foreach (var child in Children)
        {
            if (!child.Updated) child.Render(renderer);
        } 
        
        renderer.Graphics.Flush();
    }

    public override void Refresh(bool doNotPropagate)
    {
        Updated = false; // base refresh propagates this request
        
        if (doNotPropagate) return;
        
        foreach (var child in Children)
        {
            child.Refresh(doNotPropagate);
        }
    }

    public override void RefreshArea(Rectangle rectangle)
    {
        foreach (var child in Children)
        {
            child.RefreshArea(rectangle);
        }
    }
}
