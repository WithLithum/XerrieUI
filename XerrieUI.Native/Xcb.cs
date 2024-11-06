// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

#pragma warning disable CA1041
#pragma warning disable SYSLIB1054

using System.Runtime.InteropServices;

namespace XerrieUI.Native
{
    public unsafe partial struct xcb_generic_iterator_t
    {
        public void* data;

        public int rem;

        public int index;
    }

    public partial struct xcb_generic_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;
    }

    public unsafe partial struct xcb_generic_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t[7]")]
        public fixed uint pad[7];

        [NativeTypeName("uint32_t")]
        public uint full_sequence;
    }

    public unsafe partial struct xcb_raw_generic_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t[7]")]
        public fixed uint pad[7];
    }

    public unsafe partial struct xcb_ge_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint16_t")]
        public ushort event_type;

        [NativeTypeName("uint16_t")]
        public ushort pad1;

        [NativeTypeName("uint32_t[5]")]
        public fixed uint pad[5];

        [NativeTypeName("uint32_t")]
        public uint full_sequence;
    }

    public unsafe partial struct xcb_generic_error_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte error_code;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint resource_id;

        [NativeTypeName("uint16_t")]
        public ushort minor_code;

        [NativeTypeName("uint8_t")]
        public byte major_code;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint32_t[5]")]
        public fixed uint pad[5];

        [NativeTypeName("uint32_t")]
        public uint full_sequence;
    }

    public partial struct xcb_void_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public unsafe partial struct xcb_auth_info_t
    {
        public int namelen;

        [NativeTypeName("char *")]
        public sbyte* name;

        public int datalen;

        [NativeTypeName("char *")]
        public sbyte* data;
    }

    public partial struct xcb_char2b_t
    {
        [NativeTypeName("uint8_t")]
        public byte byte1;

        [NativeTypeName("uint8_t")]
        public byte byte2;
    }

    public unsafe partial struct xcb_char2b_iterator_t
    {
        public xcb_char2b_t* data;

        public int rem;

        public int index;
    }

    public unsafe partial struct xcb_window_iterator_t
    {
        [NativeTypeName("xcb_window_t *")]
        public uint* data;

        public int rem;

        public int index;
    }

    public unsafe partial struct xcb_pixmap_iterator_t
    {
        [NativeTypeName("xcb_pixmap_t *")]
        public uint* data;

        public int rem;

        public int index;
    }

    public unsafe partial struct xcb_cursor_iterator_t
    {
        [NativeTypeName("xcb_cursor_t *")]
        public uint* data;

        public int rem;

        public int index;
    }

    public unsafe partial struct xcb_font_iterator_t
    {
        [NativeTypeName("xcb_font_t *")]
        public uint* data;

        public int rem;

        public int index;
    }

    public unsafe partial struct xcb_gcontext_iterator_t
    {
        [NativeTypeName("xcb_gcontext_t *")]
        public uint* data;

        public int rem;

        public int index;
    }

    public unsafe partial struct xcb_colormap_iterator_t
    {
        [NativeTypeName("xcb_colormap_t *")]
        public uint* data;

        public int rem;

        public int index;
    }

    public unsafe partial struct xcb_atom_iterator_t
    {
        [NativeTypeName("xcb_atom_t *")]
        public uint* data;

        public int rem;

        public int index;
    }

    public unsafe partial struct xcb_drawable_iterator_t
    {
        [NativeTypeName("xcb_drawable_t *")]
        public uint* data;

        public int rem;

        public int index;
    }

    public unsafe partial struct xcb_fontable_iterator_t
    {
        [NativeTypeName("xcb_fontable_t *")]
        public uint* data;

        public int rem;

        public int index;
    }

    public unsafe partial struct xcb_bool32_iterator_t
    {
        [NativeTypeName("xcb_bool32_t *")]
        public uint* data;

        public int rem;

        public int index;
    }

    public unsafe partial struct xcb_visualid_iterator_t
    {
        [NativeTypeName("xcb_visualid_t *")]
        public uint* data;

        public int rem;

        public int index;
    }

    public unsafe partial struct xcb_timestamp_iterator_t
    {
        [NativeTypeName("xcb_timestamp_t *")]
        public uint* data;

        public int rem;

        public int index;
    }

    public unsafe partial struct xcb_keysym_iterator_t
    {
        [NativeTypeName("xcb_keysym_t *")]
        public uint* data;

        public int rem;

        public int index;
    }

    public unsafe partial struct xcb_keycode_iterator_t
    {
        [NativeTypeName("xcb_keycode_t *")]
        public byte* data;

        public int rem;

        public int index;
    }

    public unsafe partial struct xcb_keycode32_iterator_t
    {
        [NativeTypeName("xcb_keycode32_t *")]
        public uint* data;

        public int rem;

        public int index;
    }

    public unsafe partial struct xcb_button_iterator_t
    {
        [NativeTypeName("xcb_button_t *")]
        public byte* data;

        public int rem;

        public int index;
    }

    public partial struct xcb_point_t
    {
        [NativeTypeName("int16_t")]
        public short x;

        [NativeTypeName("int16_t")]
        public short y;
    }

    public unsafe partial struct xcb_point_iterator_t
    {
        public xcb_point_t* data;

        public int rem;

        public int index;
    }

    public partial struct xcb_rectangle_t
    {
        [NativeTypeName("int16_t")]
        public short x;

        [NativeTypeName("int16_t")]
        public short y;

        [NativeTypeName("uint16_t")]
        public ushort width;

        [NativeTypeName("uint16_t")]
        public ushort height;
    }

    public unsafe partial struct xcb_rectangle_iterator_t
    {
        public xcb_rectangle_t* data;

        public int rem;

        public int index;
    }

    public partial struct xcb_arc_t
    {
        [NativeTypeName("int16_t")]
        public short x;

        [NativeTypeName("int16_t")]
        public short y;

        [NativeTypeName("uint16_t")]
        public ushort width;

        [NativeTypeName("uint16_t")]
        public ushort height;

        [NativeTypeName("int16_t")]
        public short angle1;

        [NativeTypeName("int16_t")]
        public short angle2;
    }

    public unsafe partial struct xcb_arc_iterator_t
    {
        public xcb_arc_t* data;

        public int rem;

        public int index;
    }

    public unsafe partial struct xcb_format_t
    {
        [NativeTypeName("uint8_t")]
        public byte depth;

        [NativeTypeName("uint8_t")]
        public byte bits_per_pixel;

        [NativeTypeName("uint8_t")]
        public byte scanline_pad;

        [NativeTypeName("uint8_t[5]")]
        public fixed byte pad0[5];
    }

    public unsafe partial struct xcb_format_iterator_t
    {
        public xcb_format_t* data;

        public int rem;

        public int index;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_visual_class_t : uint
    {
        XCB_VISUAL_CLASS_STATIC_GRAY = 0,
        XCB_VISUAL_CLASS_GRAY_SCALE = 1,
        XCB_VISUAL_CLASS_STATIC_COLOR = 2,
        XCB_VISUAL_CLASS_PSEUDO_COLOR = 3,
        XCB_VISUAL_CLASS_TRUE_COLOR = 4,
        XCB_VISUAL_CLASS_DIRECT_COLOR = 5,
    }

    public unsafe partial struct xcb_visualtype_t
    {
        [NativeTypeName("xcb_visualid_t")]
        public uint visual_id;

        [NativeTypeName("uint8_t")]
        public byte _class;

        [NativeTypeName("uint8_t")]
        public byte bits_per_rgb_value;

        [NativeTypeName("uint16_t")]
        public ushort colormap_entries;

        [NativeTypeName("uint32_t")]
        public uint red_mask;

        [NativeTypeName("uint32_t")]
        public uint green_mask;

        [NativeTypeName("uint32_t")]
        public uint blue_mask;

        [NativeTypeName("uint8_t[4]")]
        public fixed byte pad0[4];
    }

    public unsafe partial struct xcb_visualtype_iterator_t
    {
        public xcb_visualtype_t* data;

        public int rem;

        public int index;
    }

    public unsafe partial struct xcb_depth_t
    {
        [NativeTypeName("uint8_t")]
        public byte depth;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort visuals_len;

        [NativeTypeName("uint8_t[4]")]
        public fixed byte pad1[4];
    }

    public unsafe partial struct xcb_depth_iterator_t
    {
        public xcb_depth_t* data;

        public int rem;

        public int index;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_event_mask_t : uint
    {
        XCB_EVENT_MASK_NO_EVENT = 0,
        XCB_EVENT_MASK_KEY_PRESS = 1,
        XCB_EVENT_MASK_KEY_RELEASE = 2,
        XCB_EVENT_MASK_BUTTON_PRESS = 4,
        XCB_EVENT_MASK_BUTTON_RELEASE = 8,
        XCB_EVENT_MASK_ENTER_WINDOW = 16,
        XCB_EVENT_MASK_LEAVE_WINDOW = 32,
        XCB_EVENT_MASK_POINTER_MOTION = 64,
        XCB_EVENT_MASK_POINTER_MOTION_HINT = 128,
        XCB_EVENT_MASK_BUTTON_1_MOTION = 256,
        XCB_EVENT_MASK_BUTTON_2_MOTION = 512,
        XCB_EVENT_MASK_BUTTON_3_MOTION = 1024,
        XCB_EVENT_MASK_BUTTON_4_MOTION = 2048,
        XCB_EVENT_MASK_BUTTON_5_MOTION = 4096,
        XCB_EVENT_MASK_BUTTON_MOTION = 8192,
        XCB_EVENT_MASK_KEYMAP_STATE = 16384,
        XCB_EVENT_MASK_EXPOSURE = 32768,
        XCB_EVENT_MASK_VISIBILITY_CHANGE = 65536,
        XCB_EVENT_MASK_STRUCTURE_NOTIFY = 131072,
        XCB_EVENT_MASK_RESIZE_REDIRECT = 262144,
        XCB_EVENT_MASK_SUBSTRUCTURE_NOTIFY = 524288,
        XCB_EVENT_MASK_SUBSTRUCTURE_REDIRECT = 1048576,
        XCB_EVENT_MASK_FOCUS_CHANGE = 2097152,
        XCB_EVENT_MASK_PROPERTY_CHANGE = 4194304,
        XCB_EVENT_MASK_COLOR_MAP_CHANGE = 8388608,
        XCB_EVENT_MASK_OWNER_GRAB_BUTTON = 16777216,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_backing_store_t : uint
    {
        XCB_BACKING_STORE_NOT_USEFUL = 0,
        XCB_BACKING_STORE_WHEN_MAPPED = 1,
        XCB_BACKING_STORE_ALWAYS = 2,
    }

    public partial struct xcb_screen_t
    {
        [NativeTypeName("xcb_window_t")]
        public uint root;

        [NativeTypeName("xcb_colormap_t")]
        public uint default_colormap;

        [NativeTypeName("uint32_t")]
        public uint white_pixel;

        [NativeTypeName("uint32_t")]
        public uint black_pixel;

        [NativeTypeName("uint32_t")]
        public uint current_input_masks;

        [NativeTypeName("uint16_t")]
        public ushort width_in_pixels;

        [NativeTypeName("uint16_t")]
        public ushort height_in_pixels;

        [NativeTypeName("uint16_t")]
        public ushort width_in_millimeters;

        [NativeTypeName("uint16_t")]
        public ushort height_in_millimeters;

        [NativeTypeName("uint16_t")]
        public ushort min_installed_maps;

        [NativeTypeName("uint16_t")]
        public ushort max_installed_maps;

        [NativeTypeName("xcb_visualid_t")]
        public uint root_visual;

        [NativeTypeName("uint8_t")]
        public byte backing_stores;

        [NativeTypeName("uint8_t")]
        public byte save_unders;

        [NativeTypeName("uint8_t")]
        public byte root_depth;

        [NativeTypeName("uint8_t")]
        public byte allowed_depths_len;
    }

    public unsafe partial struct xcb_screen_iterator_t
    {
        public xcb_screen_t* data;

        public int rem;

        public int index;
    }

    public unsafe partial struct xcb_setup_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte byte_order;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort protocol_major_version;

        [NativeTypeName("uint16_t")]
        public ushort protocol_minor_version;

        [NativeTypeName("uint16_t")]
        public ushort authorization_protocol_name_len;

        [NativeTypeName("uint16_t")]
        public ushort authorization_protocol_data_len;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad1[2];
    }

    public unsafe partial struct xcb_setup_request_iterator_t
    {
        public xcb_setup_request_t* data;

        public int rem;

        public int index;
    }

    public partial struct xcb_setup_failed_t
    {
        [NativeTypeName("uint8_t")]
        public byte status;

        [NativeTypeName("uint8_t")]
        public byte reason_len;

        [NativeTypeName("uint16_t")]
        public ushort protocol_major_version;

        [NativeTypeName("uint16_t")]
        public ushort protocol_minor_version;

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    public unsafe partial struct xcb_setup_failed_iterator_t
    {
        public xcb_setup_failed_t* data;

        public int rem;

        public int index;
    }

    public unsafe partial struct xcb_setup_authenticate_t
    {
        [NativeTypeName("uint8_t")]
        public byte status;

        [NativeTypeName("uint8_t[5]")]
        public fixed byte pad0[5];

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    public unsafe partial struct xcb_setup_authenticate_iterator_t
    {
        public xcb_setup_authenticate_t* data;

        public int rem;

        public int index;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_image_order_t : uint
    {
        XCB_IMAGE_ORDER_LSB_FIRST = 0,
        XCB_IMAGE_ORDER_MSB_FIRST = 1,
    }

    public unsafe partial struct xcb_setup_t
    {
        [NativeTypeName("uint8_t")]
        public byte status;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort protocol_major_version;

        [NativeTypeName("uint16_t")]
        public ushort protocol_minor_version;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("uint32_t")]
        public uint release_number;

        [NativeTypeName("uint32_t")]
        public uint resource_id_base;

        [NativeTypeName("uint32_t")]
        public uint resource_id_mask;

        [NativeTypeName("uint32_t")]
        public uint motion_buffer_size;

        [NativeTypeName("uint16_t")]
        public ushort vendor_len;

        [NativeTypeName("uint16_t")]
        public ushort maximum_request_length;

        [NativeTypeName("uint8_t")]
        public byte roots_len;

        [NativeTypeName("uint8_t")]
        public byte pixmap_formats_len;

        [NativeTypeName("uint8_t")]
        public byte image_byte_order;

        [NativeTypeName("uint8_t")]
        public byte bitmap_format_bit_order;

        [NativeTypeName("uint8_t")]
        public byte bitmap_format_scanline_unit;

        [NativeTypeName("uint8_t")]
        public byte bitmap_format_scanline_pad;

        [NativeTypeName("xcb_keycode_t")]
        public byte min_keycode;

        [NativeTypeName("xcb_keycode_t")]
        public byte max_keycode;

        [NativeTypeName("uint8_t[4]")]
        public fixed byte pad1[4];
    }

    public unsafe partial struct xcb_setup_iterator_t
    {
        public xcb_setup_t* data;

        public int rem;

        public int index;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_mod_mask_t : uint
    {
        XCB_MOD_MASK_SHIFT = 1,
        XCB_MOD_MASK_LOCK = 2,
        XCB_MOD_MASK_CONTROL = 4,
        XCB_MOD_MASK_1 = 8,
        XCB_MOD_MASK_2 = 16,
        XCB_MOD_MASK_3 = 32,
        XCB_MOD_MASK_4 = 64,
        XCB_MOD_MASK_5 = 128,
        XCB_MOD_MASK_ANY = 32768,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_key_but_mask_t : uint
    {
        XCB_KEY_BUT_MASK_SHIFT = 1,
        XCB_KEY_BUT_MASK_LOCK = 2,
        XCB_KEY_BUT_MASK_CONTROL = 4,
        XCB_KEY_BUT_MASK_MOD_1 = 8,
        XCB_KEY_BUT_MASK_MOD_2 = 16,
        XCB_KEY_BUT_MASK_MOD_3 = 32,
        XCB_KEY_BUT_MASK_MOD_4 = 64,
        XCB_KEY_BUT_MASK_MOD_5 = 128,
        XCB_KEY_BUT_MASK_BUTTON_1 = 256,
        XCB_KEY_BUT_MASK_BUTTON_2 = 512,
        XCB_KEY_BUT_MASK_BUTTON_3 = 1024,
        XCB_KEY_BUT_MASK_BUTTON_4 = 2048,
        XCB_KEY_BUT_MASK_BUTTON_5 = 4096,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_window_enum_t : uint
    {
        XCB_WINDOW_NONE = 0,
    }

    public partial struct xcb_key_press_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("xcb_keycode_t")]
        public byte detail;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_timestamp_t")]
        public uint time;

        [NativeTypeName("xcb_window_t")]
        public uint root;

        [NativeTypeName("xcb_window_t")]
        public uint @event;

        [NativeTypeName("xcb_window_t")]
        public uint child;

        [NativeTypeName("int16_t")]
        public short root_x;

        [NativeTypeName("int16_t")]
        public short root_y;

        [NativeTypeName("int16_t")]
        public short event_x;

        [NativeTypeName("int16_t")]
        public short event_y;

        [NativeTypeName("uint16_t")]
        public ushort state;

        [NativeTypeName("uint8_t")]
        public byte same_screen;

        [NativeTypeName("uint8_t")]
        public byte pad0;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_button_mask_t : uint
    {
        XCB_BUTTON_MASK_1 = 256,
        XCB_BUTTON_MASK_2 = 512,
        XCB_BUTTON_MASK_3 = 1024,
        XCB_BUTTON_MASK_4 = 2048,
        XCB_BUTTON_MASK_5 = 4096,
        XCB_BUTTON_MASK_ANY = 32768,
    }

    public partial struct xcb_button_press_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("xcb_button_t")]
        public byte detail;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_timestamp_t")]
        public uint time;

        [NativeTypeName("xcb_window_t")]
        public uint root;

        [NativeTypeName("xcb_window_t")]
        public uint @event;

        [NativeTypeName("xcb_window_t")]
        public uint child;

        [NativeTypeName("int16_t")]
        public short root_x;

        [NativeTypeName("int16_t")]
        public short root_y;

        [NativeTypeName("int16_t")]
        public short event_x;

        [NativeTypeName("int16_t")]
        public short event_y;

        [NativeTypeName("uint16_t")]
        public ushort state;

        [NativeTypeName("uint8_t")]
        public byte same_screen;

        [NativeTypeName("uint8_t")]
        public byte pad0;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_motion_t : uint
    {
        XCB_MOTION_NORMAL = 0,
        XCB_MOTION_HINT = 1,
    }

    public partial struct xcb_motion_notify_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte detail;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_timestamp_t")]
        public uint time;

        [NativeTypeName("xcb_window_t")]
        public uint root;

        [NativeTypeName("xcb_window_t")]
        public uint @event;

        [NativeTypeName("xcb_window_t")]
        public uint child;

        [NativeTypeName("int16_t")]
        public short root_x;

        [NativeTypeName("int16_t")]
        public short root_y;

        [NativeTypeName("int16_t")]
        public short event_x;

        [NativeTypeName("int16_t")]
        public short event_y;

        [NativeTypeName("uint16_t")]
        public ushort state;

        [NativeTypeName("uint8_t")]
        public byte same_screen;

        [NativeTypeName("uint8_t")]
        public byte pad0;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_notify_detail_t : uint
    {
        XCB_NOTIFY_DETAIL_ANCESTOR = 0,
        XCB_NOTIFY_DETAIL_VIRTUAL = 1,
        XCB_NOTIFY_DETAIL_INFERIOR = 2,
        XCB_NOTIFY_DETAIL_NONLINEAR = 3,
        XCB_NOTIFY_DETAIL_NONLINEAR_VIRTUAL = 4,
        XCB_NOTIFY_DETAIL_POINTER = 5,
        XCB_NOTIFY_DETAIL_POINTER_ROOT = 6,
        XCB_NOTIFY_DETAIL_NONE = 7,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_notify_mode_t : uint
    {
        XCB_NOTIFY_MODE_NORMAL = 0,
        XCB_NOTIFY_MODE_GRAB = 1,
        XCB_NOTIFY_MODE_UNGRAB = 2,
        XCB_NOTIFY_MODE_WHILE_GRABBED = 3,
    }

    public partial struct xcb_enter_notify_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte detail;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_timestamp_t")]
        public uint time;

        [NativeTypeName("xcb_window_t")]
        public uint root;

        [NativeTypeName("xcb_window_t")]
        public uint @event;

        [NativeTypeName("xcb_window_t")]
        public uint child;

        [NativeTypeName("int16_t")]
        public short root_x;

        [NativeTypeName("int16_t")]
        public short root_y;

        [NativeTypeName("int16_t")]
        public short event_x;

        [NativeTypeName("int16_t")]
        public short event_y;

        [NativeTypeName("uint16_t")]
        public ushort state;

        [NativeTypeName("uint8_t")]
        public byte mode;

        [NativeTypeName("uint8_t")]
        public byte same_screen_focus;
    }

    public unsafe partial struct xcb_focus_in_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte detail;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_window_t")]
        public uint @event;

        [NativeTypeName("uint8_t")]
        public byte mode;

        [NativeTypeName("uint8_t[3]")]
        public fixed byte pad0[3];
    }

    public unsafe partial struct xcb_keymap_notify_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t[31]")]
        public fixed byte keys[31];
    }

    public unsafe partial struct xcb_expose_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("uint16_t")]
        public ushort x;

        [NativeTypeName("uint16_t")]
        public ushort y;

        [NativeTypeName("uint16_t")]
        public ushort width;

        [NativeTypeName("uint16_t")]
        public ushort height;

        [NativeTypeName("uint16_t")]
        public ushort count;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad1[2];
    }

    public unsafe partial struct xcb_graphics_exposure_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_drawable_t")]
        public uint drawable;

        [NativeTypeName("uint16_t")]
        public ushort x;

        [NativeTypeName("uint16_t")]
        public ushort y;

        [NativeTypeName("uint16_t")]
        public ushort width;

        [NativeTypeName("uint16_t")]
        public ushort height;

        [NativeTypeName("uint16_t")]
        public ushort minor_opcode;

        [NativeTypeName("uint16_t")]
        public ushort count;

        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t[3]")]
        public fixed byte pad1[3];
    }

    public partial struct xcb_no_exposure_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_drawable_t")]
        public uint drawable;

        [NativeTypeName("uint16_t")]
        public ushort minor_opcode;

        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad1;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_visibility_t : uint
    {
        XCB_VISIBILITY_UNOBSCURED = 0,
        XCB_VISIBILITY_PARTIALLY_OBSCURED = 1,
        XCB_VISIBILITY_FULLY_OBSCURED = 2,
    }

    public unsafe partial struct xcb_visibility_notify_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("uint8_t")]
        public byte state;

        [NativeTypeName("uint8_t[3]")]
        public fixed byte pad1[3];
    }

    public partial struct xcb_create_notify_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_window_t")]
        public uint parent;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("int16_t")]
        public short x;

        [NativeTypeName("int16_t")]
        public short y;

        [NativeTypeName("uint16_t")]
        public ushort width;

        [NativeTypeName("uint16_t")]
        public ushort height;

        [NativeTypeName("uint16_t")]
        public ushort border_width;

        [NativeTypeName("uint8_t")]
        public byte override_redirect;

        [NativeTypeName("uint8_t")]
        public byte pad1;
    }

    public partial struct xcb_destroy_notify_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_window_t")]
        public uint @event;

        [NativeTypeName("xcb_window_t")]
        public uint window;
    }

    public unsafe partial struct xcb_unmap_notify_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_window_t")]
        public uint @event;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("uint8_t")]
        public byte from_configure;

        [NativeTypeName("uint8_t[3]")]
        public fixed byte pad1[3];
    }

    public unsafe partial struct xcb_map_notify_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_window_t")]
        public uint @event;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("uint8_t")]
        public byte override_redirect;

        [NativeTypeName("uint8_t[3]")]
        public fixed byte pad1[3];
    }

    public partial struct xcb_map_request_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_window_t")]
        public uint parent;

        [NativeTypeName("xcb_window_t")]
        public uint window;
    }

    public unsafe partial struct xcb_reparent_notify_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_window_t")]
        public uint @event;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("xcb_window_t")]
        public uint parent;

        [NativeTypeName("int16_t")]
        public short x;

        [NativeTypeName("int16_t")]
        public short y;

        [NativeTypeName("uint8_t")]
        public byte override_redirect;

        [NativeTypeName("uint8_t[3]")]
        public fixed byte pad1[3];
    }

    public partial struct xcb_configure_notify_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_window_t")]
        public uint @event;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("xcb_window_t")]
        public uint above_sibling;

        [NativeTypeName("int16_t")]
        public short x;

        [NativeTypeName("int16_t")]
        public short y;

        [NativeTypeName("uint16_t")]
        public ushort width;

        [NativeTypeName("uint16_t")]
        public ushort height;

        [NativeTypeName("uint16_t")]
        public ushort border_width;

        [NativeTypeName("uint8_t")]
        public byte override_redirect;

        [NativeTypeName("uint8_t")]
        public byte pad1;
    }

    public partial struct xcb_configure_request_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte stack_mode;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_window_t")]
        public uint parent;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("xcb_window_t")]
        public uint sibling;

        [NativeTypeName("int16_t")]
        public short x;

        [NativeTypeName("int16_t")]
        public short y;

        [NativeTypeName("uint16_t")]
        public ushort width;

        [NativeTypeName("uint16_t")]
        public ushort height;

        [NativeTypeName("uint16_t")]
        public ushort border_width;

        [NativeTypeName("uint16_t")]
        public ushort value_mask;
    }

    public partial struct xcb_gravity_notify_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_window_t")]
        public uint @event;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("int16_t")]
        public short x;

        [NativeTypeName("int16_t")]
        public short y;
    }

    public partial struct xcb_resize_request_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("uint16_t")]
        public ushort width;

        [NativeTypeName("uint16_t")]
        public ushort height;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_place_t : uint
    {
        XCB_PLACE_ON_TOP = 0,
        XCB_PLACE_ON_BOTTOM = 1,
    }

    public unsafe partial struct xcb_circulate_notify_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_window_t")]
        public uint @event;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("uint8_t[4]")]
        public fixed byte pad1[4];

        [NativeTypeName("uint8_t")]
        public byte place;

        [NativeTypeName("uint8_t[3]")]
        public fixed byte pad2[3];
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_property_t : uint
    {
        XCB_PROPERTY_NEW_VALUE = 0,
        XCB_PROPERTY_DELETE = 1,
    }

    public unsafe partial struct xcb_property_notify_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("xcb_atom_t")]
        public uint atom;

        [NativeTypeName("xcb_timestamp_t")]
        public uint time;

        [NativeTypeName("uint8_t")]
        public byte state;

        [NativeTypeName("uint8_t[3]")]
        public fixed byte pad1[3];
    }

    public partial struct xcb_selection_clear_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_timestamp_t")]
        public uint time;

        [NativeTypeName("xcb_window_t")]
        public uint owner;

        [NativeTypeName("xcb_atom_t")]
        public uint selection;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_time_t : uint
    {
        XCB_TIME_CURRENT_TIME = 0,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_atom_enum_t : uint
    {
        XCB_ATOM_NONE = 0,
        XCB_ATOM_ANY = 0,
        XCB_ATOM_PRIMARY = 1,
        XCB_ATOM_SECONDARY = 2,
        XCB_ATOM_ARC = 3,
        XCB_ATOM_ATOM = 4,
        XCB_ATOM_BITMAP = 5,
        XCB_ATOM_CARDINAL = 6,
        XCB_ATOM_COLORMAP = 7,
        XCB_ATOM_CURSOR = 8,
        XCB_ATOM_CUT_BUFFER0 = 9,
        XCB_ATOM_CUT_BUFFER1 = 10,
        XCB_ATOM_CUT_BUFFER2 = 11,
        XCB_ATOM_CUT_BUFFER3 = 12,
        XCB_ATOM_CUT_BUFFER4 = 13,
        XCB_ATOM_CUT_BUFFER5 = 14,
        XCB_ATOM_CUT_BUFFER6 = 15,
        XCB_ATOM_CUT_BUFFER7 = 16,
        XCB_ATOM_DRAWABLE = 17,
        XCB_ATOM_FONT = 18,
        XCB_ATOM_INTEGER = 19,
        XCB_ATOM_PIXMAP = 20,
        XCB_ATOM_POINT = 21,
        XCB_ATOM_RECTANGLE = 22,
        XCB_ATOM_RESOURCE_MANAGER = 23,
        XCB_ATOM_RGB_COLOR_MAP = 24,
        XCB_ATOM_RGB_BEST_MAP = 25,
        XCB_ATOM_RGB_BLUE_MAP = 26,
        XCB_ATOM_RGB_DEFAULT_MAP = 27,
        XCB_ATOM_RGB_GRAY_MAP = 28,
        XCB_ATOM_RGB_GREEN_MAP = 29,
        XCB_ATOM_RGB_RED_MAP = 30,
        XCB_ATOM_STRING = 31,
        XCB_ATOM_VISUALID = 32,
        XCB_ATOM_WINDOW = 33,
        XCB_ATOM_WM_COMMAND = 34,
        XCB_ATOM_WM_HINTS = 35,
        XCB_ATOM_WM_CLIENT_MACHINE = 36,
        XCB_ATOM_WM_ICON_NAME = 37,
        XCB_ATOM_WM_ICON_SIZE = 38,
        XCB_ATOM_WM_NAME = 39,
        XCB_ATOM_WM_NORMAL_HINTS = 40,
        XCB_ATOM_WM_SIZE_HINTS = 41,
        XCB_ATOM_WM_ZOOM_HINTS = 42,
        XCB_ATOM_MIN_SPACE = 43,
        XCB_ATOM_NORM_SPACE = 44,
        XCB_ATOM_MAX_SPACE = 45,
        XCB_ATOM_END_SPACE = 46,
        XCB_ATOM_SUPERSCRIPT_X = 47,
        XCB_ATOM_SUPERSCRIPT_Y = 48,
        XCB_ATOM_SUBSCRIPT_X = 49,
        XCB_ATOM_SUBSCRIPT_Y = 50,
        XCB_ATOM_UNDERLINE_POSITION = 51,
        XCB_ATOM_UNDERLINE_THICKNESS = 52,
        XCB_ATOM_STRIKEOUT_ASCENT = 53,
        XCB_ATOM_STRIKEOUT_DESCENT = 54,
        XCB_ATOM_ITALIC_ANGLE = 55,
        XCB_ATOM_X_HEIGHT = 56,
        XCB_ATOM_QUAD_WIDTH = 57,
        XCB_ATOM_WEIGHT = 58,
        XCB_ATOM_POINT_SIZE = 59,
        XCB_ATOM_RESOLUTION = 60,
        XCB_ATOM_COPYRIGHT = 61,
        XCB_ATOM_NOTICE = 62,
        XCB_ATOM_FONT_NAME = 63,
        XCB_ATOM_FAMILY_NAME = 64,
        XCB_ATOM_FULL_NAME = 65,
        XCB_ATOM_CAP_HEIGHT = 66,
        XCB_ATOM_WM_CLASS = 67,
        XCB_ATOM_WM_TRANSIENT_FOR = 68,
    }

    public partial struct xcb_selection_request_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_timestamp_t")]
        public uint time;

        [NativeTypeName("xcb_window_t")]
        public uint owner;

        [NativeTypeName("xcb_window_t")]
        public uint requestor;

        [NativeTypeName("xcb_atom_t")]
        public uint selection;

        [NativeTypeName("xcb_atom_t")]
        public uint target;

        [NativeTypeName("xcb_atom_t")]
        public uint property;
    }

    public partial struct xcb_selection_notify_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_timestamp_t")]
        public uint time;

        [NativeTypeName("xcb_window_t")]
        public uint requestor;

        [NativeTypeName("xcb_atom_t")]
        public uint selection;

        [NativeTypeName("xcb_atom_t")]
        public uint target;

        [NativeTypeName("xcb_atom_t")]
        public uint property;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_colormap_state_t : uint
    {
        XCB_COLORMAP_STATE_UNINSTALLED = 0,
        XCB_COLORMAP_STATE_INSTALLED = 1,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_colormap_enum_t : uint
    {
        XCB_COLORMAP_NONE = 0,
    }

    public unsafe partial struct xcb_colormap_notify_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("xcb_colormap_t")]
        public uint colormap;

        [NativeTypeName("uint8_t")]
        public byte _new;

        [NativeTypeName("uint8_t")]
        public byte state;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad1[2];
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct xcb_client_message_data_t
    {
        [FieldOffset(0)]
        [NativeTypeName("uint8_t[20]")]
        public fixed byte data8[20];

        [FieldOffset(0)]
        [NativeTypeName("uint16_t[10]")]
        public fixed ushort data16[10];

        [FieldOffset(0)]
        [NativeTypeName("uint32_t[5]")]
        public fixed uint data32[5];
    }

    public unsafe partial struct xcb_client_message_data_iterator_t
    {
        public xcb_client_message_data_t* data;

        public int rem;

        public int index;
    }

    public partial struct xcb_client_message_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte format;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("xcb_atom_t")]
        public uint type;

        public xcb_client_message_data_t data;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_mapping_t : uint
    {
        XCB_MAPPING_MODIFIER = 0,
        XCB_MAPPING_KEYBOARD = 1,
        XCB_MAPPING_POINTER = 2,
    }

    public partial struct xcb_mapping_notify_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint8_t")]
        public byte request;

        [NativeTypeName("xcb_keycode_t")]
        public byte first_keycode;

        [NativeTypeName("uint8_t")]
        public byte count;

        [NativeTypeName("uint8_t")]
        public byte pad1;
    }

    public unsafe partial struct xcb_ge_generic_event_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte extension;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint16_t")]
        public ushort event_type;

        [NativeTypeName("uint8_t[22]")]
        public fixed byte pad0[22];

        [NativeTypeName("uint32_t")]
        public uint full_sequence;
    }

    public partial struct xcb_request_error_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte error_code;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint bad_value;

        [NativeTypeName("uint16_t")]
        public ushort minor_opcode;

        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;
    }

    public partial struct xcb_value_error_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte error_code;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint bad_value;

        [NativeTypeName("uint16_t")]
        public ushort minor_opcode;

        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_window_class_t : uint
    {
        XCB_WINDOW_CLASS_COPY_FROM_PARENT = 0,
        XCB_WINDOW_CLASS_INPUT_OUTPUT = 1,
        XCB_WINDOW_CLASS_INPUT_ONLY = 2,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_cw_t : uint
    {
        XCB_CW_BACK_PIXMAP = 1,
        XCB_CW_BACK_PIXEL = 2,
        XCB_CW_BORDER_PIXMAP = 4,
        XCB_CW_BORDER_PIXEL = 8,
        XCB_CW_BIT_GRAVITY = 16,
        XCB_CW_WIN_GRAVITY = 32,
        XCB_CW_BACKING_STORE = 64,
        XCB_CW_BACKING_PLANES = 128,
        XCB_CW_BACKING_PIXEL = 256,
        XCB_CW_OVERRIDE_REDIRECT = 512,
        XCB_CW_SAVE_UNDER = 1024,
        XCB_CW_EVENT_MASK = 2048,
        XCB_CW_DONT_PROPAGATE = 4096,
        XCB_CW_COLORMAP = 8192,
        XCB_CW_CURSOR = 16384,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_back_pixmap_t : uint
    {
        XCB_BACK_PIXMAP_NONE = 0,
        XCB_BACK_PIXMAP_PARENT_RELATIVE = 1,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_gravity_t : uint
    {
        XCB_GRAVITY_BIT_FORGET = 0,
        XCB_GRAVITY_WIN_UNMAP = 0,
        XCB_GRAVITY_NORTH_WEST = 1,
        XCB_GRAVITY_NORTH = 2,
        XCB_GRAVITY_NORTH_EAST = 3,
        XCB_GRAVITY_WEST = 4,
        XCB_GRAVITY_CENTER = 5,
        XCB_GRAVITY_EAST = 6,
        XCB_GRAVITY_SOUTH_WEST = 7,
        XCB_GRAVITY_SOUTH = 8,
        XCB_GRAVITY_SOUTH_EAST = 9,
        XCB_GRAVITY_STATIC = 10,
    }

    public partial struct xcb_create_window_value_list_t
    {
        [NativeTypeName("xcb_pixmap_t")]
        public uint background_pixmap;

        [NativeTypeName("uint32_t")]
        public uint background_pixel;

        [NativeTypeName("xcb_pixmap_t")]
        public uint border_pixmap;

        [NativeTypeName("uint32_t")]
        public uint border_pixel;

        [NativeTypeName("uint32_t")]
        public uint bit_gravity;

        [NativeTypeName("uint32_t")]
        public uint win_gravity;

        [NativeTypeName("uint32_t")]
        public uint backing_store;

        [NativeTypeName("uint32_t")]
        public uint backing_planes;

        [NativeTypeName("uint32_t")]
        public uint backing_pixel;

        [NativeTypeName("xcb_bool32_t")]
        public uint override_redirect;

        [NativeTypeName("xcb_bool32_t")]
        public uint save_under;

        [NativeTypeName("uint32_t")]
        public uint event_mask;

        [NativeTypeName("uint32_t")]
        public uint do_not_propogate_mask;

        [NativeTypeName("xcb_colormap_t")]
        public uint colormap;

        [NativeTypeName("xcb_cursor_t")]
        public uint cursor;
    }

    public partial struct xcb_create_window_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte depth;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint wid;

        [NativeTypeName("xcb_window_t")]
        public uint parent;

        [NativeTypeName("int16_t")]
        public short x;

        [NativeTypeName("int16_t")]
        public short y;

        [NativeTypeName("uint16_t")]
        public ushort width;

        [NativeTypeName("uint16_t")]
        public ushort height;

        [NativeTypeName("uint16_t")]
        public ushort border_width;

        [NativeTypeName("uint16_t")]
        public ushort _class;

        [NativeTypeName("xcb_visualid_t")]
        public uint visual;

        [NativeTypeName("uint32_t")]
        public uint value_mask;
    }

    public partial struct xcb_change_window_attributes_value_list_t
    {
        [NativeTypeName("xcb_pixmap_t")]
        public uint background_pixmap;

        [NativeTypeName("uint32_t")]
        public uint background_pixel;

        [NativeTypeName("xcb_pixmap_t")]
        public uint border_pixmap;

        [NativeTypeName("uint32_t")]
        public uint border_pixel;

        [NativeTypeName("uint32_t")]
        public uint bit_gravity;

        [NativeTypeName("uint32_t")]
        public uint win_gravity;

        [NativeTypeName("uint32_t")]
        public uint backing_store;

        [NativeTypeName("uint32_t")]
        public uint backing_planes;

        [NativeTypeName("uint32_t")]
        public uint backing_pixel;

        [NativeTypeName("xcb_bool32_t")]
        public uint override_redirect;

        [NativeTypeName("xcb_bool32_t")]
        public uint save_under;

        [NativeTypeName("uint32_t")]
        public uint event_mask;

        [NativeTypeName("uint32_t")]
        public uint do_not_propogate_mask;

        [NativeTypeName("xcb_colormap_t")]
        public uint colormap;

        [NativeTypeName("xcb_cursor_t")]
        public uint cursor;
    }

    public partial struct xcb_change_window_attributes_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("uint32_t")]
        public uint value_mask;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_map_state_t : uint
    {
        XCB_MAP_STATE_UNMAPPED = 0,
        XCB_MAP_STATE_UNVIEWABLE = 1,
        XCB_MAP_STATE_VIEWABLE = 2,
    }

    public partial struct xcb_get_window_attributes_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_get_window_attributes_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;
    }

    public unsafe partial struct xcb_get_window_attributes_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte backing_store;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("xcb_visualid_t")]
        public uint visual;

        [NativeTypeName("uint16_t")]
        public ushort _class;

        [NativeTypeName("uint8_t")]
        public byte bit_gravity;

        [NativeTypeName("uint8_t")]
        public byte win_gravity;

        [NativeTypeName("uint32_t")]
        public uint backing_planes;

        [NativeTypeName("uint32_t")]
        public uint backing_pixel;

        [NativeTypeName("uint8_t")]
        public byte save_under;

        [NativeTypeName("uint8_t")]
        public byte map_is_installed;

        [NativeTypeName("uint8_t")]
        public byte map_state;

        [NativeTypeName("uint8_t")]
        public byte override_redirect;

        [NativeTypeName("xcb_colormap_t")]
        public uint colormap;

        [NativeTypeName("uint32_t")]
        public uint all_event_masks;

        [NativeTypeName("uint32_t")]
        public uint your_event_mask;

        [NativeTypeName("uint16_t")]
        public ushort do_not_propagate_mask;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad0[2];
    }

    public partial struct xcb_destroy_window_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;
    }

    public partial struct xcb_destroy_subwindows_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_set_mode_t : uint
    {
        XCB_SET_MODE_INSERT = 0,
        XCB_SET_MODE_DELETE = 1,
    }

    public partial struct xcb_change_save_set_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte mode;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;
    }

    public partial struct xcb_reparent_window_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("xcb_window_t")]
        public uint parent;

        [NativeTypeName("int16_t")]
        public short x;

        [NativeTypeName("int16_t")]
        public short y;
    }

    public partial struct xcb_map_window_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;
    }

    public partial struct xcb_map_subwindows_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;
    }

    public partial struct xcb_unmap_window_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;
    }

    public partial struct xcb_unmap_subwindows_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_config_window_t : uint
    {
        XCB_CONFIG_WINDOW_X = 1,
        XCB_CONFIG_WINDOW_Y = 2,
        XCB_CONFIG_WINDOW_WIDTH = 4,
        XCB_CONFIG_WINDOW_HEIGHT = 8,
        XCB_CONFIG_WINDOW_BORDER_WIDTH = 16,
        XCB_CONFIG_WINDOW_SIBLING = 32,
        XCB_CONFIG_WINDOW_STACK_MODE = 64,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_stack_mode_t : uint
    {
        XCB_STACK_MODE_ABOVE = 0,
        XCB_STACK_MODE_BELOW = 1,
        XCB_STACK_MODE_TOP_IF = 2,
        XCB_STACK_MODE_BOTTOM_IF = 3,
        XCB_STACK_MODE_OPPOSITE = 4,
    }

    public partial struct xcb_configure_window_value_list_t
    {
        [NativeTypeName("int32_t")]
        public int x;

        [NativeTypeName("int32_t")]
        public int y;

        [NativeTypeName("uint32_t")]
        public uint width;

        [NativeTypeName("uint32_t")]
        public uint height;

        [NativeTypeName("uint32_t")]
        public uint border_width;

        [NativeTypeName("xcb_window_t")]
        public uint sibling;

        [NativeTypeName("uint32_t")]
        public uint stack_mode;
    }

    public unsafe partial struct xcb_configure_window_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("uint16_t")]
        public ushort value_mask;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad1[2];
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_circulate_t : uint
    {
        XCB_CIRCULATE_RAISE_LOWEST = 0,
        XCB_CIRCULATE_LOWER_HIGHEST = 1,
    }

    public partial struct xcb_circulate_window_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte direction;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;
    }

    public partial struct xcb_get_geometry_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_get_geometry_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_drawable_t")]
        public uint drawable;
    }

    public unsafe partial struct xcb_get_geometry_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte depth;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("xcb_window_t")]
        public uint root;

        [NativeTypeName("int16_t")]
        public short x;

        [NativeTypeName("int16_t")]
        public short y;

        [NativeTypeName("uint16_t")]
        public ushort width;

        [NativeTypeName("uint16_t")]
        public ushort height;

        [NativeTypeName("uint16_t")]
        public ushort border_width;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad0[2];
    }

    public partial struct xcb_query_tree_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_query_tree_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;
    }

    public unsafe partial struct xcb_query_tree_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("xcb_window_t")]
        public uint root;

        [NativeTypeName("xcb_window_t")]
        public uint parent;

        [NativeTypeName("uint16_t")]
        public ushort children_len;

        [NativeTypeName("uint8_t[14]")]
        public fixed byte pad1[14];
    }

    public partial struct xcb_intern_atom_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public unsafe partial struct xcb_intern_atom_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte only_if_exists;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("uint16_t")]
        public ushort name_len;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad0[2];
    }

    public partial struct xcb_intern_atom_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("xcb_atom_t")]
        public uint atom;
    }

    public partial struct xcb_get_atom_name_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_get_atom_name_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_atom_t")]
        public uint atom;
    }

    public unsafe partial struct xcb_get_atom_name_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint16_t")]
        public ushort name_len;

        [NativeTypeName("uint8_t[22]")]
        public fixed byte pad1[22];
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_prop_mode_t : uint
    {
        XCB_PROP_MODE_REPLACE = 0,
        XCB_PROP_MODE_PREPEND = 1,
        XCB_PROP_MODE_APPEND = 2,
    }

    public unsafe partial struct xcb_change_property_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte mode;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("xcb_atom_t")]
        public uint property;

        [NativeTypeName("xcb_atom_t")]
        public uint type;

        [NativeTypeName("uint8_t")]
        public byte format;

        [NativeTypeName("uint8_t[3]")]
        public fixed byte pad0[3];

        [NativeTypeName("uint32_t")]
        public uint data_len;
    }

    public partial struct xcb_delete_property_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("xcb_atom_t")]
        public uint property;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_get_property_type_t : uint
    {
        XCB_GET_PROPERTY_TYPE_ANY = 0,
    }

    public partial struct xcb_get_property_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_get_property_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte _delete;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("xcb_atom_t")]
        public uint property;

        [NativeTypeName("xcb_atom_t")]
        public uint type;

        [NativeTypeName("uint32_t")]
        public uint long_offset;

        [NativeTypeName("uint32_t")]
        public uint long_length;
    }

    public unsafe partial struct xcb_get_property_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte format;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("xcb_atom_t")]
        public uint type;

        [NativeTypeName("uint32_t")]
        public uint bytes_after;

        [NativeTypeName("uint32_t")]
        public uint value_len;

        [NativeTypeName("uint8_t[12]")]
        public fixed byte pad0[12];
    }

    public partial struct xcb_list_properties_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_list_properties_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;
    }

    public unsafe partial struct xcb_list_properties_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint16_t")]
        public ushort atoms_len;

        [NativeTypeName("uint8_t[22]")]
        public fixed byte pad1[22];
    }

    public partial struct xcb_set_selection_owner_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint owner;

        [NativeTypeName("xcb_atom_t")]
        public uint selection;

        [NativeTypeName("xcb_timestamp_t")]
        public uint time;
    }

    public partial struct xcb_get_selection_owner_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_get_selection_owner_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_atom_t")]
        public uint selection;
    }

    public partial struct xcb_get_selection_owner_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("xcb_window_t")]
        public uint owner;
    }

    public partial struct xcb_convert_selection_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint requestor;

        [NativeTypeName("xcb_atom_t")]
        public uint selection;

        [NativeTypeName("xcb_atom_t")]
        public uint target;

        [NativeTypeName("xcb_atom_t")]
        public uint property;

        [NativeTypeName("xcb_timestamp_t")]
        public uint time;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_send_event_dest_t : uint
    {
        XCB_SEND_EVENT_DEST_POINTER_WINDOW = 0,
        XCB_SEND_EVENT_DEST_ITEM_FOCUS = 1,
    }

    public unsafe partial struct xcb_send_event_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte propagate;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint destination;

        [NativeTypeName("uint32_t")]
        public uint event_mask;

        [NativeTypeName("char[32]")]
        public fixed sbyte @event[32];
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_grab_mode_t : uint
    {
        XCB_GRAB_MODE_SYNC = 0,
        XCB_GRAB_MODE_ASYNC = 1,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_grab_status_t : uint
    {
        XCB_GRAB_STATUS_SUCCESS = 0,
        XCB_GRAB_STATUS_ALREADY_GRABBED = 1,
        XCB_GRAB_STATUS_INVALID_TIME = 2,
        XCB_GRAB_STATUS_NOT_VIEWABLE = 3,
        XCB_GRAB_STATUS_FROZEN = 4,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_cursor_enum_t : uint
    {
        XCB_CURSOR_NONE = 0,
    }

    public partial struct xcb_grab_pointer_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_grab_pointer_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte owner_events;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint grab_window;

        [NativeTypeName("uint16_t")]
        public ushort event_mask;

        [NativeTypeName("uint8_t")]
        public byte pointer_mode;

        [NativeTypeName("uint8_t")]
        public byte keyboard_mode;

        [NativeTypeName("xcb_window_t")]
        public uint confine_to;

        [NativeTypeName("xcb_cursor_t")]
        public uint cursor;

        [NativeTypeName("xcb_timestamp_t")]
        public uint time;
    }

    public partial struct xcb_grab_pointer_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte status;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;
    }

    public partial struct xcb_ungrab_pointer_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_timestamp_t")]
        public uint time;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_button_index_t : uint
    {
        XCB_BUTTON_INDEX_ANY = 0,
        XCB_BUTTON_INDEX_1 = 1,
        XCB_BUTTON_INDEX_2 = 2,
        XCB_BUTTON_INDEX_3 = 3,
        XCB_BUTTON_INDEX_4 = 4,
        XCB_BUTTON_INDEX_5 = 5,
    }

    public partial struct xcb_grab_button_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte owner_events;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint grab_window;

        [NativeTypeName("uint16_t")]
        public ushort event_mask;

        [NativeTypeName("uint8_t")]
        public byte pointer_mode;

        [NativeTypeName("uint8_t")]
        public byte keyboard_mode;

        [NativeTypeName("xcb_window_t")]
        public uint confine_to;

        [NativeTypeName("xcb_cursor_t")]
        public uint cursor;

        [NativeTypeName("uint8_t")]
        public byte button;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort modifiers;
    }

    public unsafe partial struct xcb_ungrab_button_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte button;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint grab_window;

        [NativeTypeName("uint16_t")]
        public ushort modifiers;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad0[2];
    }

    public unsafe partial struct xcb_change_active_pointer_grab_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_cursor_t")]
        public uint cursor;

        [NativeTypeName("xcb_timestamp_t")]
        public uint time;

        [NativeTypeName("uint16_t")]
        public ushort event_mask;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad1[2];
    }

    public partial struct xcb_grab_keyboard_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public unsafe partial struct xcb_grab_keyboard_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte owner_events;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint grab_window;

        [NativeTypeName("xcb_timestamp_t")]
        public uint time;

        [NativeTypeName("uint8_t")]
        public byte pointer_mode;

        [NativeTypeName("uint8_t")]
        public byte keyboard_mode;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad0[2];
    }

    public partial struct xcb_grab_keyboard_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte status;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;
    }

    public partial struct xcb_ungrab_keyboard_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_timestamp_t")]
        public uint time;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_grab_t : uint
    {
        XCB_GRAB_ANY = 0,
    }

    public unsafe partial struct xcb_grab_key_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte owner_events;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint grab_window;

        [NativeTypeName("uint16_t")]
        public ushort modifiers;

        [NativeTypeName("xcb_keycode_t")]
        public byte key;

        [NativeTypeName("uint8_t")]
        public byte pointer_mode;

        [NativeTypeName("uint8_t")]
        public byte keyboard_mode;

        [NativeTypeName("uint8_t[3]")]
        public fixed byte pad0[3];
    }

    public unsafe partial struct xcb_ungrab_key_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("xcb_keycode_t")]
        public byte key;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint grab_window;

        [NativeTypeName("uint16_t")]
        public ushort modifiers;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad0[2];
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_allow_t : uint
    {
        XCB_ALLOW_ASYNC_POINTER = 0,
        XCB_ALLOW_SYNC_POINTER = 1,
        XCB_ALLOW_REPLAY_POINTER = 2,
        XCB_ALLOW_ASYNC_KEYBOARD = 3,
        XCB_ALLOW_SYNC_KEYBOARD = 4,
        XCB_ALLOW_REPLAY_KEYBOARD = 5,
        XCB_ALLOW_ASYNC_BOTH = 6,
        XCB_ALLOW_SYNC_BOTH = 7,
    }

    public partial struct xcb_allow_events_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte mode;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_timestamp_t")]
        public uint time;
    }

    public partial struct xcb_grab_server_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    public partial struct xcb_ungrab_server_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    public partial struct xcb_query_pointer_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_query_pointer_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;
    }

    public unsafe partial struct xcb_query_pointer_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte same_screen;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("xcb_window_t")]
        public uint root;

        [NativeTypeName("xcb_window_t")]
        public uint child;

        [NativeTypeName("int16_t")]
        public short root_x;

        [NativeTypeName("int16_t")]
        public short root_y;

        [NativeTypeName("int16_t")]
        public short win_x;

        [NativeTypeName("int16_t")]
        public short win_y;

        [NativeTypeName("uint16_t")]
        public ushort mask;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad0[2];
    }

    public partial struct xcb_timecoord_t
    {
        [NativeTypeName("xcb_timestamp_t")]
        public uint time;

        [NativeTypeName("int16_t")]
        public short x;

        [NativeTypeName("int16_t")]
        public short y;
    }

    public unsafe partial struct xcb_timecoord_iterator_t
    {
        public xcb_timecoord_t* data;

        public int rem;

        public int index;
    }

    public partial struct xcb_get_motion_events_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_get_motion_events_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("xcb_timestamp_t")]
        public uint start;

        [NativeTypeName("xcb_timestamp_t")]
        public uint stop;
    }

    public unsafe partial struct xcb_get_motion_events_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint32_t")]
        public uint events_len;

        [NativeTypeName("uint8_t[20]")]
        public fixed byte pad1[20];
    }

    public partial struct xcb_translate_coordinates_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_translate_coordinates_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint src_window;

        [NativeTypeName("xcb_window_t")]
        public uint dst_window;

        [NativeTypeName("int16_t")]
        public short src_x;

        [NativeTypeName("int16_t")]
        public short src_y;
    }

    public partial struct xcb_translate_coordinates_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte same_screen;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("xcb_window_t")]
        public uint child;

        [NativeTypeName("int16_t")]
        public short dst_x;

        [NativeTypeName("int16_t")]
        public short dst_y;
    }

    public partial struct xcb_warp_pointer_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint src_window;

        [NativeTypeName("xcb_window_t")]
        public uint dst_window;

        [NativeTypeName("int16_t")]
        public short src_x;

        [NativeTypeName("int16_t")]
        public short src_y;

        [NativeTypeName("uint16_t")]
        public ushort src_width;

        [NativeTypeName("uint16_t")]
        public ushort src_height;

        [NativeTypeName("int16_t")]
        public short dst_x;

        [NativeTypeName("int16_t")]
        public short dst_y;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_input_focus_t : uint
    {
        XCB_INPUT_FOCUS_NONE = 0,
        XCB_INPUT_FOCUS_POINTER_ROOT = 1,
        XCB_INPUT_FOCUS_PARENT = 2,
        XCB_INPUT_FOCUS_FOLLOW_KEYBOARD = 3,
    }

    public partial struct xcb_set_input_focus_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte revert_to;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint focus;

        [NativeTypeName("xcb_timestamp_t")]
        public uint time;
    }

    public partial struct xcb_get_input_focus_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_get_input_focus_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    public partial struct xcb_get_input_focus_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte revert_to;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("xcb_window_t")]
        public uint focus;
    }

    public partial struct xcb_query_keymap_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_query_keymap_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    public unsafe partial struct xcb_query_keymap_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint8_t[32]")]
        public fixed byte keys[32];
    }

    public unsafe partial struct xcb_open_font_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_font_t")]
        public uint fid;

        [NativeTypeName("uint16_t")]
        public ushort name_len;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad1[2];
    }

    public partial struct xcb_close_font_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_font_t")]
        public uint font;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_font_draw_t : uint
    {
        XCB_FONT_DRAW_LEFT_TO_RIGHT = 0,
        XCB_FONT_DRAW_RIGHT_TO_LEFT = 1,
    }

    public partial struct xcb_fontprop_t
    {
        [NativeTypeName("xcb_atom_t")]
        public uint name;

        [NativeTypeName("uint32_t")]
        public uint value;
    }

    public unsafe partial struct xcb_fontprop_iterator_t
    {
        public xcb_fontprop_t* data;

        public int rem;

        public int index;
    }

    public partial struct xcb_charinfo_t
    {
        [NativeTypeName("int16_t")]
        public short left_side_bearing;

        [NativeTypeName("int16_t")]
        public short right_side_bearing;

        [NativeTypeName("int16_t")]
        public short character_width;

        [NativeTypeName("int16_t")]
        public short ascent;

        [NativeTypeName("int16_t")]
        public short descent;

        [NativeTypeName("uint16_t")]
        public ushort attributes;
    }

    public unsafe partial struct xcb_charinfo_iterator_t
    {
        public xcb_charinfo_t* data;

        public int rem;

        public int index;
    }

    public partial struct xcb_query_font_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_query_font_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_fontable_t")]
        public uint font;
    }

    public unsafe partial struct xcb_query_font_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        public xcb_charinfo_t min_bounds;

        [NativeTypeName("uint8_t[4]")]
        public fixed byte pad1[4];

        public xcb_charinfo_t max_bounds;

        [NativeTypeName("uint8_t[4]")]
        public fixed byte pad2[4];

        [NativeTypeName("uint16_t")]
        public ushort min_char_or_byte2;

        [NativeTypeName("uint16_t")]
        public ushort max_char_or_byte2;

        [NativeTypeName("uint16_t")]
        public ushort default_char;

        [NativeTypeName("uint16_t")]
        public ushort properties_len;

        [NativeTypeName("uint8_t")]
        public byte draw_direction;

        [NativeTypeName("uint8_t")]
        public byte min_byte1;

        [NativeTypeName("uint8_t")]
        public byte max_byte1;

        [NativeTypeName("uint8_t")]
        public byte all_chars_exist;

        [NativeTypeName("int16_t")]
        public short font_ascent;

        [NativeTypeName("int16_t")]
        public short font_descent;

        [NativeTypeName("uint32_t")]
        public uint char_infos_len;
    }

    public partial struct xcb_query_text_extents_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_query_text_extents_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte odd_length;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_fontable_t")]
        public uint font;
    }

    public partial struct xcb_query_text_extents_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte draw_direction;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("int16_t")]
        public short font_ascent;

        [NativeTypeName("int16_t")]
        public short font_descent;

        [NativeTypeName("int16_t")]
        public short overall_ascent;

        [NativeTypeName("int16_t")]
        public short overall_descent;

        [NativeTypeName("int32_t")]
        public int overall_width;

        [NativeTypeName("int32_t")]
        public int overall_left;

        [NativeTypeName("int32_t")]
        public int overall_right;
    }

    public partial struct xcb_str_t
    {
        [NativeTypeName("uint8_t")]
        public byte name_len;
    }

    public unsafe partial struct xcb_str_iterator_t
    {
        public xcb_str_t* data;

        public int rem;

        public int index;
    }

    public partial struct xcb_list_fonts_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_list_fonts_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("uint16_t")]
        public ushort max_names;

        [NativeTypeName("uint16_t")]
        public ushort pattern_len;
    }

    public unsafe partial struct xcb_list_fonts_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint16_t")]
        public ushort names_len;

        [NativeTypeName("uint8_t[22]")]
        public fixed byte pad1[22];
    }

    public partial struct xcb_list_fonts_with_info_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_list_fonts_with_info_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("uint16_t")]
        public ushort max_names;

        [NativeTypeName("uint16_t")]
        public ushort pattern_len;
    }

    public unsafe partial struct xcb_list_fonts_with_info_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte name_len;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        public xcb_charinfo_t min_bounds;

        [NativeTypeName("uint8_t[4]")]
        public fixed byte pad0[4];

        public xcb_charinfo_t max_bounds;

        [NativeTypeName("uint8_t[4]")]
        public fixed byte pad1[4];

        [NativeTypeName("uint16_t")]
        public ushort min_char_or_byte2;

        [NativeTypeName("uint16_t")]
        public ushort max_char_or_byte2;

        [NativeTypeName("uint16_t")]
        public ushort default_char;

        [NativeTypeName("uint16_t")]
        public ushort properties_len;

        [NativeTypeName("uint8_t")]
        public byte draw_direction;

        [NativeTypeName("uint8_t")]
        public byte min_byte1;

        [NativeTypeName("uint8_t")]
        public byte max_byte1;

        [NativeTypeName("uint8_t")]
        public byte all_chars_exist;

        [NativeTypeName("int16_t")]
        public short font_ascent;

        [NativeTypeName("int16_t")]
        public short font_descent;

        [NativeTypeName("uint32_t")]
        public uint replies_hint;
    }

    public unsafe partial struct xcb_set_font_path_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("uint16_t")]
        public ushort font_qty;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad1[2];
    }

    public partial struct xcb_get_font_path_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_get_font_path_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    public unsafe partial struct xcb_get_font_path_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint16_t")]
        public ushort path_len;

        [NativeTypeName("uint8_t[22]")]
        public fixed byte pad1[22];
    }

    public partial struct xcb_create_pixmap_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte depth;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_pixmap_t")]
        public uint pid;

        [NativeTypeName("xcb_drawable_t")]
        public uint drawable;

        [NativeTypeName("uint16_t")]
        public ushort width;

        [NativeTypeName("uint16_t")]
        public ushort height;
    }

    public partial struct xcb_free_pixmap_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_pixmap_t")]
        public uint pixmap;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_gc_t : uint
    {
        XCB_GC_FUNCTION = 1,
        XCB_GC_PLANE_MASK = 2,
        XCB_GC_FOREGROUND = 4,
        XCB_GC_BACKGROUND = 8,
        XCB_GC_LINE_WIDTH = 16,
        XCB_GC_LINE_STYLE = 32,
        XCB_GC_CAP_STYLE = 64,
        XCB_GC_JOIN_STYLE = 128,
        XCB_GC_FILL_STYLE = 256,
        XCB_GC_FILL_RULE = 512,
        XCB_GC_TILE = 1024,
        XCB_GC_STIPPLE = 2048,
        XCB_GC_TILE_STIPPLE_ORIGIN_X = 4096,
        XCB_GC_TILE_STIPPLE_ORIGIN_Y = 8192,
        XCB_GC_FONT = 16384,
        XCB_GC_SUBWINDOW_MODE = 32768,
        XCB_GC_GRAPHICS_EXPOSURES = 65536,
        XCB_GC_CLIP_ORIGIN_X = 131072,
        XCB_GC_CLIP_ORIGIN_Y = 262144,
        XCB_GC_CLIP_MASK = 524288,
        XCB_GC_DASH_OFFSET = 1048576,
        XCB_GC_DASH_LIST = 2097152,
        XCB_GC_ARC_MODE = 4194304,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_gx_t : uint
    {
        XCB_GX_CLEAR = 0,
        XCB_GX_AND = 1,
        XCB_GX_AND_REVERSE = 2,
        XCB_GX_COPY = 3,
        XCB_GX_AND_INVERTED = 4,
        XCB_GX_NOOP = 5,
        XCB_GX_XOR = 6,
        XCB_GX_OR = 7,
        XCB_GX_NOR = 8,
        XCB_GX_EQUIV = 9,
        XCB_GX_INVERT = 10,
        XCB_GX_OR_REVERSE = 11,
        XCB_GX_COPY_INVERTED = 12,
        XCB_GX_OR_INVERTED = 13,
        XCB_GX_NAND = 14,
        XCB_GX_SET = 15,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_line_style_t : uint
    {
        XCB_LINE_STYLE_SOLID = 0,
        XCB_LINE_STYLE_ON_OFF_DASH = 1,
        XCB_LINE_STYLE_DOUBLE_DASH = 2,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_cap_style_t : uint
    {
        XCB_CAP_STYLE_NOT_LAST = 0,
        XCB_CAP_STYLE_BUTT = 1,
        XCB_CAP_STYLE_ROUND = 2,
        XCB_CAP_STYLE_PROJECTING = 3,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_join_style_t : uint
    {
        XCB_JOIN_STYLE_MITER = 0,
        XCB_JOIN_STYLE_ROUND = 1,
        XCB_JOIN_STYLE_BEVEL = 2,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_fill_style_t : uint
    {
        XCB_FILL_STYLE_SOLID = 0,
        XCB_FILL_STYLE_TILED = 1,
        XCB_FILL_STYLE_STIPPLED = 2,
        XCB_FILL_STYLE_OPAQUE_STIPPLED = 3,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_fill_rule_t : uint
    {
        XCB_FILL_RULE_EVEN_ODD = 0,
        XCB_FILL_RULE_WINDING = 1,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_subwindow_mode_t : uint
    {
        XCB_SUBWINDOW_MODE_CLIP_BY_CHILDREN = 0,
        XCB_SUBWINDOW_MODE_INCLUDE_INFERIORS = 1,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_arc_mode_t : uint
    {
        XCB_ARC_MODE_CHORD = 0,
        XCB_ARC_MODE_PIE_SLICE = 1,
    }

    public partial struct xcb_create_gc_value_list_t
    {
        [NativeTypeName("uint32_t")]
        public uint function;

        [NativeTypeName("uint32_t")]
        public uint plane_mask;

        [NativeTypeName("uint32_t")]
        public uint foreground;

        [NativeTypeName("uint32_t")]
        public uint background;

        [NativeTypeName("uint32_t")]
        public uint line_width;

        [NativeTypeName("uint32_t")]
        public uint line_style;

        [NativeTypeName("uint32_t")]
        public uint cap_style;

        [NativeTypeName("uint32_t")]
        public uint join_style;

        [NativeTypeName("uint32_t")]
        public uint fill_style;

        [NativeTypeName("uint32_t")]
        public uint fill_rule;

        [NativeTypeName("xcb_pixmap_t")]
        public uint tile;

        [NativeTypeName("xcb_pixmap_t")]
        public uint stipple;

        [NativeTypeName("int32_t")]
        public int tile_stipple_x_origin;

        [NativeTypeName("int32_t")]
        public int tile_stipple_y_origin;

        [NativeTypeName("xcb_font_t")]
        public uint font;

        [NativeTypeName("uint32_t")]
        public uint subwindow_mode;

        [NativeTypeName("xcb_bool32_t")]
        public uint graphics_exposures;

        [NativeTypeName("int32_t")]
        public int clip_x_origin;

        [NativeTypeName("int32_t")]
        public int clip_y_origin;

        [NativeTypeName("xcb_pixmap_t")]
        public uint clip_mask;

        [NativeTypeName("uint32_t")]
        public uint dash_offset;

        [NativeTypeName("uint32_t")]
        public uint dashes;

        [NativeTypeName("uint32_t")]
        public uint arc_mode;
    }

    public partial struct xcb_create_gc_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_gcontext_t")]
        public uint cid;

        [NativeTypeName("xcb_drawable_t")]
        public uint drawable;

        [NativeTypeName("uint32_t")]
        public uint value_mask;
    }

    public partial struct xcb_change_gc_value_list_t
    {
        [NativeTypeName("uint32_t")]
        public uint function;

        [NativeTypeName("uint32_t")]
        public uint plane_mask;

        [NativeTypeName("uint32_t")]
        public uint foreground;

        [NativeTypeName("uint32_t")]
        public uint background;

        [NativeTypeName("uint32_t")]
        public uint line_width;

        [NativeTypeName("uint32_t")]
        public uint line_style;

        [NativeTypeName("uint32_t")]
        public uint cap_style;

        [NativeTypeName("uint32_t")]
        public uint join_style;

        [NativeTypeName("uint32_t")]
        public uint fill_style;

        [NativeTypeName("uint32_t")]
        public uint fill_rule;

        [NativeTypeName("xcb_pixmap_t")]
        public uint tile;

        [NativeTypeName("xcb_pixmap_t")]
        public uint stipple;

        [NativeTypeName("int32_t")]
        public int tile_stipple_x_origin;

        [NativeTypeName("int32_t")]
        public int tile_stipple_y_origin;

        [NativeTypeName("xcb_font_t")]
        public uint font;

        [NativeTypeName("uint32_t")]
        public uint subwindow_mode;

        [NativeTypeName("xcb_bool32_t")]
        public uint graphics_exposures;

        [NativeTypeName("int32_t")]
        public int clip_x_origin;

        [NativeTypeName("int32_t")]
        public int clip_y_origin;

        [NativeTypeName("xcb_pixmap_t")]
        public uint clip_mask;

        [NativeTypeName("uint32_t")]
        public uint dash_offset;

        [NativeTypeName("uint32_t")]
        public uint dashes;

        [NativeTypeName("uint32_t")]
        public uint arc_mode;
    }

    public partial struct xcb_change_gc_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_gcontext_t")]
        public uint gc;

        [NativeTypeName("uint32_t")]
        public uint value_mask;
    }

    public partial struct xcb_copy_gc_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_gcontext_t")]
        public uint src_gc;

        [NativeTypeName("xcb_gcontext_t")]
        public uint dst_gc;

        [NativeTypeName("uint32_t")]
        public uint value_mask;
    }

    public partial struct xcb_set_dashes_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_gcontext_t")]
        public uint gc;

        [NativeTypeName("uint16_t")]
        public ushort dash_offset;

        [NativeTypeName("uint16_t")]
        public ushort dashes_len;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_clip_ordering_t : uint
    {
        XCB_CLIP_ORDERING_UNSORTED = 0,
        XCB_CLIP_ORDERING_Y_SORTED = 1,
        XCB_CLIP_ORDERING_YX_SORTED = 2,
        XCB_CLIP_ORDERING_YX_BANDED = 3,
    }

    public partial struct xcb_set_clip_rectangles_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte ordering;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_gcontext_t")]
        public uint gc;

        [NativeTypeName("int16_t")]
        public short clip_x_origin;

        [NativeTypeName("int16_t")]
        public short clip_y_origin;
    }

    public partial struct xcb_free_gc_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_gcontext_t")]
        public uint gc;
    }

    public partial struct xcb_clear_area_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte exposures;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("int16_t")]
        public short x;

        [NativeTypeName("int16_t")]
        public short y;

        [NativeTypeName("uint16_t")]
        public ushort width;

        [NativeTypeName("uint16_t")]
        public ushort height;
    }

    public partial struct xcb_copy_area_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_drawable_t")]
        public uint src_drawable;

        [NativeTypeName("xcb_drawable_t")]
        public uint dst_drawable;

        [NativeTypeName("xcb_gcontext_t")]
        public uint gc;

        [NativeTypeName("int16_t")]
        public short src_x;

        [NativeTypeName("int16_t")]
        public short src_y;

        [NativeTypeName("int16_t")]
        public short dst_x;

        [NativeTypeName("int16_t")]
        public short dst_y;

        [NativeTypeName("uint16_t")]
        public ushort width;

        [NativeTypeName("uint16_t")]
        public ushort height;
    }

    public partial struct xcb_copy_plane_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_drawable_t")]
        public uint src_drawable;

        [NativeTypeName("xcb_drawable_t")]
        public uint dst_drawable;

        [NativeTypeName("xcb_gcontext_t")]
        public uint gc;

        [NativeTypeName("int16_t")]
        public short src_x;

        [NativeTypeName("int16_t")]
        public short src_y;

        [NativeTypeName("int16_t")]
        public short dst_x;

        [NativeTypeName("int16_t")]
        public short dst_y;

        [NativeTypeName("uint16_t")]
        public ushort width;

        [NativeTypeName("uint16_t")]
        public ushort height;

        [NativeTypeName("uint32_t")]
        public uint bit_plane;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_coord_mode_t : uint
    {
        XCB_COORD_MODE_ORIGIN = 0,
        XCB_COORD_MODE_PREVIOUS = 1,
    }

    public partial struct xcb_poly_point_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte coordinate_mode;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_drawable_t")]
        public uint drawable;

        [NativeTypeName("xcb_gcontext_t")]
        public uint gc;
    }

    public partial struct xcb_poly_line_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte coordinate_mode;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_drawable_t")]
        public uint drawable;

        [NativeTypeName("xcb_gcontext_t")]
        public uint gc;
    }

    public partial struct xcb_segment_t
    {
        [NativeTypeName("int16_t")]
        public short x1;

        [NativeTypeName("int16_t")]
        public short y1;

        [NativeTypeName("int16_t")]
        public short x2;

        [NativeTypeName("int16_t")]
        public short y2;
    }

    public unsafe partial struct xcb_segment_iterator_t
    {
        public xcb_segment_t* data;

        public int rem;

        public int index;
    }

    public partial struct xcb_poly_segment_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_drawable_t")]
        public uint drawable;

        [NativeTypeName("xcb_gcontext_t")]
        public uint gc;
    }

    public partial struct xcb_poly_rectangle_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_drawable_t")]
        public uint drawable;

        [NativeTypeName("xcb_gcontext_t")]
        public uint gc;
    }

    public partial struct xcb_poly_arc_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_drawable_t")]
        public uint drawable;

        [NativeTypeName("xcb_gcontext_t")]
        public uint gc;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_poly_shape_t : uint
    {
        XCB_POLY_SHAPE_COMPLEX = 0,
        XCB_POLY_SHAPE_NONCONVEX = 1,
        XCB_POLY_SHAPE_CONVEX = 2,
    }

    public unsafe partial struct xcb_fill_poly_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_drawable_t")]
        public uint drawable;

        [NativeTypeName("xcb_gcontext_t")]
        public uint gc;

        [NativeTypeName("uint8_t")]
        public byte shape;

        [NativeTypeName("uint8_t")]
        public byte coordinate_mode;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad1[2];
    }

    public partial struct xcb_poly_fill_rectangle_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_drawable_t")]
        public uint drawable;

        [NativeTypeName("xcb_gcontext_t")]
        public uint gc;
    }

    public partial struct xcb_poly_fill_arc_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_drawable_t")]
        public uint drawable;

        [NativeTypeName("xcb_gcontext_t")]
        public uint gc;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_image_format_t : uint
    {
        XCB_IMAGE_FORMAT_XY_BITMAP = 0,
        XCB_IMAGE_FORMAT_XY_PIXMAP = 1,
        XCB_IMAGE_FORMAT_Z_PIXMAP = 2,
    }

    public unsafe partial struct xcb_put_image_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte format;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_drawable_t")]
        public uint drawable;

        [NativeTypeName("xcb_gcontext_t")]
        public uint gc;

        [NativeTypeName("uint16_t")]
        public ushort width;

        [NativeTypeName("uint16_t")]
        public ushort height;

        [NativeTypeName("int16_t")]
        public short dst_x;

        [NativeTypeName("int16_t")]
        public short dst_y;

        [NativeTypeName("uint8_t")]
        public byte left_pad;

        [NativeTypeName("uint8_t")]
        public byte depth;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad0[2];
    }

    public partial struct xcb_get_image_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_get_image_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte format;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_drawable_t")]
        public uint drawable;

        [NativeTypeName("int16_t")]
        public short x;

        [NativeTypeName("int16_t")]
        public short y;

        [NativeTypeName("uint16_t")]
        public ushort width;

        [NativeTypeName("uint16_t")]
        public ushort height;

        [NativeTypeName("uint32_t")]
        public uint plane_mask;
    }

    public unsafe partial struct xcb_get_image_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte depth;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("xcb_visualid_t")]
        public uint visual;

        [NativeTypeName("uint8_t[20]")]
        public fixed byte pad0[20];
    }

    public partial struct xcb_poly_text_8_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_drawable_t")]
        public uint drawable;

        [NativeTypeName("xcb_gcontext_t")]
        public uint gc;

        [NativeTypeName("int16_t")]
        public short x;

        [NativeTypeName("int16_t")]
        public short y;
    }

    public partial struct xcb_poly_text_16_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_drawable_t")]
        public uint drawable;

        [NativeTypeName("xcb_gcontext_t")]
        public uint gc;

        [NativeTypeName("int16_t")]
        public short x;

        [NativeTypeName("int16_t")]
        public short y;
    }

    public partial struct xcb_image_text_8_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte string_len;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_drawable_t")]
        public uint drawable;

        [NativeTypeName("xcb_gcontext_t")]
        public uint gc;

        [NativeTypeName("int16_t")]
        public short x;

        [NativeTypeName("int16_t")]
        public short y;
    }

    public partial struct xcb_image_text_16_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte string_len;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_drawable_t")]
        public uint drawable;

        [NativeTypeName("xcb_gcontext_t")]
        public uint gc;

        [NativeTypeName("int16_t")]
        public short x;

        [NativeTypeName("int16_t")]
        public short y;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_colormap_alloc_t : uint
    {
        XCB_COLORMAP_ALLOC_NONE = 0,
        XCB_COLORMAP_ALLOC_ALL = 1,
    }

    public partial struct xcb_create_colormap_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte alloc;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_colormap_t")]
        public uint mid;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("xcb_visualid_t")]
        public uint visual;
    }

    public partial struct xcb_free_colormap_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_colormap_t")]
        public uint cmap;
    }

    public partial struct xcb_copy_colormap_and_free_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_colormap_t")]
        public uint mid;

        [NativeTypeName("xcb_colormap_t")]
        public uint src_cmap;
    }

    public partial struct xcb_install_colormap_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_colormap_t")]
        public uint cmap;
    }

    public partial struct xcb_uninstall_colormap_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_colormap_t")]
        public uint cmap;
    }

    public partial struct xcb_list_installed_colormaps_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_list_installed_colormaps_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;
    }

    public unsafe partial struct xcb_list_installed_colormaps_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint16_t")]
        public ushort cmaps_len;

        [NativeTypeName("uint8_t[22]")]
        public fixed byte pad1[22];
    }

    public partial struct xcb_alloc_color_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public unsafe partial struct xcb_alloc_color_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_colormap_t")]
        public uint cmap;

        [NativeTypeName("uint16_t")]
        public ushort red;

        [NativeTypeName("uint16_t")]
        public ushort green;

        [NativeTypeName("uint16_t")]
        public ushort blue;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad1[2];
    }

    public unsafe partial struct xcb_alloc_color_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint16_t")]
        public ushort red;

        [NativeTypeName("uint16_t")]
        public ushort green;

        [NativeTypeName("uint16_t")]
        public ushort blue;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad1[2];

        [NativeTypeName("uint32_t")]
        public uint pixel;
    }

    public partial struct xcb_alloc_named_color_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public unsafe partial struct xcb_alloc_named_color_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_colormap_t")]
        public uint cmap;

        [NativeTypeName("uint16_t")]
        public ushort name_len;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad1[2];
    }

    public partial struct xcb_alloc_named_color_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint32_t")]
        public uint pixel;

        [NativeTypeName("uint16_t")]
        public ushort exact_red;

        [NativeTypeName("uint16_t")]
        public ushort exact_green;

        [NativeTypeName("uint16_t")]
        public ushort exact_blue;

        [NativeTypeName("uint16_t")]
        public ushort visual_red;

        [NativeTypeName("uint16_t")]
        public ushort visual_green;

        [NativeTypeName("uint16_t")]
        public ushort visual_blue;
    }

    public partial struct xcb_alloc_color_cells_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_alloc_color_cells_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte contiguous;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_colormap_t")]
        public uint cmap;

        [NativeTypeName("uint16_t")]
        public ushort colors;

        [NativeTypeName("uint16_t")]
        public ushort planes;
    }

    public unsafe partial struct xcb_alloc_color_cells_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint16_t")]
        public ushort pixels_len;

        [NativeTypeName("uint16_t")]
        public ushort masks_len;

        [NativeTypeName("uint8_t[20]")]
        public fixed byte pad1[20];
    }

    public partial struct xcb_alloc_color_planes_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_alloc_color_planes_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte contiguous;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_colormap_t")]
        public uint cmap;

        [NativeTypeName("uint16_t")]
        public ushort colors;

        [NativeTypeName("uint16_t")]
        public ushort reds;

        [NativeTypeName("uint16_t")]
        public ushort greens;

        [NativeTypeName("uint16_t")]
        public ushort blues;
    }

    public unsafe partial struct xcb_alloc_color_planes_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint16_t")]
        public ushort pixels_len;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad1[2];

        [NativeTypeName("uint32_t")]
        public uint red_mask;

        [NativeTypeName("uint32_t")]
        public uint green_mask;

        [NativeTypeName("uint32_t")]
        public uint blue_mask;

        [NativeTypeName("uint8_t[8]")]
        public fixed byte pad2[8];
    }

    public partial struct xcb_free_colors_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_colormap_t")]
        public uint cmap;

        [NativeTypeName("uint32_t")]
        public uint plane_mask;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_color_flag_t : uint
    {
        XCB_COLOR_FLAG_RED = 1,
        XCB_COLOR_FLAG_GREEN = 2,
        XCB_COLOR_FLAG_BLUE = 4,
    }

    public partial struct xcb_coloritem_t
    {
        [NativeTypeName("uint32_t")]
        public uint pixel;

        [NativeTypeName("uint16_t")]
        public ushort red;

        [NativeTypeName("uint16_t")]
        public ushort green;

        [NativeTypeName("uint16_t")]
        public ushort blue;

        [NativeTypeName("uint8_t")]
        public byte flags;

        [NativeTypeName("uint8_t")]
        public byte pad0;
    }

    public unsafe partial struct xcb_coloritem_iterator_t
    {
        public xcb_coloritem_t* data;

        public int rem;

        public int index;
    }

    public partial struct xcb_store_colors_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_colormap_t")]
        public uint cmap;
    }

    public unsafe partial struct xcb_store_named_color_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte flags;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_colormap_t")]
        public uint cmap;

        [NativeTypeName("uint32_t")]
        public uint pixel;

        [NativeTypeName("uint16_t")]
        public ushort name_len;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad0[2];
    }

    public unsafe partial struct xcb_rgb_t
    {
        [NativeTypeName("uint16_t")]
        public ushort red;

        [NativeTypeName("uint16_t")]
        public ushort green;

        [NativeTypeName("uint16_t")]
        public ushort blue;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad0[2];
    }

    public unsafe partial struct xcb_rgb_iterator_t
    {
        public xcb_rgb_t* data;

        public int rem;

        public int index;
    }

    public partial struct xcb_query_colors_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_query_colors_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_colormap_t")]
        public uint cmap;
    }

    public unsafe partial struct xcb_query_colors_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint16_t")]
        public ushort colors_len;

        [NativeTypeName("uint8_t[22]")]
        public fixed byte pad1[22];
    }

    public partial struct xcb_lookup_color_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public unsafe partial struct xcb_lookup_color_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_colormap_t")]
        public uint cmap;

        [NativeTypeName("uint16_t")]
        public ushort name_len;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad1[2];
    }

    public partial struct xcb_lookup_color_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint16_t")]
        public ushort exact_red;

        [NativeTypeName("uint16_t")]
        public ushort exact_green;

        [NativeTypeName("uint16_t")]
        public ushort exact_blue;

        [NativeTypeName("uint16_t")]
        public ushort visual_red;

        [NativeTypeName("uint16_t")]
        public ushort visual_green;

        [NativeTypeName("uint16_t")]
        public ushort visual_blue;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_pixmap_enum_t : uint
    {
        XCB_PIXMAP_NONE = 0,
    }

    public partial struct xcb_create_cursor_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_cursor_t")]
        public uint cid;

        [NativeTypeName("xcb_pixmap_t")]
        public uint source;

        [NativeTypeName("xcb_pixmap_t")]
        public uint mask;

        [NativeTypeName("uint16_t")]
        public ushort fore_red;

        [NativeTypeName("uint16_t")]
        public ushort fore_green;

        [NativeTypeName("uint16_t")]
        public ushort fore_blue;

        [NativeTypeName("uint16_t")]
        public ushort back_red;

        [NativeTypeName("uint16_t")]
        public ushort back_green;

        [NativeTypeName("uint16_t")]
        public ushort back_blue;

        [NativeTypeName("uint16_t")]
        public ushort x;

        [NativeTypeName("uint16_t")]
        public ushort y;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_font_enum_t : uint
    {
        XCB_FONT_NONE = 0,
    }

    public partial struct xcb_create_glyph_cursor_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_cursor_t")]
        public uint cid;

        [NativeTypeName("xcb_font_t")]
        public uint source_font;

        [NativeTypeName("xcb_font_t")]
        public uint mask_font;

        [NativeTypeName("uint16_t")]
        public ushort source_char;

        [NativeTypeName("uint16_t")]
        public ushort mask_char;

        [NativeTypeName("uint16_t")]
        public ushort fore_red;

        [NativeTypeName("uint16_t")]
        public ushort fore_green;

        [NativeTypeName("uint16_t")]
        public ushort fore_blue;

        [NativeTypeName("uint16_t")]
        public ushort back_red;

        [NativeTypeName("uint16_t")]
        public ushort back_green;

        [NativeTypeName("uint16_t")]
        public ushort back_blue;
    }

    public partial struct xcb_free_cursor_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_cursor_t")]
        public uint cursor;
    }

    public partial struct xcb_recolor_cursor_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_cursor_t")]
        public uint cursor;

        [NativeTypeName("uint16_t")]
        public ushort fore_red;

        [NativeTypeName("uint16_t")]
        public ushort fore_green;

        [NativeTypeName("uint16_t")]
        public ushort fore_blue;

        [NativeTypeName("uint16_t")]
        public ushort back_red;

        [NativeTypeName("uint16_t")]
        public ushort back_green;

        [NativeTypeName("uint16_t")]
        public ushort back_blue;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_query_shape_of_t : uint
    {
        XCB_QUERY_SHAPE_OF_LARGEST_CURSOR = 0,
        XCB_QUERY_SHAPE_OF_FASTEST_TILE = 1,
        XCB_QUERY_SHAPE_OF_FASTEST_STIPPLE = 2,
    }

    public partial struct xcb_query_best_size_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_query_best_size_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte _class;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_drawable_t")]
        public uint drawable;

        [NativeTypeName("uint16_t")]
        public ushort width;

        [NativeTypeName("uint16_t")]
        public ushort height;
    }

    public partial struct xcb_query_best_size_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint16_t")]
        public ushort width;

        [NativeTypeName("uint16_t")]
        public ushort height;
    }

    public partial struct xcb_query_extension_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public unsafe partial struct xcb_query_extension_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("uint16_t")]
        public ushort name_len;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad1[2];
    }

    public partial struct xcb_query_extension_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint8_t")]
        public byte present;

        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte first_event;

        [NativeTypeName("uint8_t")]
        public byte first_error;
    }

    public partial struct xcb_list_extensions_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_list_extensions_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    public unsafe partial struct xcb_list_extensions_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte names_len;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint8_t[24]")]
        public fixed byte pad0[24];
    }

    public unsafe partial struct xcb_change_keyboard_mapping_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte keycode_count;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_keycode_t")]
        public byte first_keycode;

        [NativeTypeName("uint8_t")]
        public byte keysyms_per_keycode;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad0[2];
    }

    public partial struct xcb_get_keyboard_mapping_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_get_keyboard_mapping_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_keycode_t")]
        public byte first_keycode;

        [NativeTypeName("uint8_t")]
        public byte count;
    }

    public unsafe partial struct xcb_get_keyboard_mapping_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte keysyms_per_keycode;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint8_t[24]")]
        public fixed byte pad0[24];
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_kb_t : uint
    {
        XCB_KB_KEY_CLICK_PERCENT = 1,
        XCB_KB_BELL_PERCENT = 2,
        XCB_KB_BELL_PITCH = 4,
        XCB_KB_BELL_DURATION = 8,
        XCB_KB_LED = 16,
        XCB_KB_LED_MODE = 32,
        XCB_KB_KEY = 64,
        XCB_KB_AUTO_REPEAT_MODE = 128,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_led_mode_t : uint
    {
        XCB_LED_MODE_OFF = 0,
        XCB_LED_MODE_ON = 1,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_auto_repeat_mode_t : uint
    {
        XCB_AUTO_REPEAT_MODE_OFF = 0,
        XCB_AUTO_REPEAT_MODE_ON = 1,
        XCB_AUTO_REPEAT_MODE_DEFAULT = 2,
    }

    public partial struct xcb_change_keyboard_control_value_list_t
    {
        [NativeTypeName("int32_t")]
        public int key_click_percent;

        [NativeTypeName("int32_t")]
        public int bell_percent;

        [NativeTypeName("int32_t")]
        public int bell_pitch;

        [NativeTypeName("int32_t")]
        public int bell_duration;

        [NativeTypeName("uint32_t")]
        public uint led;

        [NativeTypeName("uint32_t")]
        public uint led_mode;

        [NativeTypeName("xcb_keycode32_t")]
        public uint key;

        [NativeTypeName("uint32_t")]
        public uint auto_repeat_mode;
    }

    public partial struct xcb_change_keyboard_control_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("uint32_t")]
        public uint value_mask;
    }

    public partial struct xcb_get_keyboard_control_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_get_keyboard_control_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    public unsafe partial struct xcb_get_keyboard_control_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte global_auto_repeat;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint32_t")]
        public uint led_mask;

        [NativeTypeName("uint8_t")]
        public byte key_click_percent;

        [NativeTypeName("uint8_t")]
        public byte bell_percent;

        [NativeTypeName("uint16_t")]
        public ushort bell_pitch;

        [NativeTypeName("uint16_t")]
        public ushort bell_duration;

        [NativeTypeName("uint8_t[2]")]
        public fixed byte pad0[2];

        [NativeTypeName("uint8_t[32]")]
        public fixed byte auto_repeats[32];
    }

    public partial struct xcb_bell_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("int8_t")]
        public sbyte percent;

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    public partial struct xcb_change_pointer_control_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("int16_t")]
        public short acceleration_numerator;

        [NativeTypeName("int16_t")]
        public short acceleration_denominator;

        [NativeTypeName("int16_t")]
        public short threshold;

        [NativeTypeName("uint8_t")]
        public byte do_acceleration;

        [NativeTypeName("uint8_t")]
        public byte do_threshold;
    }

    public partial struct xcb_get_pointer_control_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_get_pointer_control_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    public unsafe partial struct xcb_get_pointer_control_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint16_t")]
        public ushort acceleration_numerator;

        [NativeTypeName("uint16_t")]
        public ushort acceleration_denominator;

        [NativeTypeName("uint16_t")]
        public ushort threshold;

        [NativeTypeName("uint8_t[18]")]
        public fixed byte pad1[18];
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_blanking_t : uint
    {
        XCB_BLANKING_NOT_PREFERRED = 0,
        XCB_BLANKING_PREFERRED = 1,
        XCB_BLANKING_DEFAULT = 2,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_exposures_t : uint
    {
        XCB_EXPOSURES_NOT_ALLOWED = 0,
        XCB_EXPOSURES_ALLOWED = 1,
        XCB_EXPOSURES_DEFAULT = 2,
    }

    public partial struct xcb_set_screen_saver_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("int16_t")]
        public short timeout;

        [NativeTypeName("int16_t")]
        public short interval;

        [NativeTypeName("uint8_t")]
        public byte prefer_blanking;

        [NativeTypeName("uint8_t")]
        public byte allow_exposures;
    }

    public partial struct xcb_get_screen_saver_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_get_screen_saver_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    public unsafe partial struct xcb_get_screen_saver_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint16_t")]
        public ushort timeout;

        [NativeTypeName("uint16_t")]
        public ushort interval;

        [NativeTypeName("uint8_t")]
        public byte prefer_blanking;

        [NativeTypeName("uint8_t")]
        public byte allow_exposures;

        [NativeTypeName("uint8_t[18]")]
        public fixed byte pad1[18];
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_host_mode_t : uint
    {
        XCB_HOST_MODE_INSERT = 0,
        XCB_HOST_MODE_DELETE = 1,
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_family_t : uint
    {
        XCB_FAMILY_INTERNET = 0,
        XCB_FAMILY_DECNET = 1,
        XCB_FAMILY_CHAOS = 2,
        XCB_FAMILY_SERVER_INTERPRETED = 5,
        XCB_FAMILY_INTERNET_6 = 6,
    }

    public partial struct xcb_change_hosts_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte mode;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("uint8_t")]
        public byte family;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort address_len;
    }

    public partial struct xcb_host_t
    {
        [NativeTypeName("uint8_t")]
        public byte family;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort address_len;
    }

    public unsafe partial struct xcb_host_iterator_t
    {
        public xcb_host_t* data;

        public int rem;

        public int index;
    }

    public partial struct xcb_list_hosts_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_list_hosts_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    public unsafe partial struct xcb_list_hosts_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte mode;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint16_t")]
        public ushort hosts_len;

        [NativeTypeName("uint8_t[22]")]
        public fixed byte pad0[22];
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_access_control_t : uint
    {
        XCB_ACCESS_CONTROL_DISABLE = 0,
        XCB_ACCESS_CONTROL_ENABLE = 1,
    }

    public partial struct xcb_set_access_control_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte mode;

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_close_down_t : uint
    {
        XCB_CLOSE_DOWN_DESTROY_ALL = 0,
        XCB_CLOSE_DOWN_RETAIN_PERMANENT = 1,
        XCB_CLOSE_DOWN_RETAIN_TEMPORARY = 2,
    }

    public partial struct xcb_set_close_down_mode_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte mode;

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_kill_t : uint
    {
        XCB_KILL_ALL_TEMPORARY = 0,
    }

    public partial struct xcb_kill_client_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("uint32_t")]
        public uint resource;
    }

    public partial struct xcb_rotate_properties_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;

        [NativeTypeName("xcb_window_t")]
        public uint window;

        [NativeTypeName("uint16_t")]
        public ushort atoms_len;

        [NativeTypeName("int16_t")]
        public short delta;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_screen_saver_t : uint
    {
        XCB_SCREEN_SAVER_RESET = 0,
        XCB_SCREEN_SAVER_ACTIVE = 1,
    }

    public partial struct xcb_force_screen_saver_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte mode;

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_mapping_status_t : uint
    {
        XCB_MAPPING_STATUS_SUCCESS = 0,
        XCB_MAPPING_STATUS_BUSY = 1,
        XCB_MAPPING_STATUS_FAILURE = 2,
    }

    public partial struct xcb_set_pointer_mapping_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_set_pointer_mapping_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte map_len;

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    public partial struct xcb_set_pointer_mapping_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte status;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;
    }

    public partial struct xcb_get_pointer_mapping_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_get_pointer_mapping_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    public unsafe partial struct xcb_get_pointer_mapping_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte map_len;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint8_t[24]")]
        public fixed byte pad0[24];
    }

    [NativeTypeName("unsigned int")]
    public enum xcb_map_index_t : uint
    {
        XCB_MAP_INDEX_SHIFT = 0,
        XCB_MAP_INDEX_LOCK = 1,
        XCB_MAP_INDEX_CONTROL = 2,
        XCB_MAP_INDEX_1 = 3,
        XCB_MAP_INDEX_2 = 4,
        XCB_MAP_INDEX_3 = 5,
        XCB_MAP_INDEX_4 = 6,
        XCB_MAP_INDEX_5 = 7,
    }

    public partial struct xcb_set_modifier_mapping_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_set_modifier_mapping_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte keycodes_per_modifier;

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    public partial struct xcb_set_modifier_mapping_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte status;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;
    }

    public partial struct xcb_get_modifier_mapping_cookie_t
    {
        [NativeTypeName("unsigned int")]
        public uint sequence;
    }

    public partial struct xcb_get_modifier_mapping_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    public unsafe partial struct xcb_get_modifier_mapping_reply_t
    {
        [NativeTypeName("uint8_t")]
        public byte response_type;

        [NativeTypeName("uint8_t")]
        public byte keycodes_per_modifier;

        [NativeTypeName("uint16_t")]
        public ushort sequence;

        [NativeTypeName("uint32_t")]
        public uint length;

        [NativeTypeName("uint8_t[24]")]
        public fixed byte pad0[24];
    }

    public partial struct xcb_no_operation_request_t
    {
        [NativeTypeName("uint8_t")]
        public byte major_opcode;

        [NativeTypeName("uint8_t")]
        public byte pad0;

        [NativeTypeName("uint16_t")]
        public ushort length;
    }

    public static unsafe partial class Xcb
    {
        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_flush(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint xcb_get_maximum_request_length(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_prefetch_maximum_request_length(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_event_t* xcb_wait_for_event(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_event_t* xcb_poll_for_event(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_event_t* xcb_poll_for_queued_event(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_event_t* xcb_poll_for_special_event(IntPtr c, [NativeTypeName("xcb_special_event_t *")] IntPtr se);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_event_t* xcb_wait_for_special_event(IntPtr c, [NativeTypeName("xcb_special_event_t *")] IntPtr se);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("xcb_special_event_t *")]
        public static extern IntPtr xcb_register_for_special_xge(IntPtr c, IntPtr ext, [NativeTypeName("uint32_t")] uint eid, [NativeTypeName("uint32_t *")] uint* stamp);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_unregister_for_special_event(IntPtr c, [NativeTypeName("xcb_special_event_t *")] IntPtr se);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_error_t* xcb_request_check(IntPtr c, xcb_void_cookie_t cookie);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_discard_reply(IntPtr c, [NativeTypeName("unsigned int")] uint sequence);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_discard_reply64(IntPtr c, [NativeTypeName("uint64_t")] nuint sequence);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const struct xcb_query_extension_reply_t *")]
        public static extern xcb_query_extension_reply_t* xcb_get_extension_data(IntPtr c, IntPtr ext);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_prefetch_extension_data(IntPtr c, IntPtr ext);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const struct xcb_setup_t *")]
        public static extern xcb_setup_t* xcb_get_setup(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_get_file_descriptor(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_connection_has_error(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr xcb_connect_to_fd(int fd, xcb_auth_info_t* auth_info);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_disconnect(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_parse_display([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("char **")] sbyte** host, int* display, int* screen);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr xcb_connect([NativeTypeName("const char *")] sbyte* displayname, int* screenp);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern IntPtr xcb_connect_to_display_with_auth_info([NativeTypeName("const char *")] sbyte* display, xcb_auth_info_t* auth, int* screen);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint xcb_generate_id(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern nuint xcb_total_read(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern nuint xcb_total_written(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_char2b_next(xcb_char2b_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_char2b_end(xcb_char2b_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_window_next(xcb_window_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_window_end(xcb_window_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_pixmap_next(xcb_pixmap_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_pixmap_end(xcb_pixmap_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_cursor_next(xcb_cursor_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_cursor_end(xcb_cursor_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_font_next(xcb_font_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_font_end(xcb_font_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_gcontext_next(xcb_gcontext_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_gcontext_end(xcb_gcontext_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_colormap_next(xcb_colormap_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_colormap_end(xcb_colormap_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_atom_next(xcb_atom_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_atom_end(xcb_atom_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_drawable_next(xcb_drawable_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_drawable_end(xcb_drawable_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_fontable_next(xcb_fontable_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_fontable_end(xcb_fontable_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_bool32_next(xcb_bool32_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_bool32_end(xcb_bool32_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_visualid_next(xcb_visualid_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_visualid_end(xcb_visualid_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_timestamp_next(xcb_timestamp_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_timestamp_end(xcb_timestamp_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_keysym_next(xcb_keysym_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_keysym_end(xcb_keysym_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_keycode_next(xcb_keycode_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_keycode_end(xcb_keycode_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_keycode32_next(xcb_keycode32_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_keycode32_end(xcb_keycode32_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_button_next(xcb_button_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_button_end(xcb_button_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_point_next(xcb_point_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_point_end(xcb_point_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_rectangle_next(xcb_rectangle_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_rectangle_end(xcb_rectangle_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_arc_next(xcb_arc_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_arc_end(xcb_arc_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_format_next(xcb_format_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_format_end(xcb_format_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_visualtype_next(xcb_visualtype_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_visualtype_end(xcb_visualtype_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_depth_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_visualtype_t* xcb_depth_visuals([NativeTypeName("const xcb_depth_t *")] xcb_depth_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_depth_visuals_length([NativeTypeName("const xcb_depth_t *")] xcb_depth_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_visualtype_iterator_t xcb_depth_visuals_iterator([NativeTypeName("const xcb_depth_t *")] xcb_depth_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_depth_next(xcb_depth_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_depth_end(xcb_depth_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_screen_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_screen_allowed_depths_length([NativeTypeName("const xcb_screen_t *")] xcb_screen_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_depth_iterator_t xcb_screen_allowed_depths_iterator([NativeTypeName("const xcb_screen_t *")] xcb_screen_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_screen_next(xcb_screen_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_screen_end(xcb_screen_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_setup_request_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* xcb_setup_request_authorization_protocol_name([NativeTypeName("const xcb_setup_request_t *")] xcb_setup_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_setup_request_authorization_protocol_name_length([NativeTypeName("const xcb_setup_request_t *")] xcb_setup_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_setup_request_authorization_protocol_name_end([NativeTypeName("const xcb_setup_request_t *")] xcb_setup_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* xcb_setup_request_authorization_protocol_data([NativeTypeName("const xcb_setup_request_t *")] xcb_setup_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_setup_request_authorization_protocol_data_length([NativeTypeName("const xcb_setup_request_t *")] xcb_setup_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_setup_request_authorization_protocol_data_end([NativeTypeName("const xcb_setup_request_t *")] xcb_setup_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_setup_request_next(xcb_setup_request_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_setup_request_end(xcb_setup_request_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_setup_failed_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* xcb_setup_failed_reason([NativeTypeName("const xcb_setup_failed_t *")] xcb_setup_failed_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_setup_failed_reason_length([NativeTypeName("const xcb_setup_failed_t *")] xcb_setup_failed_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_setup_failed_reason_end([NativeTypeName("const xcb_setup_failed_t *")] xcb_setup_failed_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_setup_failed_next(xcb_setup_failed_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_setup_failed_end(xcb_setup_failed_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_setup_authenticate_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* xcb_setup_authenticate_reason([NativeTypeName("const xcb_setup_authenticate_t *")] xcb_setup_authenticate_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_setup_authenticate_reason_length([NativeTypeName("const xcb_setup_authenticate_t *")] xcb_setup_authenticate_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_setup_authenticate_reason_end([NativeTypeName("const xcb_setup_authenticate_t *")] xcb_setup_authenticate_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_setup_authenticate_next(xcb_setup_authenticate_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_setup_authenticate_end(xcb_setup_authenticate_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_setup_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* xcb_setup_vendor([NativeTypeName("const xcb_setup_t *")] xcb_setup_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_setup_vendor_length([NativeTypeName("const xcb_setup_t *")] xcb_setup_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_setup_vendor_end([NativeTypeName("const xcb_setup_t *")] xcb_setup_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_format_t* xcb_setup_pixmap_formats([NativeTypeName("const xcb_setup_t *")] xcb_setup_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_setup_pixmap_formats_length([NativeTypeName("const xcb_setup_t *")] xcb_setup_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_format_iterator_t xcb_setup_pixmap_formats_iterator([NativeTypeName("const xcb_setup_t *")] xcb_setup_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_setup_roots_length([NativeTypeName("const xcb_setup_t *")] xcb_setup_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_screen_iterator_t xcb_setup_roots_iterator([NativeTypeName("const xcb_setup_t *")] xcb_setup_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_setup_next(xcb_setup_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_setup_end(xcb_setup_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_client_message_data_next(xcb_client_message_data_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_client_message_data_end(xcb_client_message_data_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_create_window_value_list_serialize(void** _buffer, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_create_window_value_list_t *")] xcb_create_window_value_list_t* _aux);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_create_window_value_list_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint value_mask, xcb_create_window_value_list_t* _aux);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_create_window_value_list_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint value_mask);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_create_window_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_create_window_checked(IntPtr c, [NativeTypeName("uint8_t")] byte depth, [NativeTypeName("xcb_window_t")] uint wid, [NativeTypeName("xcb_window_t")] uint parent, [NativeTypeName("int16_t")] short x, [NativeTypeName("int16_t")] short y, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height, [NativeTypeName("uint16_t")] ushort border_width, [NativeTypeName("uint16_t")] ushort _class, [NativeTypeName("xcb_visualid_t")] uint visual, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const void *")] void* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_create_window(IntPtr c, [NativeTypeName("uint8_t")] byte depth, [NativeTypeName("xcb_window_t")] uint wid, [NativeTypeName("xcb_window_t")] uint parent, [NativeTypeName("int16_t")] short x, [NativeTypeName("int16_t")] short y, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height, [NativeTypeName("uint16_t")] ushort border_width, [NativeTypeName("uint16_t")] ushort _class, [NativeTypeName("xcb_visualid_t")] uint visual, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const void *")] void* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_create_window_aux_checked(IntPtr c, [NativeTypeName("uint8_t")] byte depth, [NativeTypeName("xcb_window_t")] uint wid, [NativeTypeName("xcb_window_t")] uint parent, [NativeTypeName("int16_t")] short x, [NativeTypeName("int16_t")] short y, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height, [NativeTypeName("uint16_t")] ushort border_width, [NativeTypeName("uint16_t")] ushort _class, [NativeTypeName("xcb_visualid_t")] uint visual, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_create_window_value_list_t *")] xcb_create_window_value_list_t* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_create_window_aux(IntPtr c, [NativeTypeName("uint8_t")] byte depth, [NativeTypeName("xcb_window_t")] uint wid, [NativeTypeName("xcb_window_t")] uint parent, [NativeTypeName("int16_t")] short x, [NativeTypeName("int16_t")] short y, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height, [NativeTypeName("uint16_t")] ushort border_width, [NativeTypeName("uint16_t")] ushort _class, [NativeTypeName("xcb_visualid_t")] uint visual, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_create_window_value_list_t *")] xcb_create_window_value_list_t* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* xcb_create_window_value_list([NativeTypeName("const xcb_create_window_request_t *")] xcb_create_window_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_change_window_attributes_value_list_serialize(void** _buffer, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_change_window_attributes_value_list_t *")] xcb_change_window_attributes_value_list_t* _aux);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_change_window_attributes_value_list_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint value_mask, xcb_change_window_attributes_value_list_t* _aux);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_change_window_attributes_value_list_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint value_mask);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_change_window_attributes_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_window_attributes_checked(IntPtr c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const void *")] void* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_window_attributes(IntPtr c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const void *")] void* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_window_attributes_aux_checked(IntPtr c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_change_window_attributes_value_list_t *")] xcb_change_window_attributes_value_list_t* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_window_attributes_aux(IntPtr c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_change_window_attributes_value_list_t *")] xcb_change_window_attributes_value_list_t* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* xcb_change_window_attributes_value_list([NativeTypeName("const xcb_change_window_attributes_request_t *")] xcb_change_window_attributes_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_window_attributes_cookie_t xcb_get_window_attributes(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_window_attributes_cookie_t xcb_get_window_attributes_unchecked(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_window_attributes_reply_t* xcb_get_window_attributes_reply(IntPtr c, xcb_get_window_attributes_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_destroy_window_checked(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_destroy_window(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_destroy_subwindows_checked(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_destroy_subwindows(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_save_set_checked(IntPtr c, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_save_set(IntPtr c, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_reparent_window_checked(IntPtr c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_window_t")] uint parent, [NativeTypeName("int16_t")] short x, [NativeTypeName("int16_t")] short y);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_reparent_window(IntPtr c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_window_t")] uint parent, [NativeTypeName("int16_t")] short x, [NativeTypeName("int16_t")] short y);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_map_window_checked(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_map_window(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_map_subwindows_checked(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_map_subwindows(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_unmap_window_checked(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_unmap_window(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_unmap_subwindows_checked(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_unmap_subwindows(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_configure_window_value_list_serialize(void** _buffer, [NativeTypeName("uint16_t")] ushort value_mask, [NativeTypeName("const xcb_configure_window_value_list_t *")] xcb_configure_window_value_list_t* _aux);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_configure_window_value_list_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint16_t")] ushort value_mask, xcb_configure_window_value_list_t* _aux);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_configure_window_value_list_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint16_t")] ushort value_mask);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_configure_window_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_configure_window_checked(IntPtr c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint16_t")] ushort value_mask, [NativeTypeName("const void *")] void* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_configure_window(IntPtr c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint16_t")] ushort value_mask, [NativeTypeName("const void *")] void* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_configure_window_aux_checked(IntPtr c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint16_t")] ushort value_mask, [NativeTypeName("const xcb_configure_window_value_list_t *")] xcb_configure_window_value_list_t* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_configure_window_aux(IntPtr c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint16_t")] ushort value_mask, [NativeTypeName("const xcb_configure_window_value_list_t *")] xcb_configure_window_value_list_t* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* xcb_configure_window_value_list([NativeTypeName("const xcb_configure_window_request_t *")] xcb_configure_window_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_circulate_window_checked(IntPtr c, [NativeTypeName("uint8_t")] byte direction, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_circulate_window(IntPtr c, [NativeTypeName("uint8_t")] byte direction, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_geometry_cookie_t xcb_get_geometry(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint drawable);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_geometry_cookie_t xcb_get_geometry_unchecked(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint drawable);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_geometry_reply_t* xcb_get_geometry_reply(IntPtr c, xcb_get_geometry_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_query_tree_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_tree_cookie_t xcb_query_tree(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_tree_cookie_t xcb_query_tree_unchecked(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("xcb_window_t *")]
        public static extern uint* xcb_query_tree_children([NativeTypeName("const xcb_query_tree_reply_t *")] xcb_query_tree_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_query_tree_children_length([NativeTypeName("const xcb_query_tree_reply_t *")] xcb_query_tree_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_query_tree_children_end([NativeTypeName("const xcb_query_tree_reply_t *")] xcb_query_tree_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_tree_reply_t* xcb_query_tree_reply(IntPtr c, xcb_query_tree_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_intern_atom_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_intern_atom_cookie_t xcb_intern_atom(IntPtr c, [NativeTypeName("uint8_t")] byte only_if_exists, [NativeTypeName("uint16_t")] ushort name_len, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_intern_atom_cookie_t xcb_intern_atom_unchecked(IntPtr c, [NativeTypeName("uint8_t")] byte only_if_exists, [NativeTypeName("uint16_t")] ushort name_len, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_intern_atom_reply_t* xcb_intern_atom_reply(IntPtr c, xcb_intern_atom_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_get_atom_name_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_atom_name_cookie_t xcb_get_atom_name(IntPtr c, [NativeTypeName("xcb_atom_t")] uint atom);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_atom_name_cookie_t xcb_get_atom_name_unchecked(IntPtr c, [NativeTypeName("xcb_atom_t")] uint atom);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* xcb_get_atom_name_name([NativeTypeName("const xcb_get_atom_name_reply_t *")] xcb_get_atom_name_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_get_atom_name_name_length([NativeTypeName("const xcb_get_atom_name_reply_t *")] xcb_get_atom_name_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_get_atom_name_name_end([NativeTypeName("const xcb_get_atom_name_reply_t *")] xcb_get_atom_name_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_atom_name_reply_t* xcb_get_atom_name_reply(IntPtr c, xcb_get_atom_name_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_change_property_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_property_checked(IntPtr c, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("uint32_t")] uint data_len, [NativeTypeName("const void *")] void* data);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_property(IntPtr c, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("uint32_t")] uint data_len, [NativeTypeName("const void *")] void* data);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* xcb_change_property_data([NativeTypeName("const xcb_change_property_request_t *")] xcb_change_property_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_change_property_data_length([NativeTypeName("const xcb_change_property_request_t *")] xcb_change_property_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_change_property_data_end([NativeTypeName("const xcb_change_property_request_t *")] xcb_change_property_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_delete_property_checked(IntPtr c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_atom_t")] uint property);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_delete_property(IntPtr c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_atom_t")] uint property);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_get_property_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_property_cookie_t xcb_get_property(IntPtr c, [NativeTypeName("uint8_t")] byte _delete, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint32_t")] uint long_offset, [NativeTypeName("uint32_t")] uint long_length);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_property_cookie_t xcb_get_property_unchecked(IntPtr c, [NativeTypeName("uint8_t")] byte _delete, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_atom_t")] uint type, [NativeTypeName("uint32_t")] uint long_offset, [NativeTypeName("uint32_t")] uint long_length);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* xcb_get_property_value([NativeTypeName("const xcb_get_property_reply_t *")] xcb_get_property_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_get_property_value_length([NativeTypeName("const xcb_get_property_reply_t *")] xcb_get_property_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_get_property_value_end([NativeTypeName("const xcb_get_property_reply_t *")] xcb_get_property_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_property_reply_t* xcb_get_property_reply(IntPtr c, xcb_get_property_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_list_properties_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_list_properties_cookie_t xcb_list_properties(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_list_properties_cookie_t xcb_list_properties_unchecked(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("xcb_atom_t *")]
        public static extern uint* xcb_list_properties_atoms([NativeTypeName("const xcb_list_properties_reply_t *")] xcb_list_properties_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_list_properties_atoms_length([NativeTypeName("const xcb_list_properties_reply_t *")] xcb_list_properties_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_list_properties_atoms_end([NativeTypeName("const xcb_list_properties_reply_t *")] xcb_list_properties_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_list_properties_reply_t* xcb_list_properties_reply(IntPtr c, xcb_list_properties_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_set_selection_owner_checked(IntPtr c, [NativeTypeName("xcb_window_t")] uint owner, [NativeTypeName("xcb_atom_t")] uint selection, [NativeTypeName("xcb_timestamp_t")] uint time);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_set_selection_owner(IntPtr c, [NativeTypeName("xcb_window_t")] uint owner, [NativeTypeName("xcb_atom_t")] uint selection, [NativeTypeName("xcb_timestamp_t")] uint time);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_selection_owner_cookie_t xcb_get_selection_owner(IntPtr c, [NativeTypeName("xcb_atom_t")] uint selection);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_selection_owner_cookie_t xcb_get_selection_owner_unchecked(IntPtr c, [NativeTypeName("xcb_atom_t")] uint selection);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_selection_owner_reply_t* xcb_get_selection_owner_reply(IntPtr c, xcb_get_selection_owner_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_convert_selection_checked(IntPtr c, [NativeTypeName("xcb_window_t")] uint requestor, [NativeTypeName("xcb_atom_t")] uint selection, [NativeTypeName("xcb_atom_t")] uint target, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_timestamp_t")] uint time);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_convert_selection(IntPtr c, [NativeTypeName("xcb_window_t")] uint requestor, [NativeTypeName("xcb_atom_t")] uint selection, [NativeTypeName("xcb_atom_t")] uint target, [NativeTypeName("xcb_atom_t")] uint property, [NativeTypeName("xcb_timestamp_t")] uint time);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_send_event_checked(IntPtr c, [NativeTypeName("uint8_t")] byte propagate, [NativeTypeName("xcb_window_t")] uint destination, [NativeTypeName("uint32_t")] uint event_mask, [NativeTypeName("const char *")] sbyte* @event);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_send_event(IntPtr c, [NativeTypeName("uint8_t")] byte propagate, [NativeTypeName("xcb_window_t")] uint destination, [NativeTypeName("uint32_t")] uint event_mask, [NativeTypeName("const char *")] sbyte* @event);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_grab_pointer_cookie_t xcb_grab_pointer(IntPtr c, [NativeTypeName("uint8_t")] byte owner_events, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("uint16_t")] ushort event_mask, [NativeTypeName("uint8_t")] byte pointer_mode, [NativeTypeName("uint8_t")] byte keyboard_mode, [NativeTypeName("xcb_window_t")] uint confine_to, [NativeTypeName("xcb_cursor_t")] uint cursor, [NativeTypeName("xcb_timestamp_t")] uint time);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_grab_pointer_cookie_t xcb_grab_pointer_unchecked(IntPtr c, [NativeTypeName("uint8_t")] byte owner_events, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("uint16_t")] ushort event_mask, [NativeTypeName("uint8_t")] byte pointer_mode, [NativeTypeName("uint8_t")] byte keyboard_mode, [NativeTypeName("xcb_window_t")] uint confine_to, [NativeTypeName("xcb_cursor_t")] uint cursor, [NativeTypeName("xcb_timestamp_t")] uint time);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_grab_pointer_reply_t* xcb_grab_pointer_reply(IntPtr c, xcb_grab_pointer_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_ungrab_pointer_checked(IntPtr c, [NativeTypeName("xcb_timestamp_t")] uint time);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_ungrab_pointer(IntPtr c, [NativeTypeName("xcb_timestamp_t")] uint time);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_grab_button_checked(IntPtr c, [NativeTypeName("uint8_t")] byte owner_events, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("uint16_t")] ushort event_mask, [NativeTypeName("uint8_t")] byte pointer_mode, [NativeTypeName("uint8_t")] byte keyboard_mode, [NativeTypeName("xcb_window_t")] uint confine_to, [NativeTypeName("xcb_cursor_t")] uint cursor, [NativeTypeName("uint8_t")] byte button, [NativeTypeName("uint16_t")] ushort modifiers);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_grab_button(IntPtr c, [NativeTypeName("uint8_t")] byte owner_events, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("uint16_t")] ushort event_mask, [NativeTypeName("uint8_t")] byte pointer_mode, [NativeTypeName("uint8_t")] byte keyboard_mode, [NativeTypeName("xcb_window_t")] uint confine_to, [NativeTypeName("xcb_cursor_t")] uint cursor, [NativeTypeName("uint8_t")] byte button, [NativeTypeName("uint16_t")] ushort modifiers);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_ungrab_button_checked(IntPtr c, [NativeTypeName("uint8_t")] byte button, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("uint16_t")] ushort modifiers);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_ungrab_button(IntPtr c, [NativeTypeName("uint8_t")] byte button, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("uint16_t")] ushort modifiers);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_active_pointer_grab_checked(IntPtr c, [NativeTypeName("xcb_cursor_t")] uint cursor, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("uint16_t")] ushort event_mask);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_active_pointer_grab(IntPtr c, [NativeTypeName("xcb_cursor_t")] uint cursor, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("uint16_t")] ushort event_mask);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_grab_keyboard_cookie_t xcb_grab_keyboard(IntPtr c, [NativeTypeName("uint8_t")] byte owner_events, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("uint8_t")] byte pointer_mode, [NativeTypeName("uint8_t")] byte keyboard_mode);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_grab_keyboard_cookie_t xcb_grab_keyboard_unchecked(IntPtr c, [NativeTypeName("uint8_t")] byte owner_events, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("xcb_timestamp_t")] uint time, [NativeTypeName("uint8_t")] byte pointer_mode, [NativeTypeName("uint8_t")] byte keyboard_mode);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_grab_keyboard_reply_t* xcb_grab_keyboard_reply(IntPtr c, xcb_grab_keyboard_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_ungrab_keyboard_checked(IntPtr c, [NativeTypeName("xcb_timestamp_t")] uint time);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_ungrab_keyboard(IntPtr c, [NativeTypeName("xcb_timestamp_t")] uint time);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_grab_key_checked(IntPtr c, [NativeTypeName("uint8_t")] byte owner_events, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("uint16_t")] ushort modifiers, [NativeTypeName("xcb_keycode_t")] byte key, [NativeTypeName("uint8_t")] byte pointer_mode, [NativeTypeName("uint8_t")] byte keyboard_mode);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_grab_key(IntPtr c, [NativeTypeName("uint8_t")] byte owner_events, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("uint16_t")] ushort modifiers, [NativeTypeName("xcb_keycode_t")] byte key, [NativeTypeName("uint8_t")] byte pointer_mode, [NativeTypeName("uint8_t")] byte keyboard_mode);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_ungrab_key_checked(IntPtr c, [NativeTypeName("xcb_keycode_t")] byte key, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("uint16_t")] ushort modifiers);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_ungrab_key(IntPtr c, [NativeTypeName("xcb_keycode_t")] byte key, [NativeTypeName("xcb_window_t")] uint grab_window, [NativeTypeName("uint16_t")] ushort modifiers);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_allow_events_checked(IntPtr c, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("xcb_timestamp_t")] uint time);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_allow_events(IntPtr c, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("xcb_timestamp_t")] uint time);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_grab_server_checked(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_grab_server(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_ungrab_server_checked(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_ungrab_server(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_pointer_cookie_t xcb_query_pointer(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_pointer_cookie_t xcb_query_pointer_unchecked(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_pointer_reply_t* xcb_query_pointer_reply(IntPtr c, xcb_query_pointer_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_timecoord_next(xcb_timecoord_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_timecoord_end(xcb_timecoord_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_get_motion_events_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_motion_events_cookie_t xcb_get_motion_events(IntPtr c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_timestamp_t")] uint start, [NativeTypeName("xcb_timestamp_t")] uint stop);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_motion_events_cookie_t xcb_get_motion_events_unchecked(IntPtr c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_timestamp_t")] uint start, [NativeTypeName("xcb_timestamp_t")] uint stop);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_timecoord_t* xcb_get_motion_events_events([NativeTypeName("const xcb_get_motion_events_reply_t *")] xcb_get_motion_events_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_get_motion_events_events_length([NativeTypeName("const xcb_get_motion_events_reply_t *")] xcb_get_motion_events_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_timecoord_iterator_t xcb_get_motion_events_events_iterator([NativeTypeName("const xcb_get_motion_events_reply_t *")] xcb_get_motion_events_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_motion_events_reply_t* xcb_get_motion_events_reply(IntPtr c, xcb_get_motion_events_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_translate_coordinates_cookie_t xcb_translate_coordinates(IntPtr c, [NativeTypeName("xcb_window_t")] uint src_window, [NativeTypeName("xcb_window_t")] uint dst_window, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_translate_coordinates_cookie_t xcb_translate_coordinates_unchecked(IntPtr c, [NativeTypeName("xcb_window_t")] uint src_window, [NativeTypeName("xcb_window_t")] uint dst_window, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_translate_coordinates_reply_t* xcb_translate_coordinates_reply(IntPtr c, xcb_translate_coordinates_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_warp_pointer_checked(IntPtr c, [NativeTypeName("xcb_window_t")] uint src_window, [NativeTypeName("xcb_window_t")] uint dst_window, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("uint16_t")] ushort src_width, [NativeTypeName("uint16_t")] ushort src_height, [NativeTypeName("int16_t")] short dst_x, [NativeTypeName("int16_t")] short dst_y);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_warp_pointer(IntPtr c, [NativeTypeName("xcb_window_t")] uint src_window, [NativeTypeName("xcb_window_t")] uint dst_window, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("uint16_t")] ushort src_width, [NativeTypeName("uint16_t")] ushort src_height, [NativeTypeName("int16_t")] short dst_x, [NativeTypeName("int16_t")] short dst_y);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_set_input_focus_checked(IntPtr c, [NativeTypeName("uint8_t")] byte revert_to, [NativeTypeName("xcb_window_t")] uint focus, [NativeTypeName("xcb_timestamp_t")] uint time);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_set_input_focus(IntPtr c, [NativeTypeName("uint8_t")] byte revert_to, [NativeTypeName("xcb_window_t")] uint focus, [NativeTypeName("xcb_timestamp_t")] uint time);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_input_focus_cookie_t xcb_get_input_focus(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_input_focus_cookie_t xcb_get_input_focus_unchecked(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_input_focus_reply_t* xcb_get_input_focus_reply(IntPtr c, xcb_get_input_focus_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_keymap_cookie_t xcb_query_keymap(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_keymap_cookie_t xcb_query_keymap_unchecked(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_keymap_reply_t* xcb_query_keymap_reply(IntPtr c, xcb_query_keymap_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_open_font_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_open_font_checked(IntPtr c, [NativeTypeName("xcb_font_t")] uint fid, [NativeTypeName("uint16_t")] ushort name_len, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_open_font(IntPtr c, [NativeTypeName("xcb_font_t")] uint fid, [NativeTypeName("uint16_t")] ushort name_len, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* xcb_open_font_name([NativeTypeName("const xcb_open_font_request_t *")] xcb_open_font_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_open_font_name_length([NativeTypeName("const xcb_open_font_request_t *")] xcb_open_font_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_open_font_name_end([NativeTypeName("const xcb_open_font_request_t *")] xcb_open_font_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_close_font_checked(IntPtr c, [NativeTypeName("xcb_font_t")] uint font);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_close_font(IntPtr c, [NativeTypeName("xcb_font_t")] uint font);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_fontprop_next(xcb_fontprop_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_fontprop_end(xcb_fontprop_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_charinfo_next(xcb_charinfo_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_charinfo_end(xcb_charinfo_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_query_font_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_font_cookie_t xcb_query_font(IntPtr c, [NativeTypeName("xcb_fontable_t")] uint font);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_font_cookie_t xcb_query_font_unchecked(IntPtr c, [NativeTypeName("xcb_fontable_t")] uint font);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_fontprop_t* xcb_query_font_properties([NativeTypeName("const xcb_query_font_reply_t *")] xcb_query_font_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_query_font_properties_length([NativeTypeName("const xcb_query_font_reply_t *")] xcb_query_font_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_fontprop_iterator_t xcb_query_font_properties_iterator([NativeTypeName("const xcb_query_font_reply_t *")] xcb_query_font_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_charinfo_t* xcb_query_font_char_infos([NativeTypeName("const xcb_query_font_reply_t *")] xcb_query_font_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_query_font_char_infos_length([NativeTypeName("const xcb_query_font_reply_t *")] xcb_query_font_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_charinfo_iterator_t xcb_query_font_char_infos_iterator([NativeTypeName("const xcb_query_font_reply_t *")] xcb_query_font_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_font_reply_t* xcb_query_font_reply(IntPtr c, xcb_query_font_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_query_text_extents_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint string_len);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_text_extents_cookie_t xcb_query_text_extents(IntPtr c, [NativeTypeName("xcb_fontable_t")] uint font, [NativeTypeName("uint32_t")] uint string_len, [NativeTypeName("const xcb_char2b_t *")] xcb_char2b_t* @string);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_text_extents_cookie_t xcb_query_text_extents_unchecked(IntPtr c, [NativeTypeName("xcb_fontable_t")] uint font, [NativeTypeName("uint32_t")] uint string_len, [NativeTypeName("const xcb_char2b_t *")] xcb_char2b_t* @string);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_text_extents_reply_t* xcb_query_text_extents_reply(IntPtr c, xcb_query_text_extents_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_str_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* xcb_str_name([NativeTypeName("const xcb_str_t *")] xcb_str_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_str_name_length([NativeTypeName("const xcb_str_t *")] xcb_str_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_str_name_end([NativeTypeName("const xcb_str_t *")] xcb_str_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_str_next(xcb_str_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_str_end(xcb_str_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_list_fonts_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_list_fonts_cookie_t xcb_list_fonts(IntPtr c, [NativeTypeName("uint16_t")] ushort max_names, [NativeTypeName("uint16_t")] ushort pattern_len, [NativeTypeName("const char *")] sbyte* pattern);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_list_fonts_cookie_t xcb_list_fonts_unchecked(IntPtr c, [NativeTypeName("uint16_t")] ushort max_names, [NativeTypeName("uint16_t")] ushort pattern_len, [NativeTypeName("const char *")] sbyte* pattern);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_list_fonts_names_length([NativeTypeName("const xcb_list_fonts_reply_t *")] xcb_list_fonts_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_str_iterator_t xcb_list_fonts_names_iterator([NativeTypeName("const xcb_list_fonts_reply_t *")] xcb_list_fonts_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_list_fonts_reply_t* xcb_list_fonts_reply(IntPtr c, xcb_list_fonts_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_list_fonts_with_info_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_list_fonts_with_info_cookie_t xcb_list_fonts_with_info(IntPtr c, [NativeTypeName("uint16_t")] ushort max_names, [NativeTypeName("uint16_t")] ushort pattern_len, [NativeTypeName("const char *")] sbyte* pattern);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_list_fonts_with_info_cookie_t xcb_list_fonts_with_info_unchecked(IntPtr c, [NativeTypeName("uint16_t")] ushort max_names, [NativeTypeName("uint16_t")] ushort pattern_len, [NativeTypeName("const char *")] sbyte* pattern);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_fontprop_t* xcb_list_fonts_with_info_properties([NativeTypeName("const xcb_list_fonts_with_info_reply_t *")] xcb_list_fonts_with_info_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_list_fonts_with_info_properties_length([NativeTypeName("const xcb_list_fonts_with_info_reply_t *")] xcb_list_fonts_with_info_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_fontprop_iterator_t xcb_list_fonts_with_info_properties_iterator([NativeTypeName("const xcb_list_fonts_with_info_reply_t *")] xcb_list_fonts_with_info_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* xcb_list_fonts_with_info_name([NativeTypeName("const xcb_list_fonts_with_info_reply_t *")] xcb_list_fonts_with_info_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_list_fonts_with_info_name_length([NativeTypeName("const xcb_list_fonts_with_info_reply_t *")] xcb_list_fonts_with_info_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_list_fonts_with_info_name_end([NativeTypeName("const xcb_list_fonts_with_info_reply_t *")] xcb_list_fonts_with_info_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_list_fonts_with_info_reply_t* xcb_list_fonts_with_info_reply(IntPtr c, xcb_list_fonts_with_info_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_set_font_path_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_set_font_path_checked(IntPtr c, [NativeTypeName("uint16_t")] ushort font_qty, [NativeTypeName("const xcb_str_t *")] xcb_str_t* font);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_set_font_path(IntPtr c, [NativeTypeName("uint16_t")] ushort font_qty, [NativeTypeName("const xcb_str_t *")] xcb_str_t* font);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_set_font_path_font_length([NativeTypeName("const xcb_set_font_path_request_t *")] xcb_set_font_path_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_str_iterator_t xcb_set_font_path_font_iterator([NativeTypeName("const xcb_set_font_path_request_t *")] xcb_set_font_path_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_get_font_path_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_font_path_cookie_t xcb_get_font_path(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_font_path_cookie_t xcb_get_font_path_unchecked(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_get_font_path_path_length([NativeTypeName("const xcb_get_font_path_reply_t *")] xcb_get_font_path_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_str_iterator_t xcb_get_font_path_path_iterator([NativeTypeName("const xcb_get_font_path_reply_t *")] xcb_get_font_path_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_font_path_reply_t* xcb_get_font_path_reply(IntPtr c, xcb_get_font_path_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_create_pixmap_checked(IntPtr c, [NativeTypeName("uint8_t")] byte depth, [NativeTypeName("xcb_pixmap_t")] uint pid, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_create_pixmap(IntPtr c, [NativeTypeName("uint8_t")] byte depth, [NativeTypeName("xcb_pixmap_t")] uint pid, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_free_pixmap_checked(IntPtr c, [NativeTypeName("xcb_pixmap_t")] uint pixmap);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_free_pixmap(IntPtr c, [NativeTypeName("xcb_pixmap_t")] uint pixmap);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_create_gc_value_list_serialize(void** _buffer, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_create_gc_value_list_t *")] xcb_create_gc_value_list_t* _aux);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_create_gc_value_list_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint value_mask, xcb_create_gc_value_list_t* _aux);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_create_gc_value_list_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint value_mask);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_create_gc_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_create_gc_checked(IntPtr c, [NativeTypeName("xcb_gcontext_t")] uint cid, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const void *")] void* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_create_gc(IntPtr c, [NativeTypeName("xcb_gcontext_t")] uint cid, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const void *")] void* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_create_gc_aux_checked(IntPtr c, [NativeTypeName("xcb_gcontext_t")] uint cid, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_create_gc_value_list_t *")] xcb_create_gc_value_list_t* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_create_gc_aux(IntPtr c, [NativeTypeName("xcb_gcontext_t")] uint cid, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_create_gc_value_list_t *")] xcb_create_gc_value_list_t* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* xcb_create_gc_value_list([NativeTypeName("const xcb_create_gc_request_t *")] xcb_create_gc_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_change_gc_value_list_serialize(void** _buffer, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_change_gc_value_list_t *")] xcb_change_gc_value_list_t* _aux);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_change_gc_value_list_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint value_mask, xcb_change_gc_value_list_t* _aux);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_change_gc_value_list_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint value_mask);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_change_gc_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_gc_checked(IntPtr c, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const void *")] void* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_gc(IntPtr c, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const void *")] void* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_gc_aux_checked(IntPtr c, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_change_gc_value_list_t *")] xcb_change_gc_value_list_t* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_gc_aux(IntPtr c, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_change_gc_value_list_t *")] xcb_change_gc_value_list_t* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* xcb_change_gc_value_list([NativeTypeName("const xcb_change_gc_request_t *")] xcb_change_gc_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_copy_gc_checked(IntPtr c, [NativeTypeName("xcb_gcontext_t")] uint src_gc, [NativeTypeName("xcb_gcontext_t")] uint dst_gc, [NativeTypeName("uint32_t")] uint value_mask);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_copy_gc(IntPtr c, [NativeTypeName("xcb_gcontext_t")] uint src_gc, [NativeTypeName("xcb_gcontext_t")] uint dst_gc, [NativeTypeName("uint32_t")] uint value_mask);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_set_dashes_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_set_dashes_checked(IntPtr c, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint16_t")] ushort dash_offset, [NativeTypeName("uint16_t")] ushort dashes_len, [NativeTypeName("const uint8_t *")] byte* dashes);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_set_dashes(IntPtr c, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint16_t")] ushort dash_offset, [NativeTypeName("uint16_t")] ushort dashes_len, [NativeTypeName("const uint8_t *")] byte* dashes);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t *")]
        public static extern byte* xcb_set_dashes_dashes([NativeTypeName("const xcb_set_dashes_request_t *")] xcb_set_dashes_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_set_dashes_dashes_length([NativeTypeName("const xcb_set_dashes_request_t *")] xcb_set_dashes_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_set_dashes_dashes_end([NativeTypeName("const xcb_set_dashes_request_t *")] xcb_set_dashes_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_set_clip_rectangles_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint rectangles_len);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_set_clip_rectangles_checked(IntPtr c, [NativeTypeName("uint8_t")] byte ordering, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("int16_t")] short clip_x_origin, [NativeTypeName("int16_t")] short clip_y_origin, [NativeTypeName("uint32_t")] uint rectangles_len, [NativeTypeName("const xcb_rectangle_t *")] xcb_rectangle_t* rectangles);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_set_clip_rectangles(IntPtr c, [NativeTypeName("uint8_t")] byte ordering, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("int16_t")] short clip_x_origin, [NativeTypeName("int16_t")] short clip_y_origin, [NativeTypeName("uint32_t")] uint rectangles_len, [NativeTypeName("const xcb_rectangle_t *")] xcb_rectangle_t* rectangles);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_rectangle_t* xcb_set_clip_rectangles_rectangles([NativeTypeName("const xcb_set_clip_rectangles_request_t *")] xcb_set_clip_rectangles_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_set_clip_rectangles_rectangles_length([NativeTypeName("const xcb_set_clip_rectangles_request_t *")] xcb_set_clip_rectangles_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_rectangle_iterator_t xcb_set_clip_rectangles_rectangles_iterator([NativeTypeName("const xcb_set_clip_rectangles_request_t *")] xcb_set_clip_rectangles_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_free_gc_checked(IntPtr c, [NativeTypeName("xcb_gcontext_t")] uint gc);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_free_gc(IntPtr c, [NativeTypeName("xcb_gcontext_t")] uint gc);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_clear_area_checked(IntPtr c, [NativeTypeName("uint8_t")] byte exposures, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("int16_t")] short x, [NativeTypeName("int16_t")] short y, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_clear_area(IntPtr c, [NativeTypeName("uint8_t")] byte exposures, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("int16_t")] short x, [NativeTypeName("int16_t")] short y, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_copy_area_checked(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint src_drawable, [NativeTypeName("xcb_drawable_t")] uint dst_drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("int16_t")] short dst_x, [NativeTypeName("int16_t")] short dst_y, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_copy_area(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint src_drawable, [NativeTypeName("xcb_drawable_t")] uint dst_drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("int16_t")] short dst_x, [NativeTypeName("int16_t")] short dst_y, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_copy_plane_checked(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint src_drawable, [NativeTypeName("xcb_drawable_t")] uint dst_drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("int16_t")] short dst_x, [NativeTypeName("int16_t")] short dst_y, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height, [NativeTypeName("uint32_t")] uint bit_plane);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_copy_plane(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint src_drawable, [NativeTypeName("xcb_drawable_t")] uint dst_drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("int16_t")] short src_x, [NativeTypeName("int16_t")] short src_y, [NativeTypeName("int16_t")] short dst_x, [NativeTypeName("int16_t")] short dst_y, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height, [NativeTypeName("uint32_t")] uint bit_plane);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_poly_point_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint points_len);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_poly_point_checked(IntPtr c, [NativeTypeName("uint8_t")] byte coordinate_mode, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint32_t")] uint points_len, [NativeTypeName("const xcb_point_t *")] xcb_point_t* points);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_poly_point(IntPtr c, [NativeTypeName("uint8_t")] byte coordinate_mode, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint32_t")] uint points_len, [NativeTypeName("const xcb_point_t *")] xcb_point_t* points);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_point_t* xcb_poly_point_points([NativeTypeName("const xcb_poly_point_request_t *")] xcb_poly_point_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_poly_point_points_length([NativeTypeName("const xcb_poly_point_request_t *")] xcb_poly_point_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_point_iterator_t xcb_poly_point_points_iterator([NativeTypeName("const xcb_poly_point_request_t *")] xcb_poly_point_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_poly_line_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint points_len);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_poly_line_checked(IntPtr c, [NativeTypeName("uint8_t")] byte coordinate_mode, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint32_t")] uint points_len, [NativeTypeName("const xcb_point_t *")] xcb_point_t* points);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_poly_line(IntPtr c, [NativeTypeName("uint8_t")] byte coordinate_mode, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint32_t")] uint points_len, [NativeTypeName("const xcb_point_t *")] xcb_point_t* points);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_point_t* xcb_poly_line_points([NativeTypeName("const xcb_poly_line_request_t *")] xcb_poly_line_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_poly_line_points_length([NativeTypeName("const xcb_poly_line_request_t *")] xcb_poly_line_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_point_iterator_t xcb_poly_line_points_iterator([NativeTypeName("const xcb_poly_line_request_t *")] xcb_poly_line_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_segment_next(xcb_segment_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_segment_end(xcb_segment_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_poly_segment_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint segments_len);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_poly_segment_checked(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint32_t")] uint segments_len, [NativeTypeName("const xcb_segment_t *")] xcb_segment_t* segments);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_poly_segment(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint32_t")] uint segments_len, [NativeTypeName("const xcb_segment_t *")] xcb_segment_t* segments);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_segment_t* xcb_poly_segment_segments([NativeTypeName("const xcb_poly_segment_request_t *")] xcb_poly_segment_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_poly_segment_segments_length([NativeTypeName("const xcb_poly_segment_request_t *")] xcb_poly_segment_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_segment_iterator_t xcb_poly_segment_segments_iterator([NativeTypeName("const xcb_poly_segment_request_t *")] xcb_poly_segment_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_poly_rectangle_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint rectangles_len);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_poly_rectangle_checked(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint32_t")] uint rectangles_len, [NativeTypeName("const xcb_rectangle_t *")] xcb_rectangle_t* rectangles);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_poly_rectangle(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint32_t")] uint rectangles_len, [NativeTypeName("const xcb_rectangle_t *")] xcb_rectangle_t* rectangles);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_rectangle_t* xcb_poly_rectangle_rectangles([NativeTypeName("const xcb_poly_rectangle_request_t *")] xcb_poly_rectangle_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_poly_rectangle_rectangles_length([NativeTypeName("const xcb_poly_rectangle_request_t *")] xcb_poly_rectangle_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_rectangle_iterator_t xcb_poly_rectangle_rectangles_iterator([NativeTypeName("const xcb_poly_rectangle_request_t *")] xcb_poly_rectangle_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_poly_arc_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint arcs_len);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_poly_arc_checked(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint32_t")] uint arcs_len, [NativeTypeName("const xcb_arc_t *")] xcb_arc_t* arcs);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_poly_arc(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint32_t")] uint arcs_len, [NativeTypeName("const xcb_arc_t *")] xcb_arc_t* arcs);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_arc_t* xcb_poly_arc_arcs([NativeTypeName("const xcb_poly_arc_request_t *")] xcb_poly_arc_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_poly_arc_arcs_length([NativeTypeName("const xcb_poly_arc_request_t *")] xcb_poly_arc_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_arc_iterator_t xcb_poly_arc_arcs_iterator([NativeTypeName("const xcb_poly_arc_request_t *")] xcb_poly_arc_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_fill_poly_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint points_len);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_fill_poly_checked(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint8_t")] byte shape, [NativeTypeName("uint8_t")] byte coordinate_mode, [NativeTypeName("uint32_t")] uint points_len, [NativeTypeName("const xcb_point_t *")] xcb_point_t* points);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_fill_poly(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint8_t")] byte shape, [NativeTypeName("uint8_t")] byte coordinate_mode, [NativeTypeName("uint32_t")] uint points_len, [NativeTypeName("const xcb_point_t *")] xcb_point_t* points);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_point_t* xcb_fill_poly_points([NativeTypeName("const xcb_fill_poly_request_t *")] xcb_fill_poly_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_fill_poly_points_length([NativeTypeName("const xcb_fill_poly_request_t *")] xcb_fill_poly_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_point_iterator_t xcb_fill_poly_points_iterator([NativeTypeName("const xcb_fill_poly_request_t *")] xcb_fill_poly_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_poly_fill_rectangle_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint rectangles_len);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_poly_fill_rectangle_checked(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint32_t")] uint rectangles_len, [NativeTypeName("const xcb_rectangle_t *")] xcb_rectangle_t* rectangles);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_poly_fill_rectangle(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint32_t")] uint rectangles_len, [NativeTypeName("const xcb_rectangle_t *")] xcb_rectangle_t* rectangles);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_rectangle_t* xcb_poly_fill_rectangle_rectangles([NativeTypeName("const xcb_poly_fill_rectangle_request_t *")] xcb_poly_fill_rectangle_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_poly_fill_rectangle_rectangles_length([NativeTypeName("const xcb_poly_fill_rectangle_request_t *")] xcb_poly_fill_rectangle_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_rectangle_iterator_t xcb_poly_fill_rectangle_rectangles_iterator([NativeTypeName("const xcb_poly_fill_rectangle_request_t *")] xcb_poly_fill_rectangle_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_poly_fill_arc_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint arcs_len);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_poly_fill_arc_checked(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint32_t")] uint arcs_len, [NativeTypeName("const xcb_arc_t *")] xcb_arc_t* arcs);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_poly_fill_arc(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint32_t")] uint arcs_len, [NativeTypeName("const xcb_arc_t *")] xcb_arc_t* arcs);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_arc_t* xcb_poly_fill_arc_arcs([NativeTypeName("const xcb_poly_fill_arc_request_t *")] xcb_poly_fill_arc_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_poly_fill_arc_arcs_length([NativeTypeName("const xcb_poly_fill_arc_request_t *")] xcb_poly_fill_arc_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_arc_iterator_t xcb_poly_fill_arc_arcs_iterator([NativeTypeName("const xcb_poly_fill_arc_request_t *")] xcb_poly_fill_arc_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_put_image_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint data_len);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_put_image_checked(IntPtr c, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height, [NativeTypeName("int16_t")] short dst_x, [NativeTypeName("int16_t")] short dst_y, [NativeTypeName("uint8_t")] byte left_pad, [NativeTypeName("uint8_t")] byte depth, [NativeTypeName("uint32_t")] uint data_len, [NativeTypeName("const uint8_t *")] byte* data);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_put_image(IntPtr c, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height, [NativeTypeName("int16_t")] short dst_x, [NativeTypeName("int16_t")] short dst_y, [NativeTypeName("uint8_t")] byte left_pad, [NativeTypeName("uint8_t")] byte depth, [NativeTypeName("uint32_t")] uint data_len, [NativeTypeName("const uint8_t *")] byte* data);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t *")]
        public static extern byte* xcb_put_image_data([NativeTypeName("const xcb_put_image_request_t *")] xcb_put_image_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_put_image_data_length([NativeTypeName("const xcb_put_image_request_t *")] xcb_put_image_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_put_image_data_end([NativeTypeName("const xcb_put_image_request_t *")] xcb_put_image_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_get_image_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_image_cookie_t xcb_get_image(IntPtr c, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("int16_t")] short x, [NativeTypeName("int16_t")] short y, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height, [NativeTypeName("uint32_t")] uint plane_mask);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_image_cookie_t xcb_get_image_unchecked(IntPtr c, [NativeTypeName("uint8_t")] byte format, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("int16_t")] short x, [NativeTypeName("int16_t")] short y, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height, [NativeTypeName("uint32_t")] uint plane_mask);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t *")]
        public static extern byte* xcb_get_image_data([NativeTypeName("const xcb_get_image_reply_t *")] xcb_get_image_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_get_image_data_length([NativeTypeName("const xcb_get_image_reply_t *")] xcb_get_image_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_get_image_data_end([NativeTypeName("const xcb_get_image_reply_t *")] xcb_get_image_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_image_reply_t* xcb_get_image_reply(IntPtr c, xcb_get_image_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_poly_text_8_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint items_len);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_poly_text_8_checked(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("int16_t")] short x, [NativeTypeName("int16_t")] short y, [NativeTypeName("uint32_t")] uint items_len, [NativeTypeName("const uint8_t *")] byte* items);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_poly_text_8(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("int16_t")] short x, [NativeTypeName("int16_t")] short y, [NativeTypeName("uint32_t")] uint items_len, [NativeTypeName("const uint8_t *")] byte* items);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t *")]
        public static extern byte* xcb_poly_text_8_items([NativeTypeName("const xcb_poly_text_8_request_t *")] xcb_poly_text_8_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_poly_text_8_items_length([NativeTypeName("const xcb_poly_text_8_request_t *")] xcb_poly_text_8_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_poly_text_8_items_end([NativeTypeName("const xcb_poly_text_8_request_t *")] xcb_poly_text_8_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_poly_text_16_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint items_len);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_poly_text_16_checked(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("int16_t")] short x, [NativeTypeName("int16_t")] short y, [NativeTypeName("uint32_t")] uint items_len, [NativeTypeName("const uint8_t *")] byte* items);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_poly_text_16(IntPtr c, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("int16_t")] short x, [NativeTypeName("int16_t")] short y, [NativeTypeName("uint32_t")] uint items_len, [NativeTypeName("const uint8_t *")] byte* items);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t *")]
        public static extern byte* xcb_poly_text_16_items([NativeTypeName("const xcb_poly_text_16_request_t *")] xcb_poly_text_16_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_poly_text_16_items_length([NativeTypeName("const xcb_poly_text_16_request_t *")] xcb_poly_text_16_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_poly_text_16_items_end([NativeTypeName("const xcb_poly_text_16_request_t *")] xcb_poly_text_16_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_image_text_8_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_image_text_8_checked(IntPtr c, [NativeTypeName("uint8_t")] byte string_len, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("int16_t")] short x, [NativeTypeName("int16_t")] short y, [NativeTypeName("const char *")] sbyte* @string);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_image_text_8(IntPtr c, [NativeTypeName("uint8_t")] byte string_len, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("int16_t")] short x, [NativeTypeName("int16_t")] short y, [NativeTypeName("const char *")] sbyte* @string);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* xcb_image_text_8_string([NativeTypeName("const xcb_image_text_8_request_t *")] xcb_image_text_8_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_image_text_8_string_length([NativeTypeName("const xcb_image_text_8_request_t *")] xcb_image_text_8_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_image_text_8_string_end([NativeTypeName("const xcb_image_text_8_request_t *")] xcb_image_text_8_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_image_text_16_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_image_text_16_checked(IntPtr c, [NativeTypeName("uint8_t")] byte string_len, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("int16_t")] short x, [NativeTypeName("int16_t")] short y, [NativeTypeName("const xcb_char2b_t *")] xcb_char2b_t* @string);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_image_text_16(IntPtr c, [NativeTypeName("uint8_t")] byte string_len, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("xcb_gcontext_t")] uint gc, [NativeTypeName("int16_t")] short x, [NativeTypeName("int16_t")] short y, [NativeTypeName("const xcb_char2b_t *")] xcb_char2b_t* @string);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_char2b_t* xcb_image_text_16_string([NativeTypeName("const xcb_image_text_16_request_t *")] xcb_image_text_16_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_image_text_16_string_length([NativeTypeName("const xcb_image_text_16_request_t *")] xcb_image_text_16_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_char2b_iterator_t xcb_image_text_16_string_iterator([NativeTypeName("const xcb_image_text_16_request_t *")] xcb_image_text_16_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_create_colormap_checked(IntPtr c, [NativeTypeName("uint8_t")] byte alloc, [NativeTypeName("xcb_colormap_t")] uint mid, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_visualid_t")] uint visual);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_create_colormap(IntPtr c, [NativeTypeName("uint8_t")] byte alloc, [NativeTypeName("xcb_colormap_t")] uint mid, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("xcb_visualid_t")] uint visual);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_free_colormap_checked(IntPtr c, [NativeTypeName("xcb_colormap_t")] uint cmap);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_free_colormap(IntPtr c, [NativeTypeName("xcb_colormap_t")] uint cmap);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_copy_colormap_and_free_checked(IntPtr c, [NativeTypeName("xcb_colormap_t")] uint mid, [NativeTypeName("xcb_colormap_t")] uint src_cmap);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_copy_colormap_and_free(IntPtr c, [NativeTypeName("xcb_colormap_t")] uint mid, [NativeTypeName("xcb_colormap_t")] uint src_cmap);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_install_colormap_checked(IntPtr c, [NativeTypeName("xcb_colormap_t")] uint cmap);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_install_colormap(IntPtr c, [NativeTypeName("xcb_colormap_t")] uint cmap);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_uninstall_colormap_checked(IntPtr c, [NativeTypeName("xcb_colormap_t")] uint cmap);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_uninstall_colormap(IntPtr c, [NativeTypeName("xcb_colormap_t")] uint cmap);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_list_installed_colormaps_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_list_installed_colormaps_cookie_t xcb_list_installed_colormaps(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_list_installed_colormaps_cookie_t xcb_list_installed_colormaps_unchecked(IntPtr c, [NativeTypeName("xcb_window_t")] uint window);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("xcb_colormap_t *")]
        public static extern uint* xcb_list_installed_colormaps_cmaps([NativeTypeName("const xcb_list_installed_colormaps_reply_t *")] xcb_list_installed_colormaps_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_list_installed_colormaps_cmaps_length([NativeTypeName("const xcb_list_installed_colormaps_reply_t *")] xcb_list_installed_colormaps_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_list_installed_colormaps_cmaps_end([NativeTypeName("const xcb_list_installed_colormaps_reply_t *")] xcb_list_installed_colormaps_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_list_installed_colormaps_reply_t* xcb_list_installed_colormaps_reply(IntPtr c, xcb_list_installed_colormaps_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_alloc_color_cookie_t xcb_alloc_color(IntPtr c, [NativeTypeName("xcb_colormap_t")] uint cmap, [NativeTypeName("uint16_t")] ushort red, [NativeTypeName("uint16_t")] ushort green, [NativeTypeName("uint16_t")] ushort blue);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_alloc_color_cookie_t xcb_alloc_color_unchecked(IntPtr c, [NativeTypeName("xcb_colormap_t")] uint cmap, [NativeTypeName("uint16_t")] ushort red, [NativeTypeName("uint16_t")] ushort green, [NativeTypeName("uint16_t")] ushort blue);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_alloc_color_reply_t* xcb_alloc_color_reply(IntPtr c, xcb_alloc_color_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_alloc_named_color_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_alloc_named_color_cookie_t xcb_alloc_named_color(IntPtr c, [NativeTypeName("xcb_colormap_t")] uint cmap, [NativeTypeName("uint16_t")] ushort name_len, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_alloc_named_color_cookie_t xcb_alloc_named_color_unchecked(IntPtr c, [NativeTypeName("xcb_colormap_t")] uint cmap, [NativeTypeName("uint16_t")] ushort name_len, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_alloc_named_color_reply_t* xcb_alloc_named_color_reply(IntPtr c, xcb_alloc_named_color_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_alloc_color_cells_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_alloc_color_cells_cookie_t xcb_alloc_color_cells(IntPtr c, [NativeTypeName("uint8_t")] byte contiguous, [NativeTypeName("xcb_colormap_t")] uint cmap, [NativeTypeName("uint16_t")] ushort colors, [NativeTypeName("uint16_t")] ushort planes);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_alloc_color_cells_cookie_t xcb_alloc_color_cells_unchecked(IntPtr c, [NativeTypeName("uint8_t")] byte contiguous, [NativeTypeName("xcb_colormap_t")] uint cmap, [NativeTypeName("uint16_t")] ushort colors, [NativeTypeName("uint16_t")] ushort planes);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t *")]
        public static extern uint* xcb_alloc_color_cells_pixels([NativeTypeName("const xcb_alloc_color_cells_reply_t *")] xcb_alloc_color_cells_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_alloc_color_cells_pixels_length([NativeTypeName("const xcb_alloc_color_cells_reply_t *")] xcb_alloc_color_cells_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_alloc_color_cells_pixels_end([NativeTypeName("const xcb_alloc_color_cells_reply_t *")] xcb_alloc_color_cells_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t *")]
        public static extern uint* xcb_alloc_color_cells_masks([NativeTypeName("const xcb_alloc_color_cells_reply_t *")] xcb_alloc_color_cells_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_alloc_color_cells_masks_length([NativeTypeName("const xcb_alloc_color_cells_reply_t *")] xcb_alloc_color_cells_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_alloc_color_cells_masks_end([NativeTypeName("const xcb_alloc_color_cells_reply_t *")] xcb_alloc_color_cells_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_alloc_color_cells_reply_t* xcb_alloc_color_cells_reply(IntPtr c, xcb_alloc_color_cells_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_alloc_color_planes_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_alloc_color_planes_cookie_t xcb_alloc_color_planes(IntPtr c, [NativeTypeName("uint8_t")] byte contiguous, [NativeTypeName("xcb_colormap_t")] uint cmap, [NativeTypeName("uint16_t")] ushort colors, [NativeTypeName("uint16_t")] ushort reds, [NativeTypeName("uint16_t")] ushort greens, [NativeTypeName("uint16_t")] ushort blues);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_alloc_color_planes_cookie_t xcb_alloc_color_planes_unchecked(IntPtr c, [NativeTypeName("uint8_t")] byte contiguous, [NativeTypeName("xcb_colormap_t")] uint cmap, [NativeTypeName("uint16_t")] ushort colors, [NativeTypeName("uint16_t")] ushort reds, [NativeTypeName("uint16_t")] ushort greens, [NativeTypeName("uint16_t")] ushort blues);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t *")]
        public static extern uint* xcb_alloc_color_planes_pixels([NativeTypeName("const xcb_alloc_color_planes_reply_t *")] xcb_alloc_color_planes_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_alloc_color_planes_pixels_length([NativeTypeName("const xcb_alloc_color_planes_reply_t *")] xcb_alloc_color_planes_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_alloc_color_planes_pixels_end([NativeTypeName("const xcb_alloc_color_planes_reply_t *")] xcb_alloc_color_planes_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_alloc_color_planes_reply_t* xcb_alloc_color_planes_reply(IntPtr c, xcb_alloc_color_planes_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_free_colors_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint pixels_len);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_free_colors_checked(IntPtr c, [NativeTypeName("xcb_colormap_t")] uint cmap, [NativeTypeName("uint32_t")] uint plane_mask, [NativeTypeName("uint32_t")] uint pixels_len, [NativeTypeName("const uint32_t *")] uint* pixels);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_free_colors(IntPtr c, [NativeTypeName("xcb_colormap_t")] uint cmap, [NativeTypeName("uint32_t")] uint plane_mask, [NativeTypeName("uint32_t")] uint pixels_len, [NativeTypeName("const uint32_t *")] uint* pixels);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t *")]
        public static extern uint* xcb_free_colors_pixels([NativeTypeName("const xcb_free_colors_request_t *")] xcb_free_colors_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_free_colors_pixels_length([NativeTypeName("const xcb_free_colors_request_t *")] xcb_free_colors_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_free_colors_pixels_end([NativeTypeName("const xcb_free_colors_request_t *")] xcb_free_colors_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_coloritem_next(xcb_coloritem_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_coloritem_end(xcb_coloritem_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_store_colors_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint items_len);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_store_colors_checked(IntPtr c, [NativeTypeName("xcb_colormap_t")] uint cmap, [NativeTypeName("uint32_t")] uint items_len, [NativeTypeName("const xcb_coloritem_t *")] xcb_coloritem_t* items);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_store_colors(IntPtr c, [NativeTypeName("xcb_colormap_t")] uint cmap, [NativeTypeName("uint32_t")] uint items_len, [NativeTypeName("const xcb_coloritem_t *")] xcb_coloritem_t* items);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_coloritem_t* xcb_store_colors_items([NativeTypeName("const xcb_store_colors_request_t *")] xcb_store_colors_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_store_colors_items_length([NativeTypeName("const xcb_store_colors_request_t *")] xcb_store_colors_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_coloritem_iterator_t xcb_store_colors_items_iterator([NativeTypeName("const xcb_store_colors_request_t *")] xcb_store_colors_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_store_named_color_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_store_named_color_checked(IntPtr c, [NativeTypeName("uint8_t")] byte flags, [NativeTypeName("xcb_colormap_t")] uint cmap, [NativeTypeName("uint32_t")] uint pixel, [NativeTypeName("uint16_t")] ushort name_len, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_store_named_color(IntPtr c, [NativeTypeName("uint8_t")] byte flags, [NativeTypeName("xcb_colormap_t")] uint cmap, [NativeTypeName("uint32_t")] uint pixel, [NativeTypeName("uint16_t")] ushort name_len, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* xcb_store_named_color_name([NativeTypeName("const xcb_store_named_color_request_t *")] xcb_store_named_color_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_store_named_color_name_length([NativeTypeName("const xcb_store_named_color_request_t *")] xcb_store_named_color_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_store_named_color_name_end([NativeTypeName("const xcb_store_named_color_request_t *")] xcb_store_named_color_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_rgb_next(xcb_rgb_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_rgb_end(xcb_rgb_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_query_colors_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint pixels_len);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_colors_cookie_t xcb_query_colors(IntPtr c, [NativeTypeName("xcb_colormap_t")] uint cmap, [NativeTypeName("uint32_t")] uint pixels_len, [NativeTypeName("const uint32_t *")] uint* pixels);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_colors_cookie_t xcb_query_colors_unchecked(IntPtr c, [NativeTypeName("xcb_colormap_t")] uint cmap, [NativeTypeName("uint32_t")] uint pixels_len, [NativeTypeName("const uint32_t *")] uint* pixels);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_rgb_t* xcb_query_colors_colors([NativeTypeName("const xcb_query_colors_reply_t *")] xcb_query_colors_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_query_colors_colors_length([NativeTypeName("const xcb_query_colors_reply_t *")] xcb_query_colors_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_rgb_iterator_t xcb_query_colors_colors_iterator([NativeTypeName("const xcb_query_colors_reply_t *")] xcb_query_colors_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_colors_reply_t* xcb_query_colors_reply(IntPtr c, xcb_query_colors_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_lookup_color_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_lookup_color_cookie_t xcb_lookup_color(IntPtr c, [NativeTypeName("xcb_colormap_t")] uint cmap, [NativeTypeName("uint16_t")] ushort name_len, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_lookup_color_cookie_t xcb_lookup_color_unchecked(IntPtr c, [NativeTypeName("xcb_colormap_t")] uint cmap, [NativeTypeName("uint16_t")] ushort name_len, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_lookup_color_reply_t* xcb_lookup_color_reply(IntPtr c, xcb_lookup_color_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_create_cursor_checked(IntPtr c, [NativeTypeName("xcb_cursor_t")] uint cid, [NativeTypeName("xcb_pixmap_t")] uint source, [NativeTypeName("xcb_pixmap_t")] uint mask, [NativeTypeName("uint16_t")] ushort fore_red, [NativeTypeName("uint16_t")] ushort fore_green, [NativeTypeName("uint16_t")] ushort fore_blue, [NativeTypeName("uint16_t")] ushort back_red, [NativeTypeName("uint16_t")] ushort back_green, [NativeTypeName("uint16_t")] ushort back_blue, [NativeTypeName("uint16_t")] ushort x, [NativeTypeName("uint16_t")] ushort y);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_create_cursor(IntPtr c, [NativeTypeName("xcb_cursor_t")] uint cid, [NativeTypeName("xcb_pixmap_t")] uint source, [NativeTypeName("xcb_pixmap_t")] uint mask, [NativeTypeName("uint16_t")] ushort fore_red, [NativeTypeName("uint16_t")] ushort fore_green, [NativeTypeName("uint16_t")] ushort fore_blue, [NativeTypeName("uint16_t")] ushort back_red, [NativeTypeName("uint16_t")] ushort back_green, [NativeTypeName("uint16_t")] ushort back_blue, [NativeTypeName("uint16_t")] ushort x, [NativeTypeName("uint16_t")] ushort y);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_create_glyph_cursor_checked(IntPtr c, [NativeTypeName("xcb_cursor_t")] uint cid, [NativeTypeName("xcb_font_t")] uint source_font, [NativeTypeName("xcb_font_t")] uint mask_font, [NativeTypeName("uint16_t")] ushort source_char, [NativeTypeName("uint16_t")] ushort mask_char, [NativeTypeName("uint16_t")] ushort fore_red, [NativeTypeName("uint16_t")] ushort fore_green, [NativeTypeName("uint16_t")] ushort fore_blue, [NativeTypeName("uint16_t")] ushort back_red, [NativeTypeName("uint16_t")] ushort back_green, [NativeTypeName("uint16_t")] ushort back_blue);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_create_glyph_cursor(IntPtr c, [NativeTypeName("xcb_cursor_t")] uint cid, [NativeTypeName("xcb_font_t")] uint source_font, [NativeTypeName("xcb_font_t")] uint mask_font, [NativeTypeName("uint16_t")] ushort source_char, [NativeTypeName("uint16_t")] ushort mask_char, [NativeTypeName("uint16_t")] ushort fore_red, [NativeTypeName("uint16_t")] ushort fore_green, [NativeTypeName("uint16_t")] ushort fore_blue, [NativeTypeName("uint16_t")] ushort back_red, [NativeTypeName("uint16_t")] ushort back_green, [NativeTypeName("uint16_t")] ushort back_blue);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_free_cursor_checked(IntPtr c, [NativeTypeName("xcb_cursor_t")] uint cursor);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_free_cursor(IntPtr c, [NativeTypeName("xcb_cursor_t")] uint cursor);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_recolor_cursor_checked(IntPtr c, [NativeTypeName("xcb_cursor_t")] uint cursor, [NativeTypeName("uint16_t")] ushort fore_red, [NativeTypeName("uint16_t")] ushort fore_green, [NativeTypeName("uint16_t")] ushort fore_blue, [NativeTypeName("uint16_t")] ushort back_red, [NativeTypeName("uint16_t")] ushort back_green, [NativeTypeName("uint16_t")] ushort back_blue);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_recolor_cursor(IntPtr c, [NativeTypeName("xcb_cursor_t")] uint cursor, [NativeTypeName("uint16_t")] ushort fore_red, [NativeTypeName("uint16_t")] ushort fore_green, [NativeTypeName("uint16_t")] ushort fore_blue, [NativeTypeName("uint16_t")] ushort back_red, [NativeTypeName("uint16_t")] ushort back_green, [NativeTypeName("uint16_t")] ushort back_blue);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_best_size_cookie_t xcb_query_best_size(IntPtr c, [NativeTypeName("uint8_t")] byte _class, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_best_size_cookie_t xcb_query_best_size_unchecked(IntPtr c, [NativeTypeName("uint8_t")] byte _class, [NativeTypeName("xcb_drawable_t")] uint drawable, [NativeTypeName("uint16_t")] ushort width, [NativeTypeName("uint16_t")] ushort height);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_best_size_reply_t* xcb_query_best_size_reply(IntPtr c, xcb_query_best_size_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_query_extension_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_extension_cookie_t xcb_query_extension(IntPtr c, [NativeTypeName("uint16_t")] ushort name_len, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_extension_cookie_t xcb_query_extension_unchecked(IntPtr c, [NativeTypeName("uint16_t")] ushort name_len, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_query_extension_reply_t* xcb_query_extension_reply(IntPtr c, xcb_query_extension_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_list_extensions_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_list_extensions_cookie_t xcb_list_extensions(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_list_extensions_cookie_t xcb_list_extensions_unchecked(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_list_extensions_names_length([NativeTypeName("const xcb_list_extensions_reply_t *")] xcb_list_extensions_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_str_iterator_t xcb_list_extensions_names_iterator([NativeTypeName("const xcb_list_extensions_reply_t *")] xcb_list_extensions_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_list_extensions_reply_t* xcb_list_extensions_reply(IntPtr c, xcb_list_extensions_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_change_keyboard_mapping_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_keyboard_mapping_checked(IntPtr c, [NativeTypeName("uint8_t")] byte keycode_count, [NativeTypeName("xcb_keycode_t")] byte first_keycode, [NativeTypeName("uint8_t")] byte keysyms_per_keycode, [NativeTypeName("const xcb_keysym_t *")] uint* keysyms);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_keyboard_mapping(IntPtr c, [NativeTypeName("uint8_t")] byte keycode_count, [NativeTypeName("xcb_keycode_t")] byte first_keycode, [NativeTypeName("uint8_t")] byte keysyms_per_keycode, [NativeTypeName("const xcb_keysym_t *")] uint* keysyms);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("xcb_keysym_t *")]
        public static extern uint* xcb_change_keyboard_mapping_keysyms([NativeTypeName("const xcb_change_keyboard_mapping_request_t *")] xcb_change_keyboard_mapping_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_change_keyboard_mapping_keysyms_length([NativeTypeName("const xcb_change_keyboard_mapping_request_t *")] xcb_change_keyboard_mapping_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_change_keyboard_mapping_keysyms_end([NativeTypeName("const xcb_change_keyboard_mapping_request_t *")] xcb_change_keyboard_mapping_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_get_keyboard_mapping_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_keyboard_mapping_cookie_t xcb_get_keyboard_mapping(IntPtr c, [NativeTypeName("xcb_keycode_t")] byte first_keycode, [NativeTypeName("uint8_t")] byte count);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_keyboard_mapping_cookie_t xcb_get_keyboard_mapping_unchecked(IntPtr c, [NativeTypeName("xcb_keycode_t")] byte first_keycode, [NativeTypeName("uint8_t")] byte count);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("xcb_keysym_t *")]
        public static extern uint* xcb_get_keyboard_mapping_keysyms([NativeTypeName("const xcb_get_keyboard_mapping_reply_t *")] xcb_get_keyboard_mapping_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_get_keyboard_mapping_keysyms_length([NativeTypeName("const xcb_get_keyboard_mapping_reply_t *")] xcb_get_keyboard_mapping_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_get_keyboard_mapping_keysyms_end([NativeTypeName("const xcb_get_keyboard_mapping_reply_t *")] xcb_get_keyboard_mapping_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_keyboard_mapping_reply_t* xcb_get_keyboard_mapping_reply(IntPtr c, xcb_get_keyboard_mapping_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_change_keyboard_control_value_list_serialize(void** _buffer, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_change_keyboard_control_value_list_t *")] xcb_change_keyboard_control_value_list_t* _aux);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_change_keyboard_control_value_list_unpack([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint value_mask, xcb_change_keyboard_control_value_list_t* _aux);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_change_keyboard_control_value_list_sizeof([NativeTypeName("const void *")] void* _buffer, [NativeTypeName("uint32_t")] uint value_mask);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_change_keyboard_control_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_keyboard_control_checked(IntPtr c, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const void *")] void* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_keyboard_control(IntPtr c, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const void *")] void* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_keyboard_control_aux_checked(IntPtr c, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_change_keyboard_control_value_list_t *")] xcb_change_keyboard_control_value_list_t* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_keyboard_control_aux(IntPtr c, [NativeTypeName("uint32_t")] uint value_mask, [NativeTypeName("const xcb_change_keyboard_control_value_list_t *")] xcb_change_keyboard_control_value_list_t* value_list);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* xcb_change_keyboard_control_value_list([NativeTypeName("const xcb_change_keyboard_control_request_t *")] xcb_change_keyboard_control_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_keyboard_control_cookie_t xcb_get_keyboard_control(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_keyboard_control_cookie_t xcb_get_keyboard_control_unchecked(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_keyboard_control_reply_t* xcb_get_keyboard_control_reply(IntPtr c, xcb_get_keyboard_control_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_bell_checked(IntPtr c, [NativeTypeName("int8_t")] sbyte percent);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_bell(IntPtr c, [NativeTypeName("int8_t")] sbyte percent);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_pointer_control_checked(IntPtr c, [NativeTypeName("int16_t")] short acceleration_numerator, [NativeTypeName("int16_t")] short acceleration_denominator, [NativeTypeName("int16_t")] short threshold, [NativeTypeName("uint8_t")] byte do_acceleration, [NativeTypeName("uint8_t")] byte do_threshold);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_pointer_control(IntPtr c, [NativeTypeName("int16_t")] short acceleration_numerator, [NativeTypeName("int16_t")] short acceleration_denominator, [NativeTypeName("int16_t")] short threshold, [NativeTypeName("uint8_t")] byte do_acceleration, [NativeTypeName("uint8_t")] byte do_threshold);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_pointer_control_cookie_t xcb_get_pointer_control(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_pointer_control_cookie_t xcb_get_pointer_control_unchecked(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_pointer_control_reply_t* xcb_get_pointer_control_reply(IntPtr c, xcb_get_pointer_control_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_set_screen_saver_checked(IntPtr c, [NativeTypeName("int16_t")] short timeout, [NativeTypeName("int16_t")] short interval, [NativeTypeName("uint8_t")] byte prefer_blanking, [NativeTypeName("uint8_t")] byte allow_exposures);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_set_screen_saver(IntPtr c, [NativeTypeName("int16_t")] short timeout, [NativeTypeName("int16_t")] short interval, [NativeTypeName("uint8_t")] byte prefer_blanking, [NativeTypeName("uint8_t")] byte allow_exposures);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_screen_saver_cookie_t xcb_get_screen_saver(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_screen_saver_cookie_t xcb_get_screen_saver_unchecked(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_screen_saver_reply_t* xcb_get_screen_saver_reply(IntPtr c, xcb_get_screen_saver_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_change_hosts_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_hosts_checked(IntPtr c, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("uint8_t")] byte family, [NativeTypeName("uint16_t")] ushort address_len, [NativeTypeName("const uint8_t *")] byte* address);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_change_hosts(IntPtr c, [NativeTypeName("uint8_t")] byte mode, [NativeTypeName("uint8_t")] byte family, [NativeTypeName("uint16_t")] ushort address_len, [NativeTypeName("const uint8_t *")] byte* address);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t *")]
        public static extern byte* xcb_change_hosts_address([NativeTypeName("const xcb_change_hosts_request_t *")] xcb_change_hosts_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_change_hosts_address_length([NativeTypeName("const xcb_change_hosts_request_t *")] xcb_change_hosts_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_change_hosts_address_end([NativeTypeName("const xcb_change_hosts_request_t *")] xcb_change_hosts_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_host_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t *")]
        public static extern byte* xcb_host_address([NativeTypeName("const xcb_host_t *")] xcb_host_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_host_address_length([NativeTypeName("const xcb_host_t *")] xcb_host_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_host_address_end([NativeTypeName("const xcb_host_t *")] xcb_host_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void xcb_host_next(xcb_host_iterator_t* i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_host_end(xcb_host_iterator_t i);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_list_hosts_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_list_hosts_cookie_t xcb_list_hosts(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_list_hosts_cookie_t xcb_list_hosts_unchecked(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_list_hosts_hosts_length([NativeTypeName("const xcb_list_hosts_reply_t *")] xcb_list_hosts_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_host_iterator_t xcb_list_hosts_hosts_iterator([NativeTypeName("const xcb_list_hosts_reply_t *")] xcb_list_hosts_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_list_hosts_reply_t* xcb_list_hosts_reply(IntPtr c, xcb_list_hosts_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_set_access_control_checked(IntPtr c, [NativeTypeName("uint8_t")] byte mode);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_set_access_control(IntPtr c, [NativeTypeName("uint8_t")] byte mode);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_set_close_down_mode_checked(IntPtr c, [NativeTypeName("uint8_t")] byte mode);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_set_close_down_mode(IntPtr c, [NativeTypeName("uint8_t")] byte mode);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_kill_client_checked(IntPtr c, [NativeTypeName("uint32_t")] uint resource);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_kill_client(IntPtr c, [NativeTypeName("uint32_t")] uint resource);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_rotate_properties_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_rotate_properties_checked(IntPtr c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint16_t")] ushort atoms_len, [NativeTypeName("int16_t")] short delta, [NativeTypeName("const xcb_atom_t *")] uint* atoms);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_rotate_properties(IntPtr c, [NativeTypeName("xcb_window_t")] uint window, [NativeTypeName("uint16_t")] ushort atoms_len, [NativeTypeName("int16_t")] short delta, [NativeTypeName("const xcb_atom_t *")] uint* atoms);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("xcb_atom_t *")]
        public static extern uint* xcb_rotate_properties_atoms([NativeTypeName("const xcb_rotate_properties_request_t *")] xcb_rotate_properties_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_rotate_properties_atoms_length([NativeTypeName("const xcb_rotate_properties_request_t *")] xcb_rotate_properties_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_rotate_properties_atoms_end([NativeTypeName("const xcb_rotate_properties_request_t *")] xcb_rotate_properties_request_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_force_screen_saver_checked(IntPtr c, [NativeTypeName("uint8_t")] byte mode);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_force_screen_saver(IntPtr c, [NativeTypeName("uint8_t")] byte mode);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_set_pointer_mapping_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_set_pointer_mapping_cookie_t xcb_set_pointer_mapping(IntPtr c, [NativeTypeName("uint8_t")] byte map_len, [NativeTypeName("const uint8_t *")] byte* map);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_set_pointer_mapping_cookie_t xcb_set_pointer_mapping_unchecked(IntPtr c, [NativeTypeName("uint8_t")] byte map_len, [NativeTypeName("const uint8_t *")] byte* map);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_set_pointer_mapping_reply_t* xcb_set_pointer_mapping_reply(IntPtr c, xcb_set_pointer_mapping_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_get_pointer_mapping_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_pointer_mapping_cookie_t xcb_get_pointer_mapping(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_pointer_mapping_cookie_t xcb_get_pointer_mapping_unchecked(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t *")]
        public static extern byte* xcb_get_pointer_mapping_map([NativeTypeName("const xcb_get_pointer_mapping_reply_t *")] xcb_get_pointer_mapping_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_get_pointer_mapping_map_length([NativeTypeName("const xcb_get_pointer_mapping_reply_t *")] xcb_get_pointer_mapping_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_get_pointer_mapping_map_end([NativeTypeName("const xcb_get_pointer_mapping_reply_t *")] xcb_get_pointer_mapping_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_pointer_mapping_reply_t* xcb_get_pointer_mapping_reply(IntPtr c, xcb_get_pointer_mapping_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_set_modifier_mapping_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_set_modifier_mapping_cookie_t xcb_set_modifier_mapping(IntPtr c, [NativeTypeName("uint8_t")] byte keycodes_per_modifier, [NativeTypeName("const xcb_keycode_t *")] byte* keycodes);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_set_modifier_mapping_cookie_t xcb_set_modifier_mapping_unchecked(IntPtr c, [NativeTypeName("uint8_t")] byte keycodes_per_modifier, [NativeTypeName("const xcb_keycode_t *")] byte* keycodes);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_set_modifier_mapping_reply_t* xcb_set_modifier_mapping_reply(IntPtr c, xcb_set_modifier_mapping_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_get_modifier_mapping_sizeof([NativeTypeName("const void *")] void* _buffer);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_modifier_mapping_cookie_t xcb_get_modifier_mapping(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_modifier_mapping_cookie_t xcb_get_modifier_mapping_unchecked(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("xcb_keycode_t *")]
        public static extern byte* xcb_get_modifier_mapping_keycodes([NativeTypeName("const xcb_get_modifier_mapping_reply_t *")] xcb_get_modifier_mapping_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int xcb_get_modifier_mapping_keycodes_length([NativeTypeName("const xcb_get_modifier_mapping_reply_t *")] xcb_get_modifier_mapping_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_generic_iterator_t xcb_get_modifier_mapping_keycodes_end([NativeTypeName("const xcb_get_modifier_mapping_reply_t *")] xcb_get_modifier_mapping_reply_t* R);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_get_modifier_mapping_reply_t* xcb_get_modifier_mapping_reply(IntPtr c, xcb_get_modifier_mapping_cookie_t cookie, xcb_generic_error_t** e);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_no_operation_checked(IntPtr c);

        [DllImport("libxcb.so.1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern xcb_void_cookie_t xcb_no_operation(IntPtr c);
    }
}
