﻿using System;
namespace OneOf
{
    #nullable enable
    /// <summary>
    /// Extensions that converts OneOfBase into a Tuple that can be desconstructed.
    /// Only one element of the Tuple will have a non-null value.
    /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types
    /// </summary>
    public static class OneOfBaseToTupleExtensions
    {
        /// <summary>
        /// Constraints are not part of the signature, but parameters are.
        /// Constraints in parameters are enforced during overload resolution, so we put the constraints in optional disambiguation parameters.
        /// </summary>
        public class RequireStruct<T> where T : struct { }

        /// <summary>
        /// Constraints are not part of the signature, but parameters are.
        /// Constraints in parameters are enforced during overload resolution, so we put the constraints in optional disambiguation parameters.
        /// </summary>
        public class RequireClass<T> where T : class { }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?> ToTuple<T0, T1>(this OneOfBase<T0, T1> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null)
            where T0 : class
            where T1 : class
        {
            return new Tuple<T0?, T1?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>> ToTuple<T0, T1>(this OneOfBase<T0, T1> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null)
            where T0 : class
            where T1 : struct
        {
            return new Tuple<T0?, Nullable<T1>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?> ToTuple<T0, T1>(this OneOfBase<T0, T1> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null)
            where T0 : struct
            where T1 : class
        {
            return new Tuple<Nullable<T0>, T1?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>> ToTuple<T0, T1>(this OneOfBase<T0, T1> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null)
            where T0 : struct
            where T1 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?> ToTuple<T0, T1, T2>(this OneOfBase<T0, T1, T2> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null)
            where T0 : class
            where T1 : class
            where T2 : class
        {
            return new Tuple<T0?, T1?, T2?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>> ToTuple<T0, T1, T2>(this OneOfBase<T0, T1, T2> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
        {
            return new Tuple<T0?, T1?, Nullable<T2>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?> ToTuple<T0, T1, T2>(this OneOfBase<T0, T1, T2> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
        {
            return new Tuple<T0?, Nullable<T1>, T2?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>> ToTuple<T0, T1, T2>(this OneOfBase<T0, T1, T2> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?> ToTuple<T0, T1, T2>(this OneOfBase<T0, T1, T2> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
        {
            return new Tuple<Nullable<T0>, T1?, T2?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>> ToTuple<T0, T1, T2>(this OneOfBase<T0, T1, T2> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?> ToTuple<T0, T1, T2>(this OneOfBase<T0, T1, T2> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>> ToTuple<T0, T1, T2>(this OneOfBase<T0, T1, T2> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, T3?> ToTuple<T0, T1, T2, T3>(this OneOfBase<T0, T1, T2, T3> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return new Tuple<T0?, T1?, T2?, T3?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, Nullable<T3>> ToTuple<T0, T1, T2, T3>(this OneOfBase<T0, T1, T2, T3> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : struct
        {
            return new Tuple<T0?, T1?, T2?, Nullable<T3>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, T3?> ToTuple<T0, T1, T2, T3>(this OneOfBase<T0, T1, T2, T3> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : class
        {
            return new Tuple<T0?, T1?, Nullable<T2>, T3?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>> ToTuple<T0, T1, T2, T3>(this OneOfBase<T0, T1, T2, T3> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : struct
        {
            return new Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, T3?> ToTuple<T0, T1, T2, T3>(this OneOfBase<T0, T1, T2, T3> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : class
        {
            return new Tuple<T0?, Nullable<T1>, T2?, T3?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>> ToTuple<T0, T1, T2, T3>(this OneOfBase<T0, T1, T2, T3> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : struct
        {
            return new Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?> ToTuple<T0, T1, T2, T3>(this OneOfBase<T0, T1, T2, T3> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : class
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>> ToTuple<T0, T1, T2, T3>(this OneOfBase<T0, T1, T2, T3> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : struct
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, T3?> ToTuple<T0, T1, T2, T3>(this OneOfBase<T0, T1, T2, T3> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : class
        {
            return new Tuple<Nullable<T0>, T1?, T2?, T3?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>> ToTuple<T0, T1, T2, T3>(this OneOfBase<T0, T1, T2, T3> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : struct
        {
            return new Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?> ToTuple<T0, T1, T2, T3>(this OneOfBase<T0, T1, T2, T3> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : class
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>> ToTuple<T0, T1, T2, T3>(this OneOfBase<T0, T1, T2, T3> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : struct
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?> ToTuple<T0, T1, T2, T3>(this OneOfBase<T0, T1, T2, T3> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>> ToTuple<T0, T1, T2, T3>(this OneOfBase<T0, T1, T2, T3> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?> ToTuple<T0, T1, T2, T3>(this OneOfBase<T0, T1, T2, T3> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>> ToTuple<T0, T1, T2, T3>(this OneOfBase<T0, T1, T2, T3> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, T3?, T4?> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return new Tuple<T0?, T1?, T2?, T3?, T4?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, T3?, Nullable<T4>> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : struct
        {
            return new Tuple<T0?, T1?, T2?, T3?, Nullable<T4>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, Nullable<T3>, T4?> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : class
        {
            return new Tuple<T0?, T1?, T2?, Nullable<T3>, T4?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, Nullable<T3>, Nullable<T4>> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : struct
        {
            return new Tuple<T0?, T1?, T2?, Nullable<T3>, Nullable<T4>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, T3?, T4?> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : class
        {
            return new Tuple<T0?, T1?, Nullable<T2>, T3?, T4?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, T3?, Nullable<T4>> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : struct
        {
            return new Tuple<T0?, T1?, Nullable<T2>, T3?, Nullable<T4>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, T4?> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : class
        {
            return new Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, T4?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : struct
        {
            return new Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, T3?, T4?> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return new Tuple<T0?, Nullable<T1>, T2?, T3?, T4?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, T3?, Nullable<T4>> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : struct
        {
            return new Tuple<T0?, Nullable<T1>, T2?, T3?, Nullable<T4>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, T4?> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : class
        {
            return new Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, T4?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : struct
        {
            return new Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, T4?> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : class
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, T4?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : struct
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : class
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, T3?, T4?> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return new Tuple<Nullable<T0>, T1?, T2?, T3?, T4?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, T3?, Nullable<T4>> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : struct
        {
            return new Tuple<Nullable<T0>, T1?, T2?, T3?, Nullable<T4>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, T4?> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : class
        {
            return new Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, T4?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, Nullable<T4>> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : struct
        {
            return new Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, Nullable<T4>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, T4?> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : class
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, T4?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, Nullable<T4>> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : struct
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, Nullable<T4>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, T4?> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : class
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, T4?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : struct
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, T4?> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, T4?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, Nullable<T4>> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, Nullable<T4>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, T4?> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, T4?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, T4?> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, T4?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>> ToTuple<T0, T1, T2, T3, T4>(this OneOfBase<T0, T1, T2, T3, T4> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, T3?, T4?, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return new Tuple<T0?, T1?, T2?, T3?, T4?, T5?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, T3?, T4?, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : struct
        {
            return new Tuple<T0?, T1?, T2?, T3?, T4?, Nullable<T5>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, T3?, Nullable<T4>, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : class
        {
            return new Tuple<T0?, T1?, T2?, T3?, Nullable<T4>, T5?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, T3?, Nullable<T4>, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : struct
        {
            return new Tuple<T0?, T1?, T2?, T3?, Nullable<T4>, Nullable<T5>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, Nullable<T3>, T4?, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : class
        {
            return new Tuple<T0?, T1?, T2?, Nullable<T3>, T4?, T5?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, Nullable<T3>, T4?, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : struct
        {
            return new Tuple<T0?, T1?, T2?, Nullable<T3>, T4?, Nullable<T5>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, Nullable<T3>, Nullable<T4>, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : class
        {
            return new Tuple<T0?, T1?, T2?, Nullable<T3>, Nullable<T4>, T5?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : struct
        {
            return new Tuple<T0?, T1?, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, T3?, T4?, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return new Tuple<T0?, T1?, Nullable<T2>, T3?, T4?, T5?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, T3?, T4?, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : struct
        {
            return new Tuple<T0?, T1?, Nullable<T2>, T3?, T4?, Nullable<T5>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, T3?, Nullable<T4>, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : class
        {
            return new Tuple<T0?, T1?, Nullable<T2>, T3?, Nullable<T4>, T5?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : struct
        {
            return new Tuple<T0?, T1?, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, T4?, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : class
        {
            return new Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, T4?, T5?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : struct
        {
            return new Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : class
        {
            return new Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
        {
            return new Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, T3?, T4?, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return new Tuple<T0?, Nullable<T1>, T2?, T3?, T4?, T5?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, T3?, T4?, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : struct
        {
            return new Tuple<T0?, Nullable<T1>, T2?, T3?, T4?, Nullable<T5>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, T3?, Nullable<T4>, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : class
        {
            return new Tuple<T0?, Nullable<T1>, T2?, T3?, Nullable<T4>, T5?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, T3?, Nullable<T4>, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : struct
        {
            return new Tuple<T0?, Nullable<T1>, T2?, T3?, Nullable<T4>, Nullable<T5>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, T4?, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : class
        {
            return new Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, T4?, T5?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, T4?, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : struct
        {
            return new Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, T4?, Nullable<T5>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : class
        {
            return new Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, T5?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : struct
        {
            return new Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, T4?, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, T4?, T5?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, T4?, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : struct
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, T4?, Nullable<T5>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : class
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, T5?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : struct
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : class
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, T5?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : struct
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : class
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, T3?, T4?, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return new Tuple<Nullable<T0>, T1?, T2?, T3?, T4?, T5?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, T3?, T4?, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : struct
        {
            return new Tuple<Nullable<T0>, T1?, T2?, T3?, T4?, Nullable<T5>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, T3?, Nullable<T4>, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : class
        {
            return new Tuple<Nullable<T0>, T1?, T2?, T3?, Nullable<T4>, T5?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, T3?, Nullable<T4>, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : struct
        {
            return new Tuple<Nullable<T0>, T1?, T2?, T3?, Nullable<T4>, Nullable<T5>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, T4?, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : class
        {
            return new Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, T4?, T5?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, T4?, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : struct
        {
            return new Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, T4?, Nullable<T5>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, Nullable<T4>, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : class
        {
            return new Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, Nullable<T4>, T5?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : struct
        {
            return new Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, T4?, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, T4?, T5?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, T4?, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : struct
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, T4?, Nullable<T5>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, Nullable<T4>, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : class
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, Nullable<T4>, T5?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : struct
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, T4?, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : class
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, T4?, T5?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : struct
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : class
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, T4?, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, T4?, T5?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, T4?, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, T4?, Nullable<T5>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, Nullable<T4>, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, Nullable<T4>, T5?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, Nullable<T4>, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, Nullable<T4>, Nullable<T5>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, T4?, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, T4?, T5?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, T4?, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, T4?, Nullable<T5>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, T5?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, T4?, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, T4?, T5?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, T4?, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, T4?, Nullable<T5>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, T5?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, T5?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>> ToTuple<T0, T1, T2, T3, T4, T5>(this OneOfBase<T0, T1, T2, T3, T4, T5> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, T3?, T4?, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
        {
            return new Tuple<T0?, T1?, T2?, T3?, T4?, T5?, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, T3?, T4?, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : struct
        {
            return new Tuple<T0?, T1?, T2?, T3?, T4?, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, T3?, T4?, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : struct
            where T6 : class
        {
            return new Tuple<T0?, T1?, T2?, T3?, T4?, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, T3?, T4?, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<T0?, T1?, T2?, T3?, T4?, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, T3?, Nullable<T4>, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : class
            where T6 : class
        {
            return new Tuple<T0?, T1?, T2?, T3?, Nullable<T4>, T5?, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, T3?, Nullable<T4>, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : class
            where T6 : struct
        {
            return new Tuple<T0?, T1?, T2?, T3?, Nullable<T4>, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, T3?, Nullable<T4>, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : struct
            where T6 : class
        {
            return new Tuple<T0?, T1?, T2?, T3?, Nullable<T4>, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, T3?, Nullable<T4>, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<T0?, T1?, T2?, T3?, Nullable<T4>, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, Nullable<T3>, T4?, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : class
            where T6 : class
        {
            return new Tuple<T0?, T1?, T2?, Nullable<T3>, T4?, T5?, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, Nullable<T3>, T4?, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : class
            where T6 : struct
        {
            return new Tuple<T0?, T1?, T2?, Nullable<T3>, T4?, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, Nullable<T3>, T4?, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : struct
            where T6 : class
        {
            return new Tuple<T0?, T1?, T2?, Nullable<T3>, T4?, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, Nullable<T3>, T4?, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<T0?, T1?, T2?, Nullable<T3>, T4?, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, Nullable<T3>, Nullable<T4>, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : class
            where T6 : class
        {
            return new Tuple<T0?, T1?, T2?, Nullable<T3>, Nullable<T4>, T5?, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, Nullable<T3>, Nullable<T4>, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : class
            where T6 : struct
        {
            return new Tuple<T0?, T1?, T2?, Nullable<T3>, Nullable<T4>, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : class
        {
            return new Tuple<T0?, T1?, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<T0?, T1?, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, T3?, T4?, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
        {
            return new Tuple<T0?, T1?, Nullable<T2>, T3?, T4?, T5?, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, T3?, T4?, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : struct
        {
            return new Tuple<T0?, T1?, Nullable<T2>, T3?, T4?, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, T3?, T4?, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : struct
            where T6 : class
        {
            return new Tuple<T0?, T1?, Nullable<T2>, T3?, T4?, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, T3?, T4?, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<T0?, T1?, Nullable<T2>, T3?, T4?, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, T3?, Nullable<T4>, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : class
            where T6 : class
        {
            return new Tuple<T0?, T1?, Nullable<T2>, T3?, Nullable<T4>, T5?, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, T3?, Nullable<T4>, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : class
            where T6 : struct
        {
            return new Tuple<T0?, T1?, Nullable<T2>, T3?, Nullable<T4>, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : struct
            where T6 : class
        {
            return new Tuple<T0?, T1?, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<T0?, T1?, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, T4?, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : class
            where T6 : class
        {
            return new Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, T4?, T5?, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, T4?, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : class
            where T6 : struct
        {
            return new Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, T4?, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : struct
            where T6 : class
        {
            return new Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : class
            where T6 : class
        {
            return new Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : class
            where T6 : struct
        {
            return new Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : class
        {
            return new Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<T0?, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, T3?, T4?, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
        {
            return new Tuple<T0?, Nullable<T1>, T2?, T3?, T4?, T5?, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, T3?, T4?, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : struct
        {
            return new Tuple<T0?, Nullable<T1>, T2?, T3?, T4?, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, T3?, T4?, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : struct
            where T6 : class
        {
            return new Tuple<T0?, Nullable<T1>, T2?, T3?, T4?, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, T3?, T4?, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<T0?, Nullable<T1>, T2?, T3?, T4?, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, T3?, Nullable<T4>, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : class
            where T6 : class
        {
            return new Tuple<T0?, Nullable<T1>, T2?, T3?, Nullable<T4>, T5?, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, T3?, Nullable<T4>, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : class
            where T6 : struct
        {
            return new Tuple<T0?, Nullable<T1>, T2?, T3?, Nullable<T4>, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, T3?, Nullable<T4>, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : struct
            where T6 : class
        {
            return new Tuple<T0?, Nullable<T1>, T2?, T3?, Nullable<T4>, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, T3?, Nullable<T4>, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<T0?, Nullable<T1>, T2?, T3?, Nullable<T4>, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, T4?, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : class
            where T6 : class
        {
            return new Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, T4?, T5?, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, T4?, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : class
            where T6 : struct
        {
            return new Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, T4?, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, T4?, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : struct
            where T6 : class
        {
            return new Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, T4?, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, T4?, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, T4?, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : class
            where T6 : class
        {
            return new Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, T5?, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : class
            where T6 : struct
        {
            return new Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : class
        {
            return new Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<T0?, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, T4?, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, T4?, T5?, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, T4?, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : struct
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, T4?, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, T4?, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : struct
            where T6 : class
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, T4?, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, T4?, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, T4?, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : class
            where T6 : class
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, T5?, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : class
            where T6 : struct
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : struct
            where T6 : class
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : class
            where T6 : class
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, T5?, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : class
            where T6 : struct
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : struct
            where T6 : class
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : class
            where T6 : class
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : class
            where T6 : struct
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : class
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireClass<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : class
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<T0?, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (T0?)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, T3?, T4?, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
        {
            return new Tuple<Nullable<T0>, T1?, T2?, T3?, T4?, T5?, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, T3?, T4?, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, T1?, T2?, T3?, T4?, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, T3?, T4?, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : struct
            where T6 : class
        {
            return new Tuple<Nullable<T0>, T1?, T2?, T3?, T4?, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, T3?, T4?, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, T1?, T2?, T3?, T4?, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, T3?, Nullable<T4>, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : class
            where T6 : class
        {
            return new Tuple<Nullable<T0>, T1?, T2?, T3?, Nullable<T4>, T5?, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, T3?, Nullable<T4>, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : class
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, T1?, T2?, T3?, Nullable<T4>, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, T3?, Nullable<T4>, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : struct
            where T6 : class
        {
            return new Tuple<Nullable<T0>, T1?, T2?, T3?, Nullable<T4>, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, T3?, Nullable<T4>, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, T1?, T2?, T3?, Nullable<T4>, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, T4?, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : class
            where T6 : class
        {
            return new Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, T4?, T5?, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, T4?, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : class
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, T4?, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, T4?, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : struct
            where T6 : class
        {
            return new Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, T4?, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, T4?, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, T4?, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, Nullable<T4>, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : class
            where T6 : class
        {
            return new Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, Nullable<T4>, T5?, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, Nullable<T4>, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : class
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, Nullable<T4>, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : class
        {
            return new Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, T1?, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, T4?, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, T4?, T5?, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, T4?, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, T4?, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, T4?, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : struct
            where T6 : class
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, T4?, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, T4?, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, T4?, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, Nullable<T4>, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : class
            where T6 : class
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, Nullable<T4>, T5?, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, Nullable<T4>, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : class
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, Nullable<T4>, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : struct
            where T6 : class
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, T4?, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : class
            where T6 : class
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, T4?, T5?, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, T4?, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : class
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, T4?, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : struct
            where T6 : class
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : class
            where T6 : class
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : class
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : class
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireClass<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : class
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, T1?, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (T1?)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, T4?, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, T4?, T5?, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, T4?, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, T4?, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, T4?, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : struct
            where T6 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, T4?, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, T4?, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, T4?, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, Nullable<T4>, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : class
            where T6 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, Nullable<T4>, T5?, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, Nullable<T4>, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : class
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, Nullable<T4>, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, Nullable<T4>, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : struct
            where T6 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, Nullable<T4>, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, Nullable<T4>, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : class
            where T4 : struct
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, T3?, Nullable<T4>, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, T4?, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : class
            where T6 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, T4?, T5?, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, T4?, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : class
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, T4?, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, T4?, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : struct
            where T6 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, T4?, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, T4?, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : class
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, T4?, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : class
            where T6 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, T5?, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : class
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireClass<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : class
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, T2?, Nullable<T3>, Nullable<T4>, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (T2?)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, T4?, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, T4?, T5?, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, T4?, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, T4?, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, T4?, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : struct
            where T6 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, T4?, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, T4?, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : class
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, T4?, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : class
            where T6 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, T5?, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : class
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : struct
            where T6 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireClass<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : class
            where T4 : struct
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, T3?, Nullable<T4>, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (T3?)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : class
            where T6 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, T5?, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : class
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : struct
            where T6 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireClass<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : class
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, T4?, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (T4?)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : class
            where T6 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireClass<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : class
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, T5?, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (T5?)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>, T6?> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireClass<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : class
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>, T6?>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (T6?)oneOf.AsT6 : null
            );
        }

        /// <summary>
        /// Converts the OneOfBase into a Tuple{} that can be desconstructed.
        /// Only one element of the Tuple will have a non-null value.
        /// All generic types of OneOfBase should either be non-nullable value types or non-nullable reference types.
        /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
        /// </summary>
        public static Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>, Nullable<T6>> ToTuple<T0, T1, T2, T3, T4, T5, T6>(this OneOfBase<T0, T1, T2, T3, T4, T5, T6> oneOf, RequireStruct<T0>? dummy0 = null, RequireStruct<T1>? dummy1 = null, RequireStruct<T2>? dummy2 = null, RequireStruct<T3>? dummy3 = null, RequireStruct<T4>? dummy4 = null, RequireStruct<T5>? dummy5 = null, RequireStruct<T6>? dummy6 = null)
            where T0 : struct
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
            where T5 : struct
            where T6 : struct
        {
            return new Tuple<Nullable<T0>, Nullable<T1>, Nullable<T2>, Nullable<T3>, Nullable<T4>, Nullable<T5>, Nullable<T6>>(
                oneOf.Index == 0 ? (Nullable<T0>)oneOf.AsT0 : null,
                oneOf.Index == 1 ? (Nullable<T1>)oneOf.AsT1 : null,
                oneOf.Index == 2 ? (Nullable<T2>)oneOf.AsT2 : null,
                oneOf.Index == 3 ? (Nullable<T3>)oneOf.AsT3 : null,
                oneOf.Index == 4 ? (Nullable<T4>)oneOf.AsT4 : null,
                oneOf.Index == 5 ? (Nullable<T5>)oneOf.AsT5 : null,
                oneOf.Index == 6 ? (Nullable<T6>)oneOf.AsT6 : null
            );
        }

    }
    #nullable disable
}
