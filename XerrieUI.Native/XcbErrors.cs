// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using XerrieUI.Native.Windowing;

namespace XerrieUI.Native;

public enum XcbErrors : byte
{
    /// <summary>
    /// No errors returned.
    /// </summary>
    None,
    /// <summary>
    /// The major or minor opcode does not specify a valid request.
    /// </summary>
    Request,
    /// <summary>
    /// Some numeric value falls outside the range of values accepted by the request.
    /// Unless a specific range is specified for an argument, the full range defined by the argument's type
    /// is accepted. Any argument defined as a set of alternatives typically can generate this error
    /// (due to the encoding). 
    /// </summary>
    Value,
    /// <summary>
    /// An instance of <see cref="XcbWindowHandle"/> passed is not a valid reference to a window in the X server.
    /// </summary>
    Window,
    /// <summary>
    /// A pixmap handle is not a valid reference to a pixmap in the X server.
    /// </summary>
    Pixmap,
    /// <summary>
    /// An atom value is not a valid reference to an atom in the X server.
    /// </summary>
    Atom,
    /// <summary>
    /// A cursor handle is not a valid reference to a cursor in the X server.
    /// </summary>
    Cursor,
    /// <summary>
    /// Either a font handle is not a valid reference to a font in the X server, or a "Font-able" handle is neither
    /// a valid reference to a font nor a GContext in the X server.
    /// </summary>
    Font,
    /// <summary>
    /// The specified arguments combination or values are invalid. Analogue to <see cref="ArgumentException"/>.
    /// </summary>
    Match,
    /// <summary>
    /// A "drawable" handle is not a valid reference to a window nor a pixmap in the X server.
    /// </summary>
    Drawable,
    /// <summary>
    /// Any of the following attempts are made:
    /// <list type="bullet">
    /// <item>Grabbing a key/button combination already grabbed by another client;</item>
    /// <item>Freeing a color-map entry not allocated by the client;</item>
    /// <item>Freeing an entry in a color-map that was created with all entries writable;</item>
    /// <item>Storing into a read-only or an unallocated color-map entry;</item>
    /// <item>Modifying the access control list from other than the local host (or otherwise authorized client);</item>
    /// <item>Selecting an event type that only one client can select at a time when another client has already selected it</item>
    /// </list>
    /// </summary>
    Access,
    /// <summary>
    /// The server failed to allocate the requested resource.
    /// </summary>
    Alloc,
    /// <summary>
    /// A color map handle is not a valid reference to a color map in the X server.
    /// </summary>
    ColorMap,
    /// <summary>
    /// A GContext handle is not a valid reference to a GContext in the X server.
    /// </summary>
    GContext,
    /// <summary>
    /// The value chosen for a resource identifier either is not included in the range
    /// assigned to the client or is already in use. 
    /// </summary>
    IdChoice,
    /// <summary>
    /// A font or color of the specified name does not exist. 
    /// </summary>
    Name,
    /// <summary>
    /// Either the length of a request is shorter or longer than that required to minimally contain the
    /// arguments, or it exceeds the maximum length accepted by the server. 
    /// </summary>
    /// <seealso cref="NativeConstants.XCB_CONN_CLOSED_REQ_LEN_EXCEED"/>
    Length,
    /// <summary>
    /// The server does not implement some aspect of the request. Analogue to <see cref="NotImplementedException"/>.
    /// </summary>
    Implementation
}