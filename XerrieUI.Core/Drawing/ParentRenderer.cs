// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using XerrieUI.Core.Forms.Controls;

namespace XerrieUI.Core.Drawing;

internal class ParentRenderer
{
    private readonly HashSet<IRenderingParent> _controls = [];

    public void Add(IRenderingParent control)
    {
        _controls.Add(control);
    }

    public void Remove(IRenderingParent control)
    {
        _controls.Remove(control);
    }
    
    public void Update()
    {
        foreach (var control in _controls.Where(control => control.Updated))
        {
            control.Render(control.GetRenderer());
        }
    }
}