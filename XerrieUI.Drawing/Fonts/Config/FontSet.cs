// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using static XerrieUI.Drawing.Interop.LibFontConfig;

namespace XerrieUI.Drawing.Fonts.Config;

public class FontSet : IDisposable
{
    private readonly IntPtr _handle;
    private readonly bool _doNotDestroy;

    public FontSet() : this(FcFontSetCreate(), false)
    {
    }

    internal FontSet(IntPtr handle, bool doNotDestroy)
    {
        _handle = handle;
        _doNotDestroy = doNotDestroy;
    }

    /// <summary>
    /// References the specified pattern, and adds it to the font pattern set.
    /// </summary>
    /// <param name="pattern">The pattern to add. Prior to adding, <see cref="FontSearchPattern.SetMatchKind"/>
    /// and <see cref="FontSearchPattern.SetDefaultsIfAbsent"/> must be called.</param>
    /// <remarks>
    /// <para>
    /// The <c>fontconfig</c> library automatically disposes the pattern added to the unmanaged
    /// pattern set. To counter this behaviour, this <see cref="Add"/> method implementation adds an
    /// unmanaged reference to the <see cref="FontSearchPattern"/> instance.
    /// </para>
    /// <para>
    /// The disposing of the <see cref="FontSearchPattern"/> unmanaged resources is left to be dealt by the
    /// managed infrastructure.
    /// </para>
    /// </remarks>
    public void Add(FontSearchPattern pattern)
    {
        FcPatternReference(pattern.Handle);
        FcFontSetAdd(_handle, pattern.Handle);
    }

    private void ReleaseUnmanagedResources()
    {
        FcFontSetDestroy(_handle);
    }

    public void Dispose()
    {
        if (!_doNotDestroy)
        {
            ReleaseUnmanagedResources();
        }

        GC.SuppressFinalize(this);
    }

    ~FontSet()
    {
        ReleaseUnmanagedResources();
    }
}