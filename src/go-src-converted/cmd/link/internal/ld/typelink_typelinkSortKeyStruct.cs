//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:04:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using objabi = go.cmd.@internal.objabi_package;
using sym = go.cmd.link.@internal.sym_package;
using sort = go.sort_package;
using go;

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct typelinkSortKey
        {
            // Constructors
            public typelinkSortKey(NilType _)
            {
                this.TypeStr = default;
                this.Type = default;
            }

            public typelinkSortKey(@string TypeStr = default, ref ptr<sym.Symbol> Type = default)
            {
                this.TypeStr = TypeStr;
                this.Type = Type;
            }

            // Enable comparisons between nil and typelinkSortKey struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(typelinkSortKey value, NilType nil) => value.Equals(default(typelinkSortKey));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(typelinkSortKey value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, typelinkSortKey value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, typelinkSortKey value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator typelinkSortKey(NilType nil) => default(typelinkSortKey);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static typelinkSortKey typelinkSortKey_cast(dynamic value)
        {
            return new typelinkSortKey(value.TypeStr, ref value.Type);
        }
    }
}}}}