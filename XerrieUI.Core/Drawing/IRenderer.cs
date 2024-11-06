// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using XerrieUI.Drawing;

namespace XerrieUI.Core.Drawing;

public interface IRenderer
{
    CairoContext Graphics { get; }
}