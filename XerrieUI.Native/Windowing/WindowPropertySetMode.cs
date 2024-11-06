// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

namespace XerrieUI.Native.Windowing;

public enum WindowPropertySetMode : byte
{
    /// <summary>
    /// Discard the previous property value and store the new data. 
    /// </summary>
    Replace,
    /// <summary>
    /// Insert the new data before the beginning of existing data. The <c>format</c> must
    /// match existing property value. If the property is undefined, it is treated as
    /// defined with the correct type and format with zero-length data.
    /// </summary>
    Prepend,
    /// <summary>
    /// Insert the new data after the beginning of existing data. The <c>format</c> must
    /// match existing property value. If the property is undefined, it is treated as
    /// defined with the correct type and format with zero-length data.
    /// </summary>
    Append
}