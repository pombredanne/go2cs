//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:48 UTC
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
        private partial struct ucontext
        {
            // Constructors
            public ucontext(NilType _)
            {
                this.uc_flags = default;
                this.uc_link = default;
                this.uc_stack = default;
                this.uc_sigmask = default;
                this._pad = default;
                this._pad2 = default;
                this.uc_mcontext = default;
            }

            public ucontext(ulong uc_flags = default, ref ptr<ucontext> uc_link = default, stackt uc_stack = default, ulong uc_sigmask = default, array<byte> _pad = default, array<byte> _pad2 = default, sigcontext uc_mcontext = default)
            {
                this.uc_flags = uc_flags;
                this.uc_link = uc_link;
                this.uc_stack = uc_stack;
                this.uc_sigmask = uc_sigmask;
                this._pad = _pad;
                this._pad2 = _pad2;
                this.uc_mcontext = uc_mcontext;
            }

            // Enable comparisons between nil and ucontext struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ucontext value, NilType nil) => value.Equals(default(ucontext));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ucontext value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ucontext value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ucontext value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ucontext(NilType nil) => default(ucontext);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ucontext ucontext_cast(dynamic value)
        {
            return new ucontext(value.uc_flags, ref value.uc_link, value.uc_stack, value.uc_sigmask, value._pad, value._pad2, value.uc_mcontext);
        }
    }
}