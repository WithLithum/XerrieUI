// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using XerrieUI.Drawing.Patterns;

namespace XerrieUI.Drawing;

public sealed class Pen : IDisposable
{
    public Pen(CairoPattern pattern, double width)
    {
        Pattern = pattern;
        Width = width;
    }

    public CairoPattern Pattern { get; }
    public double Width { get; }

    public void Dispose()
    {
        Pattern.Dispose();
    }
}