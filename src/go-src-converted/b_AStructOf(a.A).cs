//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:55:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace @internal
{
    public static partial class b_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct A
        {
            // Value of the A struct
            private readonly a.A m_value;

            public A(a.A value) => m_value = value;

            // Enable implicit conversions between a.A and A struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator A(a.A value) => new A(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator a.A(A value) => value.m_value;
            
            // Enable comparisons between nil and A struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(A value, NilType nil) => value.Equals(default(A));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(A value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, A value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, A value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator A(NilType nil) => default(A);
        }
    }
}}}}}}