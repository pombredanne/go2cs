//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct pthreadattr
        {
            // Constructors
            public pthreadattr(NilType _)
            {
                this.__pthread_attrp = default;
            }

            public pthreadattr(ref ptr<byte> __pthread_attrp = default)
            {
                this.__pthread_attrp = __pthread_attrp;
            }

            // Enable comparisons between nil and pthreadattr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pthreadattr value, NilType nil) => value.Equals(default(pthreadattr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pthreadattr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pthreadattr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pthreadattr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pthreadattr(NilType nil) => default(pthreadattr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static pthreadattr pthreadattr_cast(dynamic value)
        {
            return new pthreadattr(ref value.__pthread_attrp);
        }
    }
}