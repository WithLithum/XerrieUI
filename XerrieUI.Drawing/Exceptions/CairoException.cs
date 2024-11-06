// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using XerrieUI.Drawing.Interop;

namespace XerrieUI.Drawing.Exceptions;

public class CairoException : Exception
{
    public CairoException(CairoStatus status) : base($"A {status} error have occurred.")
    {
        ErrorCode = status;
    }
    
    public CairoStatus ErrorCode { get; }
}