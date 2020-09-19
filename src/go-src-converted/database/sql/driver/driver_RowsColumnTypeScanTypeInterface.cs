//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:10:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using errors = go.errors_package;
using reflect = go.reflect_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace database {
namespace sql
{
    public static partial class driver_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface RowsColumnTypeScanType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static RowsColumnTypeScanType As<T>(in T target) => (RowsColumnTypeScanType<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static RowsColumnTypeScanType As<T>(ptr<T> target_ptr) => (RowsColumnTypeScanType<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static RowsColumnTypeScanType? As(object target) =>
                typeof(RowsColumnTypeScanType<>).CreateInterfaceHandler<RowsColumnTypeScanType>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class RowsColumnTypeScanType<T> : RowsColumnTypeScanType
        {
            private T m_target;
            private readonly ptr<T>? m_target_ptr;
            private readonly bool m_target_is_ptr;

            public ref T Target
            {
                get
                {
                    if (m_target_is_ptr && !(m_target_ptr is null))
                        return ref m_target_ptr.Value;

                    return ref m_target;
                }
            }

            public RowsColumnTypeScanType(in T target) => m_target = target;

            public RowsColumnTypeScanType(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate reflect.Type ColumnTypeScanTypeByRef(ref T value, long index);
            private delegate reflect.Type ColumnTypeScanTypeByVal(T value, long index);

            private static readonly ColumnTypeScanTypeByRef s_ColumnTypeScanTypeByRef;
            private static readonly ColumnTypeScanTypeByVal s_ColumnTypeScanTypeByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public reflect.Type ColumnTypeScanType(long index)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_ColumnTypeScanTypeByRef is null)
                    return s_ColumnTypeScanTypeByVal!(target, index);

                return s_ColumnTypeScanTypeByRef(ref target, index);
            }

            private delegate error ColumnsByRef(ref T value);
            private delegate error ColumnsByVal(T value);

            private static readonly ColumnsByRef s_ColumnsByRef;
            private static readonly ColumnsByVal s_ColumnsByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error Columns()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_ColumnsByRef is null)
                    return s_ColumnsByVal!(target);

                return s_ColumnsByRef(ref target);
            }

            private delegate error CloseByRef(ref T value);
            private delegate error CloseByVal(T value);

            private static readonly CloseByRef s_CloseByRef;
            private static readonly CloseByVal s_CloseByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error Close()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_CloseByRef is null)
                    return s_CloseByVal!(target);

                return s_CloseByRef(ref target);
            }

            private delegate error NextByRef(ref T value, slice<Value> dest);
            private delegate error NextByVal(T value, slice<Value> dest);

            private static readonly NextByRef s_NextByRef;
            private static readonly NextByVal s_NextByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error Next(slice<Value> dest)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_NextByRef is null)
                    return s_NextByVal!(target, dest);

                return s_NextByRef(ref target, dest);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static RowsColumnTypeScanType()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("ColumnTypeScanType");

                if (!(extensionMethod is null))
                    s_ColumnTypeScanTypeByRef = extensionMethod.CreateStaticDelegate(typeof(ColumnTypeScanTypeByRef)) as ColumnTypeScanTypeByRef;

                if (s_ColumnTypeScanTypeByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("ColumnTypeScanType");

                    if (!(extensionMethod is null))
                        s_ColumnTypeScanTypeByVal = extensionMethod.CreateStaticDelegate(typeof(ColumnTypeScanTypeByVal)) as ColumnTypeScanTypeByVal;
                }

                if (s_ColumnTypeScanTypeByRef is null && s_ColumnTypeScanTypeByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement RowsColumnTypeScanType.ColumnTypeScanType method", new Exception("ColumnTypeScanType"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Columns");

                if (!(extensionMethod is null))
                    s_ColumnsByRef = extensionMethod.CreateStaticDelegate(typeof(ColumnsByRef)) as ColumnsByRef;

                if (s_ColumnsByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Columns");

                    if (!(extensionMethod is null))
                        s_ColumnsByVal = extensionMethod.CreateStaticDelegate(typeof(ColumnsByVal)) as ColumnsByVal;
                }

                if (s_ColumnsByRef is null && s_ColumnsByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement RowsColumnTypeScanType.Columns method", new Exception("Columns"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Close");

                if (!(extensionMethod is null))
                    s_CloseByRef = extensionMethod.CreateStaticDelegate(typeof(CloseByRef)) as CloseByRef;

                if (s_CloseByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Close");

                    if (!(extensionMethod is null))
                        s_CloseByVal = extensionMethod.CreateStaticDelegate(typeof(CloseByVal)) as CloseByVal;
                }

                if (s_CloseByRef is null && s_CloseByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement RowsColumnTypeScanType.Close method", new Exception("Close"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Next");

                if (!(extensionMethod is null))
                    s_NextByRef = extensionMethod.CreateStaticDelegate(typeof(NextByRef)) as NextByRef;

                if (s_NextByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Next");

                    if (!(extensionMethod is null))
                        s_NextByVal = extensionMethod.CreateStaticDelegate(typeof(NextByVal)) as NextByVal;
                }

                if (s_NextByRef is null && s_NextByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement RowsColumnTypeScanType.Next method", new Exception("Next"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator RowsColumnTypeScanType<T>(in ptr<T> target_ptr) => new RowsColumnTypeScanType<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator RowsColumnTypeScanType<T>(in T target) => new RowsColumnTypeScanType<T>(target);

            // Enable comparisons between nil and RowsColumnTypeScanType<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RowsColumnTypeScanType<T> value, NilType nil) => Activator.CreateInstance<RowsColumnTypeScanType<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RowsColumnTypeScanType<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RowsColumnTypeScanType<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RowsColumnTypeScanType<T> value) => value != nil;
        }
    }
}}}

namespace go
{
    public static class driver_RowsColumnTypeScanTypeExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.database.sql.driver_package.RowsColumnTypeScanType target)
        {
            try
            {
                return ((go.database.sql.driver_package.RowsColumnTypeScanType<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.database.sql.driver_package.RowsColumnTypeScanType target, out T result)
        {
            try
            {
                result = target._<T>();
                return true;
            }
            catch (PanicException)
            {
                result = default!;
                return false;
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static object? _(this go.database.sql.driver_package.RowsColumnTypeScanType target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.database.sql.driver_package.RowsColumnTypeScanType<>).GetExplicitGenericConversionOperator(type));

                if (conversionOperator is null)
                    throw new PanicException($"interface conversion: failed to create converter for {GetGoTypeName(target.GetType())} to {GetGoTypeName(type)}");

                dynamic? result = conversionOperator.Invoke(null, new object[] { target });
                return result?.Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(type)}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _(this go.database.sql.driver_package.RowsColumnTypeScanType target, Type type, out object? result)
        {
            try
            {
                result = target._(type);
                return true;
            }
            catch (PanicException)
            {
                result = type.IsValueType ? Activator.CreateInstance(type) : null;
                return false;
            }
        }
    }
}