//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:37:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using io = go.io_package;
using sync = go.sync_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct dirent
        {
            // Constructors
            public dirent(NilType _)
            {
                this.name = default;
                this.inode = default;
            }

            public dirent(@string name = default, ref ptr<inode> inode = default)
            {
                this.name = name;
                this.inode = inode;
            }

            // Enable comparisons between nil and dirent struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dirent value, NilType nil) => value.Equals(default(dirent));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dirent value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dirent value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dirent value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dirent(NilType nil) => default(dirent);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static dirent dirent_cast(dynamic value)
        {
            return new dirent(value.name, ref value.inode);
        }
    }
}