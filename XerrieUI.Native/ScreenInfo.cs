// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using XerrieUI.Native.Windowing;

namespace XerrieUI.Native;

public sealed class ScreenInfo
{
    private readonly xcb_screen_t _screen;

    internal unsafe ScreenInfo(xcb_screen_t* screen)
    {
        _screen = *screen;
    }

    public XcbWindowHandle RootXcbWindow => new(_screen.root);
    
    public uint RootVisual => _screen.root_visual;
    
    public uint WhitePixel => _screen.white_pixel;
}