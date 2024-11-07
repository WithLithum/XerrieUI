// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

namespace XerrieUI.Native.Windowing;

public readonly record struct XcbWindowAttributes
{
    public unsafe XcbWindowAttributes(xcb_get_window_attributes_reply_t* reply)
    {
        AllEventMasks = (WindowEventMask)reply->all_event_masks;
        BackingPixel = reply->backing_pixel;
        Class = (WindowClass)reply->_class;
        VisualId = reply->visual;
        YourEventMask = (WindowEventMask)reply->your_event_mask;
    }
    
    public WindowEventMask AllEventMasks { get; }
    public uint BackingPixel { get; }
    public WindowClass Class { get; }
    public uint VisualId { get; }
    public WindowEventMask YourEventMask { get; }
}