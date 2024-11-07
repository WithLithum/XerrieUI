// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;

namespace XerrieUI.Core.Drawing;

public interface IRenderable
{
    /// <summary>
    /// Marks the current instance as requiring re-render.
    /// </summary>
    /// <param name="doNotPropagate">If <see langword="true"/>, the refresh request should not be propagated to other children.</param>
    void Refresh(bool doNotPropagate);
    
    void RefreshArea(Rectangle rectangle);
}