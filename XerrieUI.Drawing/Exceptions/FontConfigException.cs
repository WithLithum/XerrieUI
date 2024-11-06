// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using XerrieUI.Drawing.Fonts.Config;

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

    public static FontConfigException CreateFromGetPropertyResult(FontMatchResult result)
    {
        return result switch
        {
            FontMatchResult.NoMatch => new FontConfigException("The specified property does not exist."),
            FontMatchResult.TypeMismatch => new FontConfigException("The specified property exists but is of the wrong type."),
            FontMatchResult.NoId => new FontConfigException("The specified property exists doesn't have the specified index."),
            FontMatchResult.OutOfMemory => new FontConfigException("Failed to allocate resources for the operation."),
            _ => new FontConfigException($"Unknown error occurred: {result}")
        };
    }
}