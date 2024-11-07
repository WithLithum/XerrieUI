// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

namespace XerrieUI.Core;

public enum MouseButton : byte
{
    /// <summary>
    /// No mouse button were pressed.
    /// </summary>
    None,
    /// <summary>
    /// The left mouse button was pressed.
    /// </summary>
    Left,
    /// <summary>
    /// The middle mouse button (the mouse wheel) was pressed.
    /// </summary>
    Middle,
    /// <summary>
    /// The right mouse button was pressed.
    /// </summary>
    Right,
    /// <summary>
    /// The mouse wheel was rolled upwards.
    /// </summary>
    RollUp,
    /// <summary>
    /// The mouse wheel was rolled downwards.
    /// </summary>
    RollDown,
    /// <summary>
    /// The first side button was pressed.
    /// </summary>
    XButton1 = 8,
    /// <summary>
    /// The second side button was pressed.
    /// </summary>
    XButton2 = 9,
}