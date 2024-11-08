// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

// SPDX-FileCopyrightText: 2024 .NET Foundation. All rights reserved.
// SPDX-License-Identifier: MIT

using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Numerics;

namespace XerrieUI.Drawing.Math;

/// <summary>
/// Stores the location and size of a rectangular region.
/// </summary>
[SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
public readonly struct RectangleD : IEquatable<RectangleD>
{
    /// <summary>
    /// Initializes a new instance of the <see cref='RectangleD'/> class.
    /// </summary>
    public static readonly RectangleD Empty = new();

    /// <summary>
    /// Initializes a new instance of the <see cref='RectangleD'/> class with the specified location
    /// and size.
    /// </summary>
    public RectangleD(double x, double y, double width, double height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref='RectangleD'/> class with the specified location
    /// and size.
    /// </summary>
    public RectangleD(PointD location, SizeD size)
    {
        X = location.X;
        Y = location.Y;
        Width = size.Width;
        Height = size.Height;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref='RectangleD'/> struct from the specified
    /// <see cref="System.Numerics.Vector4"/>.
    /// </summary>
    public RectangleD(Vector4 vector)
    {
        X = vector.X;
        Y = vector.Y;
        Width = vector.Z;
        Height = vector.W;
    }

    /// <summary>
    /// Creates a new <see cref="System.Numerics.Vector4"/> from this <see cref="RectangleD"/>.
    /// </summary>
    public Vector4 ToVector4() => new Vector4((float)X, (float)Y, (float)Width, (float)Height);

    /// <summary>
    /// Converts the specified <see cref="RectangleD"/> to a <see cref="System.Numerics.Vector4"/>.
    /// </summary>
    public static explicit operator Vector4(RectangleD rectangle) => rectangle.ToVector4();

    /// <summary>
    /// Converts the specified <see cref="System.Numerics.Vector2"/> to a <see cref="RectangleD"/>.
    /// </summary>
    public static explicit operator RectangleD(Vector4 vector) => new(vector);

    /// <summary>
    /// Creates a new <see cref='RectangleD'/> with the specified location and size.
    /// </summary>
    public static RectangleD FromLTRB(double left, double top, double right, double bottom) =>
        new(left, top, right - left, bottom - top);

    /// <summary>
    /// Gets or sets the coordinates of the upper-left corner of the rectangular region represented by this
    /// <see cref='RectangleD'/>.
    /// </summary>
    [Browsable(false)]
    public PointD Location => new(X, Y);

    /// <summary>
    /// Gets or sets the size of this <see cref='RectangleD'/>.
    /// </summary>
    [Browsable(false)]
    public SizeD Size => new(Width, Height);

    /// <summary>
    /// Gets or sets the x-coordinate of the upper-left corner of the rectangular region defined by this
    /// <see cref='RectangleD'/>.
    /// </summary>
    public double X { get; }

    /// <summary>
    /// Gets or sets the y-coordinate of the upper-left corner of the rectangular region defined by this
    /// <see cref='RectangleD'/>.
    /// </summary>
    public double Y { get; }

    /// <summary>
    /// Gets or sets the width of the rectangular region defined by this <see cref='RectangleD'/>.
    /// </summary>
    public double Width { get; }

    /// <summary>
    /// Gets or sets the height of the rectangular region defined by this <see cref='RectangleD'/>.
    /// </summary>
    public double Height { get; }

    /// <summary>
    /// Gets the x-coordinate of the upper-left corner of the rectangular region defined by this
    /// <see cref='RectangleD'/> .
    /// </summary>
    [Browsable(false)]
    public double Left => X;

    /// <summary>
    /// Gets the y-coordinate of the upper-left corner of the rectangular region defined by this
    /// <see cref='RectangleD'/>.
    /// </summary>
    [Browsable(false)]
    public double Top => Y;

    /// <summary>
    /// Gets the x-coordinate of the lower-right corner of the rectangular region defined by this
    /// <see cref='RectangleD'/>.
    /// </summary>
    [Browsable(false)]
    public double Right => X + Width;

    /// <summary>
    /// Gets the y-coordinate of the lower-right corner of the rectangular region defined by this
    /// <see cref='RectangleD'/>.
    /// </summary>
    [Browsable(false)]
    public double Bottom => Y + Height;

    /// <summary>
    /// Tests whether this <see cref='RectangleD'/> has a <see cref='RectangleD.Width'/> or a <see cref='RectangleD.Height'/> of 0.
    /// </summary>
    [Browsable(false)]
    public readonly bool IsEmpty => (Width <= 0) || (Height <= 0);

    /// <summary>
    /// Tests whether <paramref name="obj"/> is a <see cref='RectangleD'/> with the same location and
    /// size of this <see cref='RectangleD'/>.
    /// </summary>
    public override bool Equals([NotNullWhen(true)] object? obj) =>
        obj is RectangleF f && Equals(f);

    public bool Equals(RectangleD other) => this == other;

    /// <summary>
    /// Tests whether two <see cref='RectangleD'/> objects have equal location and size.
    /// </summary>
    public static bool operator ==(RectangleD left, RectangleD right) =>
        left.X == right.X && left.Y == right.Y && left.Width == right.Width && left.Height == right.Height;

    /// <summary>
    /// Tests whether two <see cref='RectangleD'/> objects differ in location or size.
    /// </summary>
    public static bool operator !=(RectangleD left, RectangleD right) => !(left == right);

    /// <summary>
    /// Determines if the specified point is contained within the rectangular region defined by this
    /// <see cref='System.Drawing.Rectangle'/> .
    /// </summary>
    public bool Contains(double x, double y) => X <= x && x < X + Width && Y <= y && y < Y + Height;

    /// <summary>
    /// Determines if the specified point is contained within the rectangular region defined by this
    /// <see cref='System.Drawing.Rectangle'/> .
    /// </summary>
    public bool Contains(PointD pt) => Contains(pt.X, pt.Y);

    /// <summary>
    /// Determines if the rectangular region represented by <paramref name="rect"/> is entirely contained within
    /// the rectangular region represented by this <see cref='System.Drawing.Rectangle'/> .
    /// </summary>
    public bool Contains(RectangleD rect) =>
        (X <= rect.X) && (rect.X + rect.Width <= X + Width) && (Y <= rect.Y) && (rect.Y + rect.Height <= Y + Height);

    /// <summary>
    /// Gets the hash code for this <see cref='RectangleD'/>.
    /// </summary>
    public override int GetHashCode() => HashCode.Combine(X, Y, Width, Height);

    /// <summary>
    /// Creates a new instance of <see cref="RectangleD"/> that is the inflated variant of this
    /// rectangle.
    /// </summary>
    public RectangleD Inflate(double x, double y)
    {
        return new RectangleD(X - x, Y - y,  Width + 2 * x, Height + 2 * y);
    }

    /// <summary>
    /// Inflates this <see cref='System.Drawing.Rectangle'/> by the specified amount.
    /// </summary>
    public void Inflate(SizeD size) => Inflate(size.Width, size.Height);

    /// <summary>
    /// Creates a <see cref='System.Drawing.Rectangle'/> that is inflated by the specified amount.
    /// </summary>
    public static RectangleD Inflate(RectangleD rect, float x, float y)
    {
        return rect.Inflate(x, y);
    }

    /// <summary>
    /// Creates a Rectangle that represents the intersection between this Rectangle and rect.
    /// </summary>
    public RectangleD Intersect(RectangleD rect)
    {
        return Intersect(rect, this);
    }

    /// <summary>
    /// Creates a rectangle that represents the intersection between a and b. If there is no intersection, an
    /// empty rectangle is returned.
    /// </summary>
    public static RectangleD Intersect(RectangleD a, RectangleD b)
    {
        var x1 = System.Math.Max(a.X, b.X);
        var x2 = System.Math.Min(a.X + a.Width, b.X + b.Width);
        var y1 = System.Math.Max(a.Y, b.Y);
        var y2 = System.Math.Min(a.Y + a.Height, b.Y + b.Height);

        if (x2 >= x1 && y2 >= y1)
        {
            return new RectangleD(x1, y1, x2 - x1, y2 - y1);
        }

        return Empty;
    }

    /// <summary>
    /// Determines if this rectangle intersects with rect.
    /// </summary>
    public readonly bool IntersectsWith(RectangleF rect) =>
        (rect.X < X + Width) && (X < rect.X + rect.Width) && (rect.Y < Y + Height) && (Y < rect.Y + rect.Height);

    /// <summary>
    /// Creates a rectangle that represents the union between a and b.
    /// </summary>
    public static RectangleD Union(RectangleD a, RectangleD b)
    {
        var x1 = System.Math.Min(a.X, b.X);
        var x2 = System.Math.Max(a.X + a.Width, b.X + b.Width);
        var y1 = System.Math.Min(a.Y, b.Y);
        var y2 = System.Math.Max(a.Y + a.Height, b.Y + b.Height);

        return new RectangleD(x1, y1, x2 - x1, y2 - y1);
    }

    /// <summary>
    /// Adjusts the location of this rectangle by the specified amount.
    /// </summary>
    public RectangleD Offset(PointF pos) => Offset(pos.X, pos.Y);

    /// <summary>
    /// Adjusts the location of this rectangle by the specified amount.
    /// </summary>
    public RectangleD Offset(double x, double y)
    {
        return new RectangleD(X + x, Y + y, Width, Height);
    }

    /// <summary>
    /// Converts the specified <see cref='System.Drawing.Rectangle'/> to a
    /// <see cref='RectangleD'/>.
    /// </summary>
    public static implicit operator RectangleD(Rectangle r) => new(r.X, r.Y, r.Width, r.Height);

    /// <summary>
    /// Converts the <see cref='RectangleD.Location'/> and <see cref='RectangleD.Size'/>
    /// of this <see cref='RectangleD'/> to a human-readable string.
    /// </summary>
    public override string ToString() => $"{{X={X},Y={Y},Width={Width},Height={Height}}}";
    
    // Begin XerrieUI
    
    public static implicit operator RectangleD(RectangleF r) => new(r.X, r.Y, r.Width, r.Height);

    public Rectangle ToRectangle()
    {
        return new Rectangle(ToInt(X),
            ToInt(Y),
            ToInt(Width),
            ToInt(Height));
        
        int ToInt(double from) => (int)System.Math.Round(from);
    }
}