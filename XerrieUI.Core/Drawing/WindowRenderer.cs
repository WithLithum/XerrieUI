// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;
using XerrieUI.Core.Forms;
using XerrieUI.Drawing;

namespace XerrieUI.Core.Drawing;

internal class WindowRenderer : ParentRenderer
{
    private readonly XcbCairoSurface _surface;

    public WindowRenderer(CoreWindow coreWindow, XcbCairoSurface surface) : base(coreWindow)
    {
        _surface = surface;
        Graphics = new CairoContext(surface);
    }

    public override void Dispose()
    {
        _surface.Dispose();
        base.Dispose();
        
        GC.SuppressFinalize(this);
    }

    public override CairoContext Graphics { get; }

    public void SetSize(Size size)
    {
        _surface.SetSize(size);
    }
}