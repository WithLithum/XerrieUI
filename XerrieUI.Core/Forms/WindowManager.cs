// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;
using XerrieUI.Native;
using XerrieUI.Native.Windowing;

namespace XerrieUI.Core.Forms;

internal class WindowManager
{
    private readonly Dictionary<uint, Window> _windows = [];

    public void Map(uint windowId, Window window)
    {
        _windows[windowId] = window;
    }

    public void Unmap(uint windowId)
    {
        _windows.Remove(windowId);
    }

    public unsafe void OnExpose(xcb_expose_event_t* e)
    {
        if (!_windows.TryGetValue(e->window, out var window))
        {
            Console.WriteLine("Window not found: #{0}", e->window);
            return;
        }
        
        var rectangle = new Rectangle(e->x, e->y, e->width, e->height);
        window.RefreshAreaDevice(rectangle);
    }

    public unsafe void OnConfigureNotify(xcb_configure_notify_event_t* e)
    {
        if (!_windows.TryGetValue(e->window, out var window))
        {
            Console.WriteLine("Window not found: #{0}", e->window);
            return;
        }

        window.OnConfigureNotify(e);
    }

    public void OnDeleteWindow(uint windowId)
    {
        if (!_windows.TryGetValue(windowId, out var window))
        {
            Console.WriteLine("Window not found: #{0}", window);
            return;
        }

        if (window.OnClosing())
        {
            window.Close();
        }
    }

    public void OnShown(uint windowId)
    {
        DoOnWindow(windowId, window => window.OnShown());
    }

    private void DoOnWindow(uint windowId, Action<Window> action)
    {
        if (!_windows.TryGetValue(windowId, out var window))
        {
            Console.WriteLine("Window not found: #{0}", window);
            return;
        }
        
        action.Invoke(window);
    }

    public void OnHidden(uint windowId)
    {
        DoOnWindow(windowId, window => window.OnHidden());
    }

    public void OnPropertyChange(uint window, uint atom)
    {
        switch (atom)
        {
            case (uint)PrimitiveAtoms.WmName:
                DoOnWindow(window, w => w.OnTextChanged());
                break;
        }
    }

    public void OnButtonPress(uint window, MouseButton button, short x, short y, bool isPressOrRelease)
    {
        Action<Window> action = isPressOrRelease
            ? w => w.OnMouseDownDevice(x, y, button)
            : w => w.OnMouseUpDevice(x, y, button);
        
        DoOnWindow(window, action);
    }
}