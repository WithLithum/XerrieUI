// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.InteropServices;
using XerrieUI.Drawing.Fonts.Config;

namespace XerrieUI.Drawing.Interop;

internal static partial class LibFontConfig
{
    private const string LibName = "libfontconfig.so.1";

    private const int FcFalse = 0;
    private const int FcTrue = 1;
    private const int FcDontCare = 2;

    #region Structures

    internal enum FcBool
    {
        False = FcFalse,
        True = FcTrue,
        DontCare = FcDontCare
    }
    
    internal enum FcType
    {
        FcTypeUnknown = -1,
        FcTypeVoid,
        FcTypeInteger,
        FcTypeDouble,
        FcTypeString,
        FcTypeBool,
        FcTypeMatrix,
        FcTypeCharSet,
        FcTypeFtFace,
        FcTypeLangSet,
        FcTypeRange
    }
    
    [StructLayout(LayoutKind.Sequential)]
    internal struct FcMatrix
    {
        public double xx;
        public double xy;
        public double yx;
        public double yy;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    internal unsafe struct FcValue
    {
        [FieldOffset(0)] public FcType type;

        [FieldOffset(4)] public byte* s;
        [FieldOffset(4)] public int i;
        [FieldOffset(4)] public int b;
        [FieldOffset(4)] public double d;
        [FieldOffset(4)] public FcMatrix* m;
        /// <summary>
        /// A handle of <c>FcCharSet</c>.
        /// </summary>
        [FieldOffset(4)] public IntPtr c;
        /// <summary>
        /// An arbitrary pointer value.
        /// </summary>
        [FieldOffset(4)] public IntPtr f;
        /// <summary>
        /// A handle of <c>FcLangSet</c>.
        /// </summary>
        [FieldOffset(4)] public IntPtr l;
        /// <summary>
        /// A handle of <c>FcRange</c>.
        /// </summary>
        [FieldOffset(4)] public IntPtr r;
    }

    #endregion

    /// <summary>
    /// Loads the default configuration file and the fonts referenced therein and
    /// sets the default configuration to that result. If the default configuration
    /// has already been loaded, this routine does nothing and returns FcTrue. 
    /// </summary>
    /// <returns>Whether this process succeeded or not.</returns>
    [LibraryImport(LibName)]
    internal static partial FcBool FcInit();

    [LibraryImport(LibName)]
    internal static partial void FcFini();

    [LibraryImport(LibName)]
    internal static partial void FcConfigDestroy(IntPtr config);

    [LibraryImport(LibName)]
    internal static partial IntPtr FcConfigReference(IntPtr config);
    
    [LibraryImport(LibName)]
    internal static partial IntPtr FcConfigGetCurrent();
    
    [LibraryImport(LibName)]
    internal static partial IntPtr FcConfigGetFonts(IntPtr config, LocalFontSetKind kind);

    [LibraryImport(LibName)]
    internal static partial IntPtr FcFontMatch(IntPtr config, IntPtr pattern, out FontMatchResult matchResult);

    #region Patterns

    [LibraryImport(LibName)]
    internal static partial void FcDefaultSubstitute(IntPtr pattern);
    
    [LibraryImport(LibName)]
    internal static partial FcBool FcConfigSubstitute(IntPtr config, IntPtr pattern, MatchKind kind);
    
    [LibraryImport(LibName, StringMarshalling = StringMarshalling.Utf8)]
    internal static partial IntPtr FcNameParse(string name);

    [LibraryImport(LibName, StringMarshalling = StringMarshalling.Utf8)]
    internal static partial FcBool FcPatternAdd(IntPtr pattern, string property, FcValue value, FcBool append);

    [LibraryImport(LibName, StringMarshalling = StringMarshalling.Utf8)]
    internal static unsafe partial FontMatchResult FcPatternGetDouble(IntPtr pattern, string property, int num,
        double* ptr);
    
    [LibraryImport(LibName, StringMarshalling = StringMarshalling.Utf8)]
    internal static unsafe partial FontMatchResult FcPatternGetInteger(IntPtr pattern, string property, int num,
        int* ptr);
    
    [LibraryImport(LibName, StringMarshalling = StringMarshalling.Utf8)]
    internal static unsafe partial FontMatchResult FcPatternGetString(IntPtr pattern, string property, int num, IntPtr* ptr);
    
    [LibraryImport(LibName, StringMarshalling = StringMarshalling.Utf8)]
    internal static partial FcBool FcPatternAddString(IntPtr pattern, string property, string value);
    
    [LibraryImport(LibName, StringMarshalling = StringMarshalling.Utf8)]
    internal static partial FcBool FcPatternAddInteger(IntPtr pattern, string property, int value);
    
    [LibraryImport(LibName)]
    internal static partial IntPtr FcPatternCreate();

    [LibraryImport(LibName, StringMarshalling = StringMarshalling.Utf8)]
    internal static partial FcBool FcPatternDel(IntPtr pattern, string property);
    
    [LibraryImport(LibName)]
    internal static partial void FcPatternDestroy(IntPtr pattern);

    [LibraryImport(LibName)]
    internal static partial IntPtr FcPatternDuplicate(IntPtr pattern);

    [LibraryImport(LibName)]
    internal static partial void FcPatternReference(IntPtr pattern);

    [LibraryImport(LibName)]
    internal static unsafe partial byte* FcNameUnparse(IntPtr pattern);

    #endregion

    #region Font Sets

    [LibraryImport(LibName)]
    internal static partial FcBool FcFontSetAdd(IntPtr fontSet, IntPtr pattern);
    
    [LibraryImport(LibName)]
    internal static partial IntPtr FcFontSetCreate();

    [LibraryImport(LibName)]
    internal static partial void FcFontSetDestroy(IntPtr fontSet);

    #endregion
}