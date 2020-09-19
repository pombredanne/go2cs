//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:52:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using token = go.go.token_package;
using io = go.io_package;
using os = go.os_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using tabwriter = go.text.tabwriter_package;
using unicode = go.unicode_package;
using go;

namespace go {
namespace go
{
    public static partial class printer_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CommentedNode
        {
            // Constructors
            public CommentedNode(NilType _)
            {
                this.Comments = default;
            }

            public CommentedNode(slice<ref ast.CommentGroup> Comments = default)
            {
                this.Comments = Comments;
            }

            // Enable comparisons between nil and CommentedNode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CommentedNode value, NilType nil) => value.Equals(default(CommentedNode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CommentedNode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CommentedNode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CommentedNode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CommentedNode(NilType nil) => default(CommentedNode);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CommentedNode CommentedNode_cast(dynamic value)
        {
            return new CommentedNode(value.Comments);
        }
    }
}}