// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;
using XerrieUI.Core.Platform;
using XerrieUI.Drawing;
using XerrieUI.Drawing.Fonts;
using XerrieUI.Drawing.Patterns;

namespace XerrieUI.Core.Drawing;

public abstract class ControlRenderer : IRenderer, IDisposable
{
    private string? _cachedFontName;
    private CairoFont? _cairoFont;
    private FoundFontInfo? _fontInfo;
    
    public abstract CairoContext Graphics { get; }

    public void SetFont(string fontPattern)
    {
        if (_cachedFontName == fontPattern
            && _cairoFont != null)
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
        _cairoFont = new FreeTypeCairoFont(face);
    }
    
    public void DrawText(CairoPattern pattern, Point point, string text)
    {
        if (_cairoFont == null || _fontInfo == null)
        {
            throw new InvalidOperationException("Cannot render text if font is null.");
        }
        
        Graphics.FillText(pattern, _cairoFont, _fontInfo.Size, point, text);
    }

    public virtual void Dispose()
    {
        _cairoFont?.Dispose();
        GC.SuppressFinalize(this);
    }
}