// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

namespace XerrieUI.Native;

public sealed class XcbSetup
{
    private readonly unsafe xcb_setup_t* _setup;

    internal unsafe XcbSetup(xcb_setup_t* setup)
    {
        _setup = setup;
    }

    public unsafe xcb_screen_iterator_t GetRootsIterator()
    {
        return Xcb.xcb_setup_roots_iterator(_setup);
    }
}