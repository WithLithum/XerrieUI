// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using XerrieUI.Core.Drawing;

namespace XerrieUI.Core.Forms.Controls;

public interface IRendered
{
    bool Updated { get; }

    void Render(IRenderer renderer);
}