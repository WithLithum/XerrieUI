// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

namespace XerrieUI.Core.Exceptions;

public class InitializationException : Exception
{
    public InitializationException()
    {
    }

    public InitializationException(string? message) : base(message)
    {
    }

    public InitializationException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    public static InitializationException CreateXConnectFailed(Exception innerException)
    {
        return new InitializationException("Failed to connect to X server.", innerException);
    }
}