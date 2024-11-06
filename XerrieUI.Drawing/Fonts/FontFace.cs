// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using XerrieUI.Drawing.Exceptions;
using XerrieUI.Drawing.Interop;

namespace XerrieUI.Drawing.Fonts;

public class FontFace : IDisposable
{
    internal FontFace(IntPtr handle)
    {
        Handle = handle;
    }
    
    internal IntPtr Handle { get; }

    #region Disposing
    
    private void ReleaseUnmanagedResources()
    {
        FreeTypeException.ThrowIfNotOk(LibFreeType.FT_Done_Face(Handle));
    }

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }

    ~FontFace()
    {
        ReleaseUnmanagedResources();
    }
    
    #endregion
}