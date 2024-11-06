// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using XerrieUI.Drawing.Interop;

namespace XerrieUI.Drawing.Exceptions;

public class FreeTypeException : Exception
{
    public FreeTypeException(FreeTypeError error) : base(error.ToString())
    {
        ErrorCode = error;
    }
    
    public FreeTypeError ErrorCode { get; }

    public static void ThrowIfNotOk(FreeTypeError error)
    {
        if (error != FreeTypeError.Ok)
        {
            throw new FreeTypeException(error);
        }
    }
}