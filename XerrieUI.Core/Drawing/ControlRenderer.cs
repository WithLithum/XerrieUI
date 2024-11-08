// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: LGPL-3.0-or-later

using XerrieUI.Core.Platform;
using XerrieUI.Drawing;
using XerrieUI.Drawing.Fonts;
using XerrieUI.Drawing.Math;
using XerrieUI.Drawing.Patterns;

namespace XerrieUI.Core.Drawing;

public abstract class ControlRenderer : IRenderer, IDisposable
{
    private string? _cachedFontName;
    private FoundFontInfo? _fontInfo;
    
    public CairoFont? CurrentFont { get; private set; }
    
    public abstract CairoContext Graphics { get; }

    public void SetFont(string fontPattern)
    {
        if (_cachedFontName == fontPattern
            && CurrentFont != null)
        {
            return;
        }
        
        var fontInfo = FontFinder.FindCached(fontPattern);
        if (fontInfo == null)
        {
            throw new InvalidOperationException($"Failed to locate font '{fontPattern}'.");
        }
        
        var face = Application.FontManager.CreateFace(fontInfo.FileName, fontInfo.Index);

        _cachedFontName = fontPattern;
        _fontInfo = fontInfo;
        CurrentFont = new FreeTypeCairoFont(face);
    }
    
    public void DrawText(CairoPattern pattern, PointD point, string text, bool correctBounds = false)
    {
        if (CurrentFont == null || _fontInfo == null)
        {
            throw new InvalidOperationException("Cannot render text if font is null.");
        }
        
        Graphics.FillText(pattern, CurrentFont, _fontInfo.Size, point, text);
    }

    public virtual void Dispose()
    {
        CurrentFont?.Dispose();
        GC.SuppressFinalize(this);
    }
}