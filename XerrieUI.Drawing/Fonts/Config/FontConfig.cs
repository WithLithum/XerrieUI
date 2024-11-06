// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using JetBrains.Annotations;
using XerrieUI.Drawing.Exceptions;
using XerrieUI.Drawing.Interop;
using static XerrieUI.Drawing.Interop.LibFontConfig;

namespace XerrieUI.Drawing.Fonts.Config;

public class FontConfig : IDisposable
{
    #region Static Members
    
    /// <summary>
    /// Loads the default configuration file and the fonts referenced therein and sets the default
    /// configuration to that result. If the default configuration has already been loaded,
    /// this routine does nothing. 
    /// </summary>
    /// <exception cref="FontConfigException">Failed to initialize FontConfig.</exception>
    public static void Initialize()
    {
        var result = FcInit();
        if (result != FcBool.True)
        {
            throw FontConfigException.CreateLoadFailed();
        }
    }

    /// <summary>
    /// References the current <see cref="FontConfig"/> and creates a new instance
    /// that represents the referenced <see cref="FontConfig"/>.
    /// </summary>
    /// <returns>A new instance of the <see cref="FontConfig"/> class representing the referenced unmanaged <see cref="FontConfig"/>.</returns>
    [MustDisposeResource]
    public static FontConfig Reference() => new(FcConfigReference(IntPtr.Zero));

    /// <summary>
    /// Frees all data structures allocated by previous calls to fontconfig functions.
    /// Fontconfig returns to an uninitialized state, requiring a new call to <see cref="Initialize"/>
    /// before any other fontconfig function may be called.
    /// </summary>
    public static void Shutdown()
    {
        FcFini();
    }
    
    #endregion

    private FontConfig(IntPtr handle)
    {
        Handle = handle;
    }
    
    private IntPtr Handle { get; }

    public FontSet GetLocalSet(LocalFontSetKind kind)
    {
        var set = FcConfigGetFonts(Handle, kind);
        return new FontSet(set, true);
    }

    /// <summary>
    /// Attempts to acquire the best font matching with the specified pattern,
    /// and creates a pattern explicitly referencing that font.
    /// </summary>
    /// <param name="pattern">The pattern to match with. Prior to matching, <see cref="FontPattern.SetDefaultsIfAbsent"/>
    /// and <see cref="FontPattern.SetMatchKind"/> must be called.</param>
    /// <param name="result">The resulting pattern, or <see langword="null"/> if not found.</param>
    /// <returns>The matching result.</returns>
    public FontMatchResult TryMatch(FontPattern pattern, [MustDisposeResource] out FontPattern? result)
    {
        var retPattern = FcFontMatch(Handle, pattern.Handle, out var matchResult);
        result = retPattern != IntPtr.Zero ? new FontPattern(retPattern) : null;

        Console.WriteLine(matchResult);
        if (matchResult == FontMatchResult.Match) return matchResult;
        
        result?.Dispose();
        result = null;

        return matchResult;
    }

    private void ReleaseUnmanagedResources()
    {
        FcConfigDestroy(Handle);
    }

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }

    ~FontConfig()
    {
        ReleaseUnmanagedResources();
    }
}