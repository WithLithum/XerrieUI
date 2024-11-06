// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;
using XerrieUI.Drawing;

namespace XerrieUI.Core.Drawing;

public class WindowRenderer : IDisposable, IRenderer
{
    private readonly XcbCairoSurface _surface;

    public WindowRenderer(XcbCairoSurface surface)
    {
        _surface = surface;
        Graphics = new CairoContext(surface);
    }

    public void Dispose()
    {
        _surface.Dispose();
        GC.SuppressFinalize(this);
    }

    public CairoContext Graphics { get; }

    public void SetSize(Size size)
    {
        _surface.SetSize(size);
    }
}