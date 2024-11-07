// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using XerrieUI.Drawing.Interop;

namespace XerrieUI.Drawing.Fonts;

public sealed class FreeTypeCairoFont : CairoFont
{
    private readonly FontFace _fontFace;
    
    public FreeTypeCairoFont(FontFace fontFace) : base(CreateCairoFont(fontFace))
    {
        _fontFace = fontFace.Reference();
    }

    private static IntPtr CreateCairoFont(FontFace fontFace)
    {
        return LibCairo.cairo_ft_font_face_create_for_ft_face(fontFace.Handle, 0);
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);

        if (disposing)
        {
            _fontFace.Dispose();
        }
    }
}