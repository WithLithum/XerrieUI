// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

namespace XerrieUI.Drawing.Exceptions;

public class FontConfigException : Exception
{
    public FontConfigException()
    {
    }

    public FontConfigException(string? message) : base(message)
    {
    }

    public FontConfigException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    internal static FontConfigException CreateAddFailed()
    {
        return new FontConfigException("Failed to add property.");
    }
    
    internal static FontConfigException CreateLoadFailed()
    {
        return new FontConfigException("Failed to initialize font configuration.");
    }

    public static FontConfigException CreateRemoveFailed()
    {
        return new FontConfigException("Failed to remove property.");
    }
}