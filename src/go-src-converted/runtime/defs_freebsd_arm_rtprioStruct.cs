//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct rtprio
        {
            // Constructors
            public rtprio(NilType _)
            {
                this._type = default;
                this.prio = default;
            }

            public rtprio(ushort _type = default, ushort prio = default)
            {
                this._type = _type;
                this.prio = prio;
            }

            // Enable comparisons between nil and rtprio struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(rtprio value, NilType nil) => value.Equals(default(rtprio));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(rtprio value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, rtprio value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, rtprio value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator rtprio(NilType nil) => default(rtprio);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static rtprio rtprio_cast(dynamic value)
        {
            return new rtprio(value._type, value.prio);
        }
    }
}