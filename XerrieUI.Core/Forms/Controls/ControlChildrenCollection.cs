// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Collections.ObjectModel;

namespace XerrieUI.Core.Forms.Controls;

public sealed class ControlChildrenCollection : Collection<AbstractControl>
{
    private readonly AbstractParentControl _parent;

    public ControlChildrenCollection(AbstractParentControl parent)
    {
        _parent = parent;
    }
    
    protected override void InsertItem(int index, AbstractControl item)
    {
        item.Parent = _parent;
        base.InsertItem(index, item);
    }
}