//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:55:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace container
{
    public static partial class list_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct List
        {
            // Constructors
            public List(NilType _)
            {
                this.root = default;
                this.len = default;
            }

            public List(Element root = default, long len = default)
            {
                this.root = root;
                this.len = len;
            }

            // Enable comparisons between nil and List struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(List value, NilType nil) => value.Equals(default(List));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(List value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, List value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, List value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator List(NilType nil) => default(List);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static List List_cast(dynamic value)
        {
            return new List(value.root, value.len);
        }
    }
}}