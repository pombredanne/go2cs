//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:41:51 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using fmt = go.fmt_package;
using go;

namespace go {
namespace @internal
{
    public static partial class profile_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct buffer
        {
            // Constructors
            public buffer(NilType _)
            {
                this.field = default;
                this.typ = default;
                this.u64 = default;
                this.data = default;
                this.tmp = default;
            }

            public buffer(long field = default, long typ = default, ulong u64 = default, slice<byte> data = default, array<byte> tmp = default)
            {
                this.field = field;
                this.typ = typ;
                this.u64 = u64;
                this.data = data;
                this.tmp = tmp;
            }

            // Enable comparisons between nil and buffer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(buffer value, NilType nil) => value.Equals(default(buffer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(buffer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, buffer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, buffer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator buffer(NilType nil) => default(buffer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static buffer buffer_cast(dynamic value)
        {
            return new buffer(value.field, value.typ, value.u64, value.data, value.tmp);
        }
    }
}}