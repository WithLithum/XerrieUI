// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.InteropServices;

namespace XerrieUI.Native.Interop;

/// <summary>
/// Indicates that the return value must be freed by using <see cref="Marshal.FreeHGlobal"/>.
/// </summary>
[AttributeUsage(AttributeTargets.ReturnValue)]
public sealed class MustFreeAttribute : Attribute
{
}