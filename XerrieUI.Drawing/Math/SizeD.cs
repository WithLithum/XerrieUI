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
/// Represents the size of a rectangular region with an ordered pair of width and height.
/// </summary>
[SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
public readonly struct SizeD : IEquatable<SizeD>
{
    /// <summary>
    /// Initializes a new instance of the <see cref='SizeD'/> class.
    /// </summary>
    public static readonly SizeD Empty = new();

    /// <summary>
    /// Initializes a new instance of the <see cref='SizeD'/> class from the specified
    /// existing <see cref='SizeD'/>.
    /// </summary>
    public SizeD(SizeD size)
    {
        Width = size.Width;
        Height = size.Height;
    }
    
    /// <summary>
    /// Initializes a new instance of the <see cref='SizeD'/> class from the specified
    /// existing <see cref='SizeD'/>.
    /// </summary>
    public SizeD(SizeF size)
    {
        Width = size.Width;
        Height = size.Height;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref='SizeD'/> class from the specified
    /// <see cref='System.Drawing.PointF'/>.
    /// </summary>
    public SizeD(PointD pt)
    {
        Width = pt.X;
        Height = pt.Y;
    }

    
    /// <summary>
    /// Initializes a new instance of the <see cref='SizeD'/> class from the specified
    /// <see cref='System.Drawing.PointF'/>.
    /// </summary>
    public SizeD(PointF pt)
    {
        Width = pt.X;
        Height = pt.Y;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref='SizeD'/> struct from the specified
    /// <see cref="System.Numerics.Vector2"/>.
    /// </summary>
    public SizeD(Vector2 vector)
    {
        Width = vector.X;
        Height = vector.Y;
    }

    /// <summary>
    /// Creates a new <see cref="System.Numerics.Vector2"/> from this <see cref="SizeD"/>.
    /// </summary>
    public Vector2 ToVector2() => new Vector2((float)Width, (float)Height);

    /// <summary>
    /// Initializes a new instance of the <see cref='SizeD'/> class from the specified dimensions.
    /// </summary>
    public SizeD(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    /// <summary>
    /// Converts the specified <see cref="SizeD"/> to a <see cref="System.Numerics.Vector2"/>.
    /// </summary>
    public static explicit operator Vector2(SizeD size) => size.ToVector2();

    /// <summary>
    /// Converts the specified <see cref="System.Numerics.Vector2"/> to a <see cref="SizeD"/>.
    /// </summary>
    public static explicit operator SizeD(Vector2 vector) => new SizeD(vector);

    /// <summary>
    /// Performs vector addition of two <see cref='SizeD'/> objects.
    /// </summary>
    public static SizeD operator +(SizeD sz1, SizeD sz2) => Add(sz1, sz2);

    /// <summary>
    /// Contracts a <see cref='SizeD'/> by another <see cref='SizeD'/>
    /// </summary>
    public static SizeD operator -(SizeD sz1, SizeD sz2) => Subtract(sz1, sz2);

    /// <summary>
    /// Multiplies <see cref="SizeD"/> by a <see cref="float"/> producing <see cref="SizeD"/>.
    /// </summary>
    /// <param name="left">Multiplier of type <see cref="float"/>.</param>
    /// <param name="right">Multiplicand of type <see cref="SizeD"/>.</param>
    /// <returns>Product of type <see cref="SizeD"/>.</returns>
    public static SizeD operator *(float left, SizeD right) => Multiply(right, left);

    /// <summary>
    /// Multiplies <see cref="SizeD"/> by a <see cref="float"/> producing <see cref="SizeD"/>.
    /// </summary>
    /// <param name="left">Multiplicand of type <see cref="SizeD"/>.</param>
    /// <param name="right">Multiplier of type <see cref="float"/>.</param>
    /// <returns>Product of type <see cref="SizeD"/>.</returns>
    public static SizeD operator *(SizeD left, float right) => Multiply(left, right);

    /// <summary>
    /// Divides <see cref="SizeD"/> by a <see cref="float"/> producing <see cref="SizeD"/>.
    /// </summary>
    /// <param name="left">Dividend of type <see cref="SizeD"/>.</param>
    /// <param name="right">Divisor of type <see cref="int"/>.</param>
    /// <returns>Result of type <see cref="SizeD"/>.</returns>
    public static SizeD operator /(SizeD left, double right)
        => new SizeD(left.Width / right, left.Height / right);

    /// <summary>
    /// Tests whether two <see cref='SizeD'/> objects are identical.
    /// </summary>
    public static bool operator ==(SizeD sz1, SizeD sz2) => sz1.Width == sz2.Width && sz1.Height == sz2.Height;

    /// <summary>
    /// Tests whether two <see cref='SizeD'/> objects are different.
    /// </summary>
    public static bool operator !=(SizeD sz1, SizeD sz2) => !(sz1 == sz2);

    /// <summary>
    /// Converts the specified <see cref='SizeD'/> to a <see cref='System.Drawing.PointF'/>.
    /// </summary>
    public static explicit operator PointD(SizeD size) => new PointD(size.Width, size.Height);

    /// <summary>
    /// Tests whether this <see cref='SizeD'/> has zero width and height.
    /// </summary>
    [Browsable(false)]
    public bool IsEmpty => Width == 0 && Height == 0;

    /// <summary>
    /// Represents the horizontal component of this <see cref='SizeD'/>.
    /// </summary>
    public double Width { get; }

    /// <summary>
    /// Represents the vertical component of this <see cref='SizeD'/>.
    /// </summary>
    public double Height { get; }

    /// <summary>
    /// Performs vector addition of two <see cref='SizeD'/> objects.
    /// </summary>
    public static SizeD Add(SizeD sz1, SizeD sz2) => new SizeD(sz1.Width + sz2.Width, sz1.Height + sz2.Height);

    /// <summary>
    /// Contracts a <see cref='SizeD'/> by another <see cref='SizeD'/>.
    /// </summary>
    public static SizeD Subtract(SizeD sz1, SizeD sz2) => new SizeD(sz1.Width - sz2.Width, sz1.Height - sz2.Height);

    /// <summary>
    /// Tests to see whether the specified object is a <see cref='SizeD'/>  with the same dimensions
    /// as this <see cref='SizeD'/>.
    /// </summary>
    public override bool Equals([NotNullWhen(true)] object? obj) => obj is SizeD && Equals((SizeD)obj);

    public bool Equals(SizeD other) => this == other;

    public override int GetHashCode() => HashCode.Combine(Width, Height);

    public PointD ToPointD() => (PointD)this;

    public Size ToSize() => Size.Truncate((SizeF)this);

    /// <summary>
    /// Creates a human-readable string that represents this <see cref='SizeD'/>.
    /// </summary>
    public override string ToString() => $"{{Width={Width}, Height={Height}}}";

    /// <summary>
    /// Multiplies <see cref="SizeD"/> by a <see cref="float"/> producing <see cref="SizeD"/>.
    /// </summary>
    /// <param name="size">Multiplicand of type <see cref="SizeD"/>.</param>
    /// <param name="multiplier">Multiplier of type <see cref="float"/>.</param>
    /// <returns>Product of type SizeD.</returns>
    private static SizeD Multiply(SizeD size, double multiplier) =>
        new SizeD(size.Width * multiplier, size.Height * multiplier);
    
    // Begin XerrieUI

    public static explicit operator SizeF(SizeD from)
    {
        return new SizeF((float)from.Width, (float)from.Height);
    }
    
    public static implicit operator SizeD(SizeF from)
    {
        return new SizeD(from);
    }
}