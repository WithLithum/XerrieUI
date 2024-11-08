// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.ComponentModel;
using System.Drawing;
using XerrieUI.Core.Drawing;
using XerrieUI.Core.Forms.Controls;
using XerrieUI.Core.Platform;
using XerrieUI.Drawing;
using XerrieUI.Native.Windowing;

namespace XerrieUI.Core.Forms;

public partial class Window : AbstractParentControl, IDisposable, IRenderingParent
{
    private static readonly Size DefaultSize = new(500, 350);
    
    private readonly XcbWindowHandle _xcbWindow;
    private readonly WindowRenderer _renderer;
    
    private Window(XcbWindowHandle xcbWindow, Size size)
    {
        _xcbWindow = xcbWindow;
        _renderer = new WindowRenderer(this, XcbCairoSurface.Create(Application.EnsureConnection(),
            _xcbWindow,
            size));

        var scale = Application.GetAppScale();
        _renderer.Graphics.SetScale(scale, scale);
        
        Application.WindowManager.Map(_xcbWindow.Handle, this);
    }

    public Window() : this(NativeWindows.CreateNativeWindow(DefaultSize), DefaultSize)
    {
        Text = GetType().Name;
    }

    public string Text
    {
        get => GetText();
        set => SetText(value);
    }

    public bool Disposed { get; private set; }

    public event CancelEventHandler? Closing;
    public event EventHandler? Closed;

    public event EventHandler? Shown;
    public event EventHandler? Hidden;

    public event EventHandler? TextChanged;
    
    public void Show()
    {
        Application.EnsureConnection().Windows.Map(_xcbWindow);
    }

    public void Hide()
    {
        Application.EnsureConnection().Windows.Unmap(_xcbWindow);
    }

    public void Dispose()
    {
        Application.WindowManager.Unmap(_xcbWindow.Handle);
        Application.EnsureConnection().Windows.Destroy(_xcbWindow);
        Disposed = true;
        GC.SuppressFinalize(this);
    }

    public IRenderer GetRenderer()
    {
        return _renderer;
    }
}