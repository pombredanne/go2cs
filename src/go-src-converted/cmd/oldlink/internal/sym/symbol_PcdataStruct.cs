//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:40:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using elf = go.debug.elf_package;
using fmt = go.fmt_package;
using log = go.log_package;
using go;

namespace go {
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class sym_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Pcdata
        {
            // Constructors
            public Pcdata(NilType _)
            {
                this.P = default;
            }

            public Pcdata(slice<byte> P = default)
            {
                this.P = P;
            }

            // Enable comparisons between nil and Pcdata struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Pcdata value, NilType nil) => value.Equals(default(Pcdata));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Pcdata value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Pcdata value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Pcdata value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Pcdata(NilType nil) => default(Pcdata);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Pcdata Pcdata_cast(dynamic value)
        {
            return new Pcdata(value.P);
        }
    }
}}}}