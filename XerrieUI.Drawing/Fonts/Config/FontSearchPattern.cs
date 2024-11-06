// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.InteropServices;
using XerrieUI.Drawing.Exceptions;
using static XerrieUI.Drawing.Interop.LibFontConfig;

namespace XerrieUI.Drawing.Fonts.Config;

public class FontSearchPattern : IDisposable, ICloneable
{
    #region Constructors
    internal FontSearchPattern(IntPtr handle)
    {
        Handle = handle;
    }

    public FontSearchPattern() : this(FcPatternCreate())
    {
    }
    #endregion
    
    internal IntPtr Handle { get; }

    private void ReleaseUnmanagedResources()
    {
        FcPatternDestroy(Handle);
    }

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }

    ~FontSearchPattern()
    {
        ReleaseUnmanagedResources();
    }

    object ICloneable.Clone() => Clone();
    
    #region Properties

    /// <summary>
    /// Adds the specified <see cref="string"/> value to the specified property of this pattern.
    /// </summary>
    /// <param name="property">The name of the property.</param>
    /// <param name="value">The value of the property.</param>
    /// <exception cref="FontConfigException">Failed to add the value.</exception>
    public void Add(string property, string value)
    {
        if (FcPatternAddString(Handle, property, value) != FcBool.True)
        {
            throw FontConfigException.CreateAddFailed();
        }
    }

    /// <summary>
    /// Adds the specified <see cref="int"/> value to the specified property of this pattern.
    /// </summary>
    /// <param name="property">The name of the property.</param>
    /// <param name="value">The value of the property.</param>
    /// <exception cref="FontConfigException">Failed to add the value.</exception>
    public void Add(string property, int value)
    {
        if (FcPatternAddInteger(Handle, property, value) != FcBool.True)
        {
            throw FontConfigException.CreateAddFailed();
        }
    }

    /// <summary>
    /// Removes all values from the specified property of this pattern.
    /// </summary>
    /// <param name="property">The property to remove.</param>
    /// <returns><see langword="true"/> if successful; otherwise, <see langword="false"/>.</returns>
    public bool Remove(string property)
    {
        return FcPatternDel(Handle, property) == FcBool.True;
    }
    
    #endregion

    /// <summary>
    /// Configures default values for certain properties that aren't specified in this
    /// pattern.
    /// </summary>
    /// <remarks>
    /// <para>
    /// <list type="bullet">
    ///     <item>If style or weight is absent, <c>Medium</c> will be set;</item>
    ///     <item>If style or slant are absent, <c>Roman</c> will be set;</item>
    ///     <item>If pixel size is absent, values computed from any specified point size (default 12), dpi (default 75) and scale (default 1) will be set.</item>
    /// </list>
    /// </para>
    /// </remarks>
    public void SetDefaultsIfAbsent()
    {
        FcDefaultSubstitute(Handle);
    }

    public void SetMatchKind(MatchKind matchKind)
    {
        FcConfigSubstitute(IntPtr.Zero, Handle, matchKind);
    }
    
    /// <summary>
    /// Creates a new instance of <see cref="FontSearchPattern"/> that matches the current instance.
    /// The returned instance and the current instance may be modified without affecting each other.
    /// </summary>
    /// <returns>A new instance of <see cref="FontSearchPattern"/> that matches the current instance.</returns>
    public FontSearchPattern Clone()
    {
        return new FontSearchPattern(FcPatternDuplicate(Handle));
    }

    /// <summary>
    /// Returns the string representation of this pattern.
    /// </summary>
    /// <returns>The string representation of this pattern.</returns>
    public override unsafe string ToString()
    {
        var strPtr = FcNameUnparse(Handle);
        var result = Marshal.PtrToStringUTF8((IntPtr)strPtr);
        Marshal.FreeHGlobal((IntPtr)strPtr);
        return result ?? "";
    }

    #region Factories

    /// <summary>
    /// Converts the specified string from the standard text format into a pattern. 
    /// </summary>
    /// <param name="str">The string pattern format.</param>
    /// <remarks>
    /// <para>
    /// The font search pattern format is in the following format:
    /// </para>
    /// <code>
    /// &lt;families&gt;-&lt;point sizes&gt;:&lt;name1&gt;=&lt;values17&gt;:&lt;name2&gt;=&lt;values2&gt;...
    /// </code>
    /// <para>See <see href="https://fontconfig.pages.freedesktop.org/fontconfig/fontconfig-user.html#font-names">this page</see> for a detailed explaination.</para>
    /// </remarks>
    /// <returns>The parsed instance.</returns>
    public static FontSearchPattern Parse(string str)
    {
        return new FontSearchPattern(FcNameParse(str));
    }
    
    /// <summary>
    /// Increments the reference count of the specified pattern and returns a new
    /// instance of <see cref="FontSearchPattern"/> representing the specified pattern.
    /// </summary>
    /// <param name="handle">The handle. It must be a pointer to <c>FcPattern</c>.</param>
    /// <returns>The created <see cref="FontSearchPattern"/> instance.</returns>
    public static FontSearchPattern Reference(IntPtr handle)
    {
        FcPatternReference(handle);
        return new FontSearchPattern(handle);
    }
    
    #endregion
}