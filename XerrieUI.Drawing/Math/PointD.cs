// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

// SPDX-FileCopyrightText: 2024 .NET Foundation. All rights reserved.
// SPDX-License-Identifier: MIT

using System.Drawing;

namespace XerrieUI.Drawing.Math;

using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

/// <summary>
/// Represents an ordered pair of x and y coordinates that define a point in a two-dimensional plane.
/// </summary>
[SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
public readonly struct PointD : IEquatable<PointD>
{
    /// <summary>
    /// Creates a new instance of the <see cref='XerrieUI.Drawing.Math.PointD'/> class with member data left uninitialized.
    /// </summary>
    public static readonly PointD Empty = new();

    /// <summary>
    /// Initializes a new instance of the <see cref='XerrieUI.Drawing.Math.PointD'/> class with the specified coordinates.
    /// </summary>
    public PointD(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref='XerrieUI.Drawing.Math.PointD'/> struct from the specified
    /// <see cref="System.Numerics.Vector2"/>.
    /// </summary>
    public PointD(Vector2 vector)
    {
        X = vector.X;
        Y = vector.Y;
    }

    /// <summary>
    /// Creates a new <see cref="System.Numerics.Vector2"/> from this <see cref="XerrieUI.Drawing.Math.PointD"/>.
    /// </summary>
    public Vector2 ToVector2() => new((float)X, (float)Y);

    /// <summary>
    /// Gets a value indicating whether this <see cref='XerrieUI.Drawing.Math.PointD'/> is empty.
    /// </summary>
    [Browsable(false)]
    public readonly bool IsEmpty => X == 0f && Y == 0f;

    /// <summary>
    /// Gets the x-coordinate of this <see cref='XerrieUI.Drawing.Math.PointD'/>.
    /// </summary>
    public double X { get; }

    /// <summary>
    /// Gets the y-coordinate of this <see cref='XerrieUI.Drawing.Math.PointD'/>.
    /// </summary>
    public double Y { get; }

    /// <summary>
    /// Converts the specified <see cref="XerrieUI.Drawing.Math.PointD"/> to a <see cref="System.Numerics.Vector2"/>.
    /// </summary>
    public static explicit operator Vector2(PointD point) => point.ToVector2();

    /// <summary>
    /// Converts the specified <see cref="System.Numerics.Vector2"/> to a <see cref="XerrieUI.Drawing.Math.PointD"/>.
    /// </summary>
    public static explicit operator PointD(Vector2 vector) => new PointD(vector);

    /// <summary>
    /// Translates a <see cref='XerrieUI.Drawing.Math.PointD'/> by a given <see cref='System.Drawing.Size'/> .
    /// </summary>
    public static PointD operator +(PointD pt, Size sz) => Add(pt, sz);

    /// <summary>
    /// Translates a <see cref='XerrieUI.Drawing.Math.PointD'/> by the negative of a given <see cref='System.Drawing.Size'/> .
    /// </summary>
    public static PointD operator -(PointD pt, Size sz) => Subtract(pt, sz);

    /// <summary>
    /// Translates a <see cref='XerrieUI.Drawing.Math.PointD'/> by a given <see cref='System.Drawing.SizeF'/> .
    /// </summary>
    public static PointD operator +(PointD pt, SizeF sz) => Add(pt, sz);

    /// <summary>
    /// Translates a <see cref='XerrieUI.Drawing.Math.PointD'/> by the negative of a given <see cref='System.Drawing.SizeF'/> .
    /// </summary>
    public static PointD operator -(PointD pt, SizeF sz) => Subtract(pt, sz);

    /// <summary>
    /// Compares two <see cref='XerrieUI.Drawing.Math.PointD'/> objects. The result specifies whether the values of the
    /// <see cref='XerrieUI.Drawing.Math.PointD.X'/> and <see cref='XerrieUI.Drawing.Math.PointD.Y'/> properties of the two
    /// <see cref='XerrieUI.Drawing.Math.PointD'/> objects are equal.
    /// </summary>
    public static bool operator ==(PointD left, PointD right) => left.X == right.X && left.Y == right.Y;

    /// <summary>
    /// Compares two <see cref='XerrieUI.Drawing.Math.PointD'/> objects. The result specifies whether the values of the
    /// <see cref='XerrieUI.Drawing.Math.PointD.X'/> or <see cref='XerrieUI.Drawing.Math.PointD.Y'/> properties of the two
    /// <see cref='XerrieUI.Drawing.Math.PointD'/> objects are unequal.
    /// </summary>
    public static bool operator !=(PointD left, PointD right) => !(left == right);

    /// <summary>
    /// Translates a <see cref='XerrieUI.Drawing.Math.PointD'/> by a given <see cref='System.Drawing.Size'/> .
    /// </summary>
    public static PointD Add(PointD pt, Size sz) => new PointD(pt.X + sz.Width, pt.Y + sz.Height);

    /// <summary>
    /// Translates a <see cref='XerrieUI.Drawing.Math.PointD'/> by the negative of a given <see cref='System.Drawing.Size'/> .
    /// </summary>
    public static PointD Subtract(PointD pt, Size sz) => new PointD(pt.X - sz.Width, pt.Y - sz.Height);

    /// <summary>
    /// Translates a <see cref='XerrieUI.Drawing.Math.PointD'/> by a given <see cref='System.Drawing.SizeF'/> .
    /// </summary>
    public static PointD Add(PointD pt, SizeF sz) => new PointD(pt.X + sz.Width, pt.Y + sz.Height);

    /// <summary>
    /// Translates a <see cref='XerrieUI.Drawing.Math.PointD'/> by the negative of a given <see cref='System.Drawing.SizeF'/> .
    /// </summary>
    public static PointD Subtract(PointD pt, SizeF sz) => new PointD(pt.X - sz.Width, pt.Y - sz.Height);

    public override bool Equals([NotNullWhen(true)] object? obj) => obj is PointD d && Equals(d);

    public bool Equals(PointD other) => this == other;

    public override int GetHashCode() => HashCode.Combine(X.GetHashCode(), Y.GetHashCode());

    public override string ToString() => $"{{X={X}, Y={Y}}}";
    
    // Begin XerrieUI

    public static implicit operator PointD(PointF from)
    {
        return new PointD(from.X, from.Y);
    }

    public static implicit operator PointD(Point from)
    {
        return new PointD(from.X, from.Y);
    }

    public Point ToPoint()
    {
        return new Point((int)System.Math.Round(X),
            (int)System.Math.Round(Y));
    }
}