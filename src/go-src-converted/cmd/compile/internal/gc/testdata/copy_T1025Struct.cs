//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:58:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct T1025
        {
            // Constructors
            public T1025(NilType _)
            {
                this.pre = default;
                this.mid = default;
                this.post = default;
            }

            public T1025(array<byte> pre = default, array<byte> mid = default, array<byte> post = default)
            {
                this.pre = pre;
                this.mid = mid;
                this.post = post;
            }

            // Enable comparisons between nil and T1025 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T1025 value, NilType nil) => value.Equals(default(T1025));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T1025 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T1025 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T1025 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T1025(NilType nil) => default(T1025);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static T1025 T1025_cast(dynamic value)
        {
            return new T1025(value.pre, value.mid, value.post);
        }
    }
}