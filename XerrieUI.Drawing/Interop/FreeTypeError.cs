// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// SPDX-License-Identifier: Apache-2.0
//
// SPDX-FileCopyrightText: (C) 2002-2024 by David Turner, Robert Wilhelm, and Werner Lemberg.
// SPDX-License-Identifier: FTL

namespace XerrieUI.Drawing.Interop;

public enum FreeTypeError : byte
{   
    // Generic errors
    Ok = 0x00,
    
    CannotOpenResource = 0x01,
    UnknownFileFormat = 0x02,
    InvalidFileFormat = 0x03,
    InvalidVersion = 0x04,
    LowerModuleVersion = 0x05,
    InvalidArgument = 0x06,
    UnimplementedFeature = 0x07,
    InvalidTable = 0x08,
    InvalidOffset = 0x09,
    ArrayTooLarge = 0x0A,
    MissingModule = 0x0B,
    MissingProperty = 0x0C,
    
    // Glyph/character errors
    
    InvalidGlyphIndex = 0x10,
    InvalidCharacterCode = 0x11,
    InvalidGlyphFormat = 0x12,
    CannotRenderGlyph = 0x13,
    InvalidOutline = 0x14,
    InvalidComposite = 0x15,
    TooManyHints = 0x16,
    InvalidPixelSize = 0x17,
    InvalidSvgDocument = 0x18,
    
    // Handle errors
    
    InvalidHandle = 0x20,
    InvalidLibraryHandle = 0x21,
    InvalidDriverHandle = 0x22,
    InvalidFaceHandle = 0x23,
    InvalidSizeHandle = 0x24,
    InvalidSlotHandle = 0x25,
    InvalidCharMapHandle = 0x26,
    InvalidCacheHandle = 0x27,
    InvalidStreamHandle = 0x28,
    
    // Driver errors
    
    TooManyDrivers = 0x30,
    TooManyExtensions = 0x31,
    
    // Memory errors
    
    OutOfMemory = 0x40,
    UnlistedObject = 0x41,
    
    // Stream errors
    
    CannotOpenStream = 0x51,
    InvalidStreamSeek = 0x52,
    InvalidStreamSkip = 0x53,
    InvalidStreamRead = 0x54,
    InvalidStreamOperation = 0x55,
    InvalidFrameOperation = 0x56,
    NestedFrameAccess = 0x57,
    InvalidFrameRead = 0x58,
    
    // Raster errors
    
    RasterUninitialized = 0x60,
    RasterCorrupted = 0x61,
    RasterOverflow = 0x62,
    RasterNegativeHeight = 0x63,
    
    // Cache errors
    
    TooManyCaches = 0x70,
    
    // TrueType and SFNT errors
    
    InvalidOpcode = 0x80,
    TooFewArguments = 0x81,
    StackOverflow = 0x82,
    CodeOverflow = 0x83,
    BadArgument = 0x84,
    DivideByZero = 0x85,
    InvalidReference = 0x86,
    DebugOpcode = 0x87,
    EndFInExecStream = 0x88,
    NestedDefs = 0x89,
    InvalidCodeRange = 0x8A,
    ExecutionTooLong = 0x8B,
    TooManyFunctionDefs = 0x8C,
    TooManyInstructionDefs = 0x8D,
    TableMissing = 0x8E,
    HorizontalHeaderMissing = 0x8F,
    LocationsMissing = 0x90,
    NameTableMissing = 0x91,
    CMapTableMissing = 0x92,
    HmtxTableMissing = 0x93,
    PostTableMissing = 0x94,
    InvalidHorizontalMetrics = 0x95,
    InvalidCharMapFormat = 0x96,
    InvalidPPem = 0x97,
    InvalidVerticalMetrics = 0x98,
    CouldNotFindContext = 0x99,
    InvalidPostTableFormat = 0x9A,
    InvalidPostTable = 0x9B,
    DefInGlyfBytecode = 0x9C,
    MissingBitmap = 0x9D,
    MissingSvgHooks = 0x9E,
    
    // CFF, CID, and Type 1 errors
    
    SyntaxError = 0xA0,
    StackUnderflow = 0xA1,
    Ignore = 0xA2,
    NoUnicodeGlyphName = 0xA3,
    GlyphTooBig = 0xA4,
    
    // BDF errors
    
    MissingStartFontField = 0xB0,
    MissingFontField = 0xB1,
    MissingSizeField = 0xB2,
    MissingFontBoundingBoxField = 0xB3,
    MissingCharsField = 0xB4,
    MissingStartCharField = 0xB5,
    MissingEncodingField = 0xB6,
    MissingBbxField = 0xB7,
    BbxTooBig = 0xB8,
    CorruptedFontHeader = 0xB9,
    CorruptedFontGlyphs = 0xBA,
}