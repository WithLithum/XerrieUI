// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Drawing;
using System.Runtime.InteropServices;
using XerrieUI.Drawing.Fonts;
using XerrieUI.Native;

namespace XerrieUI.Drawing.Interop;

internal static partial class LibCairo
{
    private const string LibName = "libcairo.so.2";

    [LibraryImport(LibName)]
    internal static partial IntPtr cairo_create(IntPtr target);
    
    [LibraryImport(LibName)]
    internal static partial void cairo_destroy(IntPtr cairoHandle);

    [LibraryImport(LibName)]
    internal static partial IntPtr cairo_reference(IntPtr cairoHandle);

    [LibraryImport(LibName)]
    internal static partial CairoStatus cairo_status(IntPtr cairoHandle);
    
    [LibraryImport(LibName)]
    internal static unsafe partial IntPtr cairo_xcb_surface_create(IntPtr connection,
        uint drawable,
        xcb_visualtype_t* visual,
        int width,
        int height);

    [LibraryImport(LibName)]
    internal static unsafe partial void cairo_surface_destroy(IntPtr surface);
    
    [LibraryImport(LibName)]
    internal static unsafe partial void cairo_surface_flush(IntPtr surface);

    [LibraryImport(LibName)]
    internal static partial void cairo_xcb_surface_set_size(IntPtr surface,
        int width,
        int height);

    [LibraryImport(LibName)]
    internal static partial void cairo_push_group(IntPtr cr);

    [LibraryImport(LibName)]
    internal static partial IntPtr cairo_pop_group(IntPtr cr);

    [LibraryImport(LibName)]
    internal static partial void cairo_pop_group_to_source(IntPtr cr);

    #region Fonts

    [LibraryImport(LibName)]
    internal static partial void cairo_set_font_face(IntPtr cairo,
        IntPtr fontFace);

    [LibraryImport(LibName, StringMarshalling = StringMarshalling.Utf8)]
    internal static partial void cairo_text_extents(IntPtr cairo,
        string utf8,
        ref TextExtents extents);
    
    [LibraryImport(LibName)]
    internal static partial void cairo_font_face_destroy(IntPtr fontFace);
    
    [LibraryImport(LibName)]
    internal static partial IntPtr cairo_ft_font_face_create_for_ft_face(IntPtr ftFace,
        int loadFlags);

    #endregion
    
    #region Drawing

    [LibraryImport(LibName)]
    internal static partial void cairo_set_line_width(IntPtr cr, double width);
    
    [LibraryImport(LibName)]
    internal static partial void cairo_set_source_rgba(IntPtr cr, double r, double g, double b, double a);
    
    [LibraryImport(LibName)]
    internal static partial void cairo_set_source(IntPtr cr, IntPtr pattern);
    
    [LibraryImport(LibName)]
    internal static partial void cairo_rectangle(IntPtr cr, double x, double y, double width, double height);
    
    [LibraryImport(LibName)]
    internal static partial void cairo_move_to(IntPtr cr, double x, double y);
    
    [LibraryImport(LibName)]
    internal static partial void cairo_stroke(IntPtr cr);

    [LibraryImport(LibName)]
    internal static partial void cairo_fill(IntPtr cr);

    #endregion
    
    #region Text Rendering
    
    [LibraryImport(LibName, StringMarshalling = StringMarshalling.Utf8)]
    internal static partial void cairo_show_text(IntPtr cr, string utf8);

    [LibraryImport(LibName)]
    internal static partial void cairo_set_font_size(IntPtr cr, double size);
    
    #endregion
    
    #region Transformation

    [LibraryImport(LibName)]
    internal static partial void cairo_scale(IntPtr cr, double sx, double sy);

    [LibraryImport(LibName)]
    internal static partial void cairo_device_to_user(IntPtr cr,
        ref double x,
        ref double y);

    [LibraryImport(LibName)]
    internal static partial void cairo_user_to_device(IntPtr cr,
        ref double x,
        ref double y);
    
    [LibraryImport(LibName)]
    internal static partial void cairo_device_to_user_distance(IntPtr cr,
        ref double x,
        ref double y);

    [LibraryImport(LibName)]
    internal static partial void cairo_user_to_device_distance(IntPtr cr,
        ref double x,
        ref double y);
    
    #endregion
    
    #region Patterns

    [LibraryImport(LibName)]
    internal static partial IntPtr cairo_pattern_create_rgba(double r, double g, double b, double a);
    
    [LibraryImport(LibName)]
    internal static partial void cairo_pattern_destroy(IntPtr pattern);

    #endregion
    
    #region Helpers

    internal static void HelperConvertColor(Color color, out double r,
        out double g,
        out double b,
        out double a)
    {
        r = Normalize(color.R);
        g = Normalize(color.G);
        b = Normalize(color.B);
        a = Normalize(color.A);
        return;

        double Normalize(byte c) => (double)c / 255;
    }
    
    #endregion
}