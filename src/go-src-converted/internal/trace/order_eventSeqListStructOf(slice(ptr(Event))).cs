//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:42:26 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace @internal
{
    public static partial class trace_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct eventSeqList
        {
            // Value of the eventSeqList struct
            private readonly slice<ptr<Event>> m_value;

            public eventSeqList(slice<ptr<Event>> value) => m_value = value;

            // Enable implicit conversions between slice<ptr<Event>> and eventSeqList struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator eventSeqList(slice<ptr<Event>> value) => new eventSeqList(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ptr<Event>>(eventSeqList value) => value.m_value;
            
            // Enable comparisons between nil and eventSeqList struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(eventSeqList value, NilType nil) => value.Equals(default(eventSeqList));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(eventSeqList value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, eventSeqList value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, eventSeqList value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator eventSeqList(NilType nil) => default(eventSeqList);
        }
    }
}}