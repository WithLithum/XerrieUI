// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: LGPL-3.0-or-later

using System.ComponentModel;
using System.Drawing;
using XerrieUI.Drawing.Math;
using XerrieUI.Native;
using XerrieUI.Native.Windowing;

namespace XerrieUI.Core.Forms;

partial class CoreWindow
{
    internal unsafe void OnConfigureNotify(xcb_configure_notify_event_t* e)
    {
        var newPos = new Point(e->x, e->y);
        if (Location != newPos)
        {
            UpdateLocation(newPos);
        }
        
        var newSize = new Size(e->width, e->height);
        if (Size != newSize)
        {
            UpdateSize(newSize);
        }
    }

    protected override void ApplyControlSize(Size size)
    {
        Application.EnsureConnection().Windows.Configure(_xcbWindow,
            ConfigureWindowValueMask.Width | ConfigureWindowValueMask.Height,
            [(uint)size.Width, (uint)size.Height]);
    }

    protected override void ApplyControlLocation(Point location)
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

    protected override void UpdateSize(Size size)
    {
        base.UpdateSize(size);
        _renderer.SetSize(size);
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

    public override void RefreshArea(Rectangle rectangle)
    {
        Refresh(false);
        base.RefreshArea(rectangle);
    }

    #region Device coordinate event utils
    
    internal void OnMouseDownDevice(short x, short y, MouseButton button)
    {
        if (button is MouseButton.RollUp or MouseButton.RollDown)
        {
            return;
        }
        
        OnMouseDown(ToUserPoint(x, y),
            button);
    }

    private Point ToUserPoint(short x, short y)
    {
        return _renderer.Graphics.DeviceToUser(new PointD(x, y)).ToPoint();
    }

    internal void OnMouseUpDevice(short x, short y, MouseButton button)
    {
        if (button is MouseButton.RollUp or MouseButton.RollDown)
        {
            OnMouseWheel(ToUserPoint(x, y), button);
            return;
        }
        
        OnMouseUp(ToUserPoint(x, y),
            button);
    }
    
    public void RefreshAreaDevice(Rectangle rectangle)
    {
        RefreshArea(_renderer.Graphics.DeviceToUser(rectangle).ToRectangle());
    }
    
    #endregion
}