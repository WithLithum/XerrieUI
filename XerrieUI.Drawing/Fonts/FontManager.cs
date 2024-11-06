// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using XerrieUI.Drawing.Exceptions;
using XerrieUI.Drawing.Interop;

namespace XerrieUI.Drawing.Fonts;

public class FontManager : IDisposable
{
    private readonly IntPtr _handle;

    public unsafe FontManager()
    {
        IntPtr varHandle;
        FreeTypeException.ThrowIfNotOk(LibFreeType.FT_Init_FreeType(&varHandle));

        _handle = varHandle;
    }

    public unsafe FontFace CreateFace(string filePath, long faceIndex)
    {
        IntPtr fontHandle;
        FreeTypeException.ThrowIfNotOk(LibFreeType.FT_New_Face(_handle,
            filePath,
            faceIndex,
            &fontHandle));

        return new FontFace(fontHandle);
    }

    #region Disposing
    
    private void ReleaseUnmanagedResources()
    {
        FreeTypeException.ThrowIfNotOk(LibFreeType.FT_Done_FreeType(_handle));
    }

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }

    ~FontManager()
    {
        ReleaseUnmanagedResources();
    }
    
    #endregion
}