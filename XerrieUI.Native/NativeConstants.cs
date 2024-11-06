// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
namespace XerrieUI.Native;

public static class NativeConstants
{
    public const int XCB_CONN_ERROR = 1;
    public const int XCB_CONN_CLOSED_EXT_NOTSUPPORTED = 2;
    public const int XCB_CONN_CLOSED_MEM_INSUFFICIENT = 3;
    public const int XCB_CONN_CLOSED_REQ_LEN_EXCEED = 4;
    public const int XCB_CONN_CLOSED_PARSE_ERR = 5;
    public const int XCB_CONN_CLOSED_INVALID_SCREEN = 6;
    public const int XCB_CONN_CLOSED_FDPASSING_FAILED = 7;

    public const byte XCB_COPY_FROM_PARENT_Depth = 0;

    public const int XCB_EXPOSE = 12;
    public const int XCB_DESTROY_NOTIFY = 17;
    public const int XCB_UNMAP_NOTIFY = 18;
    public const int XCB_MAP_NOTIFY = 19;
    public const int XCB_CONFIGURE_NOTIFY = 22;
    public const int XCB_PROPERTY_NOTIFY = 28;
    public const int XCB_CLIENT_MESSAGE = 33;

    public const byte XCB_EVENT_RESPONSE_TYPE_MASK = 0x7f;

    public static unsafe int XCB_EVENT_RESPONSE_TYPE(xcb_generic_event_t* e)
    {
        return e->response_type & XCB_EVENT_RESPONSE_TYPE_MASK;
    }

    public static unsafe int XCB_EVENT_SENT(xcb_generic_event_t* e)
    {
        return e->response_type & ~XCB_EVENT_RESPONSE_TYPE_MASK;
    }
}