//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:34:46 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using html = go.html_package;
using io = go.io_package;
using template = go.text.template_package;
using parse = go.text.template.parse_package;
using go;

namespace go {
namespace html
{
    public static partial class template_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct escaper
        {
            // Constructors
            public escaper(NilType _)
            {
                this.ns = default;
                this.output = default;
                this.derived = default;
                this.called = default;
                this.actionNodeEdits = default;
                this.templateNodeEdits = default;
                this.textNodeEdits = default;
            }

            public escaper(ref ptr<nameSpace> ns = default, map<@string, context> output = default, map<@string, ref template.Template> derived = default, map<@string, bool> called = default, map<ref parse.ActionNode, slice<@string>> actionNodeEdits = default, map<ref parse.TemplateNode, @string> templateNodeEdits = default, map<ref parse.TextNode, slice<byte>> textNodeEdits = default)
            {
                this.ns = ns;
                this.output = output;
                this.derived = derived;
                this.called = called;
                this.actionNodeEdits = actionNodeEdits;
                this.templateNodeEdits = templateNodeEdits;
                this.textNodeEdits = textNodeEdits;
            }

            // Enable comparisons between nil and escaper struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(escaper value, NilType nil) => value.Equals(default(escaper));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(escaper value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, escaper value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, escaper value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator escaper(NilType nil) => default(escaper);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static escaper escaper_cast(dynamic value)
        {
            return new escaper(ref value.ns, value.output, value.derived, value.called, value.actionNodeEdits, value.templateNodeEdits, value.textNodeEdits);
        }
    }
}}