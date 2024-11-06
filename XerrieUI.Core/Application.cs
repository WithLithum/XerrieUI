// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Reflection;
using XerrieUI.Core.Exceptions;
using XerrieUI.Core.Forms;
using XerrieUI.Core.Platform;
using XerrieUI.Core.Platform.Events;
using XerrieUI.Native;

namespace XerrieUI.Core;

public static class Application
{
    internal static readonly string ApplicationClass =
        Assembly.GetEntryAssembly()?.GetName().Name ?? "XerrieApplication";
    
    private static XcbConnection? Connection { get; set; }

    internal static XcbConnection EnsureConnection()
    {
        return Connection ?? throw new InvalidOperationException("Application is not yet initialized.");
    }

    internal static WindowManager WindowManager { get; } = new();

    public static void Initialize()
    {
        try
        {
            Connection = XcbConnection.Connect(null);
        }
        catch (Exception e)
        {
            throw InitializationException.CreateXConnectFailed(e);
        }
    }

    public static void Run(Window window)
    {
        window.Show();
        
        while (Connection != null)
        {
            if (window.Disposed)
            {
                Shutdown();
                break;
            }

            EventLoop.Pass(Connection);
            
            if (!window.Updated)
            {
                window.Render(window.GetRenderer());
            }
        }
    }
    
    private static void Shutdown()
    {
        Connection?.Dispose();
    }
}