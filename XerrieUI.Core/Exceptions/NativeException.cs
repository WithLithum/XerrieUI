// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

namespace XerrieUI.Core.Exceptions;

public class NativeException : Exception
{
    public NativeException(string message) : this(message, 0)
    {
    }
    
    public NativeException(string message, int errorCode) : base(message)
    {
        ErrorCode = errorCode;
    }
    
    public int ErrorCode { get; }
}