//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:40:38 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using httptrace = go.net.http.httptrace_package;
using @internal = go.net.http.@internal_package;
using textproto = go.net.textproto_package;
using reflect = go.reflect_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using httpguts = go.golang.org.x.net.http.httpguts_package;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct unsupportedTEError
        {
            // Constructors
            public unsupportedTEError(NilType _)
            {
                this.err = default;
            }

            public unsupportedTEError(@string err = default)
            {
                this.err = err;
            }

            // Enable comparisons between nil and unsupportedTEError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(unsupportedTEError value, NilType nil) => value.Equals(default(unsupportedTEError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(unsupportedTEError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, unsupportedTEError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, unsupportedTEError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator unsupportedTEError(NilType nil) => default(unsupportedTEError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static unsupportedTEError unsupportedTEError_cast(dynamic value)
        {
            return new unsupportedTEError(value.err);
        }
    }
}}