// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// SPDX-License-Identifier: Apache-2.0
//
// SPDX-FileCopyrightText: Copyright (c) .NET Foundation and Contributors
// SPDX-License-Identifier: MIT

using System.Drawing;

namespace XerrieUI.Core.Drawing;

/// <summary>
/// Mathematical methods without requiring instance creation of structures.
/// </summary>
public static class FastCalc
{
    public static bool DoesIntersectWith(Point p1, Size s1, Point p2, Size s2)
    {
        
        return (p2.X < p1.X + s1.Width) && (p1.X < p2.X + s2.Width) &&
               (p2.Y < p1.Y + s1.Height) && (p1.Y < p2.Y + s2.Height);
    }
}