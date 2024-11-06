// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Diagnostics.CodeAnalysis;

namespace XerrieUI.Native.Windowing;

public readonly record struct XcbWindowHandle
{
    [SetsRequiredMembers]
    public XcbWindowHandle(uint handle)
    {
        Handle = handle;
    }
    
    public required uint Handle { get; init; }
}