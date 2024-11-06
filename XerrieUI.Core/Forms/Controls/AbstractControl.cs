// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;
using XerrieUI.Core.Drawing;
using XerrieUI.Drawing;
using XerrieUI.Drawing.Patterns;

namespace XerrieUI.Core.Forms.Controls;

public abstract class AbstractControl : IRenderable
{
    private Point _location;
    private Size _size;
    
    #region Events

    public event EventHandler? Moved;
    public event EventHandler? Resized;
    
    #endregion
    
    public Rectangle Bounds { get; set; }

    public Color BackgroundColor { get; set; } = Color.White;
    
    public bool Updated { get; private set; }

    public Point Location
    {
        get => _location;
        set => SetControlLocation(value);
    }

    public Size Size
    {
        get => _size;
        set => SetControlSize(value);
    }
    
    public virtual void Render(IRenderer renderer)
    { 
        var graphics = renderer.Graphics;
        using var color = new SolidPattern(BackgroundColor);
        
        graphics.FillRectangle(color, new RectangleF(PointF.Empty, Size));
        graphics.DrawRectangle(new Pen(color, 3), new RectangleF(PointF.Empty, Size));

        Updated = true;
    }

    public virtual void RefreshArea(Rectangle area)
    {
        // TODO actually refresh any area
        Updated = false;
    }

    protected void OnMove(Point moveTo)
    {
        _location = moveTo;
        Moved?.Invoke(this, EventArgs.Empty);
    }

    protected virtual void OnResize(Size size)
    {
        _size = size;
        Resized?.Invoke(this, EventArgs.Empty);
    }
    
    protected abstract void SetControlSize(Size size);
    protected abstract void SetControlLocation(Point location);
}