# SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
# SPDX-License-Identifier: Apache-2.0

#!/bin/sh
ClangSharpPInvokeGenerator @generate.rsp
ClangSharpPInvokeGenerator @generate-extras.rsp

do_replace() {
  sed -i "s|$2|$3|g" $1
}

file=Xcb.cs

#do_replace $file "xcb_connection_t*" IntPtr
#do_replace $file "xcb_special_event*" IntPtr
#do_replace $file "xcb_extension_t*" IntPtr

#
#do_replace $file "SDL_Window*" IntPtr
#do_replace $file "SDL_BlitMap*" IntPtr
#do_replace $file "_XDisplay*" IntPtr
#do_replace $file "wl_display*" IntPtr
#do_replace $file "wl_egl_window*" IntPtr
#do_replace $file "xdg_surface*" IntPtr
#do_replace $file "gbm_device*" IntPtr
#do_replace $file "xdg_toplevel*" IntPtr
#do_replace $file "xdg_popup*" IntPtr
#do_replace $file "xdg_positioner*" IntPtr
#do_replace $file "wl_surface*" IntPtr
