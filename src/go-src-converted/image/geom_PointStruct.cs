//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:09:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using color = go.image.color_package;
using strconv = go.strconv_package;

namespace go
{
    public static partial class image_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Point
        {
            // Constructors
            public Point(NilType _)
            {
                this.X = default;
                this.Y = default;
            }

            public Point(long X = default, long Y = default)
            {
                this.X = X;
                this.Y = Y;
            }

            // Enable comparisons between nil and Point struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Point value, NilType nil) => value.Equals(default(Point));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Point value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Point value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Point value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Point(NilType nil) => default(Point);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Point Point_cast(dynamic value)
        {
            return new Point(value.X, value.Y);
        }
    }
}