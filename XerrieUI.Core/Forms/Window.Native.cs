// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.ComponentModel;
using System.Drawing;
using XerrieUI.Native;
using XerrieUI.Native.Windowing;

namespace XerrieUI.Core.Forms;

partial class Window
{
    internal unsafe void OnConfigureNotify(xcb_configure_notify_event_t* e)
    {
        var newPos = new Point(e->x, e->y);
        if (Location != newPos)
        {
            OnMove(newPos);
        }
        
        var newSize = new Size(e->width, e->height);
        if (Size != newSize)
        {
            OnResize(newSize);
        }
    }

    protected override void SetControlSize(Size size)
    {
        Application.EnsureConnection().Windows.Configure(_xcbWindow,
            ConfigureWindowValueMask.Width | ConfigureWindowValueMask.Height,
            [(uint)size.Width, (uint)size.Height]);
    }

    protected override void SetControlLocation(Point location)
    {
        Application.EnsureConnection().Windows.Configure(_xcbWindow,
            ConfigureWindowValueMask.X | ConfigureWindowValueMask.Y,
            [(uint)location.X, (uint)location.Y]);
    }
    
    internal bool OnClosing()
    {
        var cancelArgs = new CancelEventArgs();
        Closing?.Invoke(this, cancelArgs);
        
        return !cancelArgs.Cancel;
    }

    internal void Close()
    {
        Hide();
        Closed?.Invoke(this, EventArgs.Empty);
        Dispose();
    }

    private string GetText()
    {
        return Application.EnsureConnection().Windows.GetStringProperty(_xcbWindow,
            (uint)PrimitiveAtoms.WmName);
    }
    
    private void SetText(string text)
    {
        Application.EnsureConnection().Windows.ChangeProperty(_xcbWindow,
            (uint)PrimitiveAtoms.WmName,
            text);
    }

    protected override void OnResize(Size size)
    {
        base.OnResize(size);
        _renderer.SetSize(size);
    }

    public override void RefreshArea(Rectangle area)
    {
        Render(GetRenderer());
    }

    internal void OnShown()
    {
        Shown?.Invoke(this, EventArgs.Empty);
    }

    internal void OnHidden()
    {
        Hidden?.Invoke(this, EventArgs.Empty);
    }

    public void OnTextChanged()
    {
        TextChanged?.Invoke(this, EventArgs.Empty);
    }
}