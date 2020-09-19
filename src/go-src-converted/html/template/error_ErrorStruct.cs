//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:34:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using parse = go.text.template.parse_package;
using go;

namespace go {
namespace html
{
    public static partial class template_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Error
        {
            // Constructors
            public Error(NilType _)
            {
                this.ErrorCode = default;
                this.Node = default;
                this.Name = default;
                this.Line = default;
                this.Description = default;
            }

            public Error(ErrorCode ErrorCode = default, parse.Node Node = default, @string Name = default, long Line = default, @string Description = default)
            {
                this.ErrorCode = ErrorCode;
                this.Node = Node;
                this.Name = Name;
                this.Line = Line;
                this.Description = Description;
            }

            // Enable comparisons between nil and Error struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Error value, NilType nil) => value.Equals(default(Error));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Error value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Error value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Error value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Error(NilType nil) => default(Error);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Error Error_cast(dynamic value)
        {
            return new Error(value.ErrorCode, value.Node, value.Name, value.Line, value.Description);
        }
    }
}}