//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:26 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct PollFd
        {
            // Constructors
            public PollFd(NilType _)
            {
                this.Fd = default;
                this.Events = default;
                this.Revents = default;
            }

            public PollFd(int Fd = default, short Events = default, short Revents = default)
            {
                this.Fd = Fd;
                this.Events = Events;
                this.Revents = Revents;
            }

            // Enable comparisons between nil and PollFd struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PollFd value, NilType nil) => value.Equals(default(PollFd));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PollFd value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PollFd value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PollFd value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PollFd(NilType nil) => default(PollFd);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static PollFd PollFd_cast(dynamic value)
        {
            return new PollFd(value.Fd, value.Events, value.Revents);
        }
    }
}}}}}}