// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using JetBrains.Annotations;
using XerrieUI.Native.Exceptions;
using XerrieUI.Native.Interop;
using XerrieUI.Native.Windowing;

namespace XerrieUI.Native.Extensions.RAndR;

public sealed class XcbRAndR
{
    private readonly XcbConnection _connection;

    internal XcbRAndR(XcbConnection connection)
    {
        _connection = connection;
    }

    /// <summary>
    /// Enumerates the list of monitors for the screen containing the specified window.
    /// </summary>
    /// <param name="window">The window which to get the monitors from the screen it is on.</param>
    /// <param name="activeOnly">If <see langword="true"/>, only enumerates active monitors.</param>
    /// <returns>An enumerable of <see cref="MonitorInfo"/>s.</returns>
    /// <exception cref="ArgumentException">The specified window is invalid.</exception>
    public unsafe IEnumerable<MonitorInfo> EnumerateMonitors(XcbWindowHandle window, bool activeOnly)
    {
        var request = LibXcbRandR.xcb_randr_get_monitors(_connection.Handle,
            window.Handle,
            (byte)(activeOnly ? 0x01 : 0x00));
        xcb_generic_error_t error;
        var errorPtr = &error;

        var reply = LibXcbRandR.xcb_randr_get_monitors_reply_t(_connection.Handle, request, &errorPtr);
        if (error.error_code != 0)
        {
            X11Exception.ExpectWindow(error, nameof(window));
            throw X11Exception.CreateFromError(error);
        }

        var iterator = LibXcbRandR.xcb_randr_get_monitors_monitors_iterator(reply);
        return new MonitorInfoEnumerator(iterator, reply);
    }

    /// <summary>
    /// Returns an instance of <see cref="ScreenResources"/> representing various lists associated with the
    /// screen of the specified window.
    /// </summary>
    /// <param name="window">The window.</param>
    /// <returns>An instance of <see cref="ScreenResources"/>.</returns>
    /// <exception cref="ArgumentException">The specified window is invalid.</exception>
    [MustDisposeResource]
    public unsafe ScreenResources GetScreenResources(XcbWindowHandle window)
    {
        var request = LibXcbRandR.xcb_randr_get_screen_resources(_connection.Handle,
            window.Handle);

        xcb_generic_error_t error;
        var errorPtr = &error;

        var reply = LibXcbRandR.xcb_randr_get_screen_resources_reply(_connection.Handle, request, &errorPtr);
        if (error.error_code != 0)
        {
            X11Exception.ExpectWindow(error, nameof(window));
            throw X11Exception.CreateFromError(error);
        }

        return new ScreenResources(reply);
    }
}