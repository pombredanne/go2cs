//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:54:53 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using io = go.io_package;
using reflect = go.reflect_package;
using @unsafe = go.@unsafe_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal {
namespace @event
{
    public static partial class label_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct mapChain
        {
            // Constructors
            public mapChain(NilType _)
            {
                this.maps = default;
            }

            public mapChain(slice<Map> maps = default)
            {
                this.maps = maps;
            }

            // Enable comparisons between nil and mapChain struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mapChain value, NilType nil) => value.Equals(default(mapChain));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mapChain value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mapChain value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mapChain value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mapChain(NilType nil) => default(mapChain);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static mapChain mapChain_cast(dynamic value)
        {
            return new mapChain(value.maps);
        }
    }
}}}}}}