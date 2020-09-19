//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:48:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using log = go.log_package;
using os = go.os_package;
using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class bio_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(bufio.Writer))]
        public partial struct Writer
        {
            // Writer structure promotion - sourced from pointer
            private readonly ptr<Writer> m_WriterRef;

            private ref Writer Writer_ptr => ref m_WriterRef.Value;

            public ref error err => ref m_WriterRef.Value.err;

            public ref slice<byte> buf => ref m_WriterRef.Value.buf;

            public ref long n => ref m_WriterRef.Value.n;

            public ref io.Writer wr => ref m_WriterRef.Value.wr;

            // Constructors
            public Writer(NilType _)
            {
                this.f = default;
                this.m_WriterRef = new ptr<bufio.Writer>(new bufio.Writer(nil));
            }

            public Writer(ref ptr<os.File> f = default, ref bufio.Writer Writer = default)
            {
                this.f = f;
                this.m_WriterRef = new ptr<bufio.Writer>(ref Writer);
            }

            // Enable comparisons between nil and Writer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Writer value, NilType nil) => value.Equals(default(Writer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Writer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Writer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Writer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Writer(NilType nil) => default(Writer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Writer Writer_cast(dynamic value)
        {
            return new Writer(ref value.f, ref value.Writer);
        }
    }
}}}