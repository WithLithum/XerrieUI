// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.InteropServices;

namespace XerrieUI.Drawing.Interop;

internal static partial class LibFreeType
{
    private const string LibName = "libfreetype.so.6";

    [LibraryImport(LibName)]
    internal static unsafe partial FreeTypeError FT_Init_FreeType(IntPtr* output);
    
    [LibraryImport(LibName)]
    internal static partial FreeTypeError FT_Done_FreeType(IntPtr handle);
    
    [LibraryImport(LibName)]
    internal static partial FreeTypeError FT_Done_Face(IntPtr handle);

    [LibraryImport(LibName, StringMarshalling = StringMarshalling.Utf8)]
    internal static unsafe partial FreeTypeError FT_New_Face(IntPtr library,
        string filePathName,
        long faceIndex,
        IntPtr* facePtr);

    [LibraryImport(LibName)]
    internal static partial FreeTypeError FT_Reference_Face(IntPtr face);
}