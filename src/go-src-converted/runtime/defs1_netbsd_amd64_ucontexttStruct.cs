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
        private partial struct ucontextt
        {
            // Constructors
            public ucontextt(NilType _)
            {
                this.uc_flags = default;
                this.pad_cgo_0 = default;
                this.uc_link = default;
                this.uc_sigmask = default;
                this.uc_stack = default;
                this.uc_mcontext = default;
            }

            public ucontextt(uint uc_flags = default, array<byte> pad_cgo_0 = default, ref ptr<ucontextt> uc_link = default, sigset uc_sigmask = default, stackt uc_stack = default, mcontextt uc_mcontext = default)
            {
                this.uc_flags = uc_flags;
                this.pad_cgo_0 = pad_cgo_0;
                this.uc_link = uc_link;
                this.uc_sigmask = uc_sigmask;
                this.uc_stack = uc_stack;
                this.uc_mcontext = uc_mcontext;
            }

            // Enable comparisons between nil and ucontextt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ucontextt value, NilType nil) => value.Equals(default(ucontextt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ucontextt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ucontextt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ucontextt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ucontextt(NilType nil) => default(ucontextt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ucontextt ucontextt_cast(dynamic value)
        {
            return new ucontextt(value.uc_flags, value.pad_cgo_0, ref value.uc_link, value.uc_sigmask, value.uc_stack, value.uc_mcontext);
        }
    }
}