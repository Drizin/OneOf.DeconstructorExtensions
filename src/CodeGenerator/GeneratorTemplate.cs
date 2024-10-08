﻿using CodegenCS;

public class GeneratorTemplate
{
	public void Main(ICodegenContext context)
	{
        string className; 
        string targetType;

        className = "OneOf"; targetType = "Tuple";
        GenerateToTupleClass(context[$"OneOf.ToTupleExtensions\\{className}ConvertTo{targetType}Extensions.generated.cs"], className, targetType);
        
        className = "OneOf"; targetType = "ValueTuple";
        GenerateToTupleClass(context[$"OneOf.ToTupleExtensions\\{className}ConvertTo{targetType}Extensions.generated.cs"], className, targetType);
        
        className = "OneOfBase"; targetType = "Tuple";
        GenerateToTupleClass(context[$"OneOf.ToTupleExtensions\\{className}ConvertTo{targetType}Extensions.generated.cs"], className, targetType);

        className = "OneOfBase"; targetType = "ValueTuple";
        GenerateToTupleClass(context[$"OneOf.ToTupleExtensions\\{className}ConvertTo{targetType}Extensions.generated.cs"], className, targetType);

        className = "OneOf";
        GenerateDeconstructClass(context[$"OneOf.DeconstructorExtensions\\{className}DeconstructExtensions.generated.cs"], className);
        
        className = "OneOfBase";
        GenerateDeconstructClass(context[$"OneOf.DeconstructorExtensions\\{className}DeconstructExtensions.generated.cs"], className);
    }

    static void GenerateToTupleClass(ICodegenOutputFile file, string className, string targetType)
    {
        file.WriteLine($$"""
            using System;
            namespace OneOf
            {
                #nullable enable
                /// <summary>
                /// Extensions that converts {{className}} into a {{targetType}} that can be desconstructed.
                /// Only one element of the Tuple will have a non-null value.
                /// All generic types of {{className}} should either be non-nullable value types or non-nullable reference types
                /// </summary>
                public static class {{className}}To{{targetType}}Extensions
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

                    {{GenerateToTupleExtensions(className, targetType)}}
                }
                #nullable disable
            }
            """);
    }

    static IEnumerable<FormattableString> GenerateToTupleExtensions(string className, string targetType)
    {
        // ValueTuple goes from T1 up to T7, so max number of combinations we can accept are Tuples with 7 elements (T0 to T6)
        // so maxTypes should be <= 7.
        int maxTypes = 7;
        for (int elements = 2; elements <= maxTypes; elements++)
        {
            // We want all combination of types "C" (non-nullable reference type) or "S" (non-nullable value types)
            char[] chars = new char[] { 'C', 'S' };

            var typesCombinations = GenerateStrings(chars, elements);
            foreach (var typesCombination in typesCombinations)
            {
                IEnumerable<char> types = typesCombination.ToCharArray();
                var typesStr = string.Join(", ", types.Select((type, i) => $"T{i}"));
                var typesWithNullables = string.Join(", ", types.Select((type, i) => type == 'C' ? $"T{i}?" : $"Nullable<T{i}>"));
                var namedTypesWithNullables = string.Join(", ", types.Select((type, i) => type == 'C' ? $"T{i}? T{i}" : $"Nullable<T{i}> T{i}"));
                var constraints = string.Join("\n", types.Select((type, i) => type == 'C' ? $"where T{i} : class" : $"where T{i} : struct"));
                var tupleValues = string.Join(",\n", types.Select((type, i) => type == 'C' ? $"oneOf.Index == {i} ? (T{i}?)oneOf.AsT{i} : null" : $"oneOf.Index == {i} ? (Nullable<T{i}>)oneOf.AsT{i} : null"));
                var dummyArguments = string.Join(", ", types.Select((type, i) => $"Require{(type == 'C' ? "Class" : "Struct")}<T{i}>? dummy{i} = null"));
                var resultConstructor = $"{targetType}<{typesWithNullables}>";

                // For Tuple we just declare Tuple<T0, T1, etc>, and the deconstruction unfortunately will be named Item1/Item2/etc. (indexes don't match types)
                // For ValueTuple we can use named parameters (T0 t0, T1 t1, etc), although the idea is that consumers will deconstruct into variables and won't even use these names
                string resultTypeDeclaration = (targetType == "Tuple") ?
                     $"{targetType}<{typesWithNullables}>" :
                     $"({namedTypesWithNullables})";

                yield return $$"""
                    /// <summary>
                    /// Converts the {{className}} into a {{targetType}}{} that can be desconstructed.
                    /// Only one element of the Tuple will have a non-null value.
                    /// All generic types of {{className}} should either be non-nullable value types or non-nullable reference types.
                    /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
                    /// </summary>
                    public static {{resultTypeDeclaration}} To{{targetType}}<{{typesStr}}>(this {{className}}<{{typesStr}}> oneOf, {{dummyArguments}})
                        {{constraints}}
                    {
                        return new {{resultConstructor}}(
                            {{tupleValues}}
                        );
                    }

                    """;
            }
        }
    }


    static void GenerateDeconstructClass(ICodegenOutputFile file, string className)
    {
        file.WriteLine($$"""
            using System;
            namespace OneOf
            {
                #nullable enable
                /// <summary>
                /// Extensions that deconstruct the {{className}}.
                /// Only one of the returned elements will have a non-null value.
                /// All generic types of {{className}} should either be non-nullable value types or non-nullable reference types
                /// </summary>
                public static class {{className}}DeconstructExtensions
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

                    {{GenerateDeconstructExtensions(className)}}
                }
                #nullable disable
            }
            """);
    }

    static IEnumerable<FormattableString> GenerateDeconstructExtensions(string className)
    {
        // We should create deconstructor for all combinations up to 9 elements (OneOf<T0...T8>)
        int maxTypes = 9;
        for (int elements = 2; elements <= maxTypes; elements++)
        {
            // We want all combination of types "C" (non-nullable reference type) or "S" (non-nullable value types)
            char[] chars = new char[] { 'C', 'S' };

            var typesCombinations = GenerateStrings(chars, elements);
            foreach (var typesCombination in typesCombinations)
            {
                IEnumerable<char> types = typesCombination.ToCharArray();
                var typesStr = string.Join(", ", types.Select((type, i) => $"T{i}"));
                var typesWithNullables = string.Join(", ", types.Select((type, i) => $"T{i}"));
                var namedTypesWithNullables = string.Join(", ", types.Select((type, i) => type == 'C' ? $"out T{i}? item{i}" : $"out Nullable<T{i}> item{i}"));
                var constraints = string.Join("\n", types.Select((type, i) => type == 'C' ? $"where T{i} : class" : $"where T{i} : struct"));
                var setValues = string.Join("\n", types.Select((type, i) => type == 'C' ? $"item{i} = (oneOf.Index == {i} ? (T{i}?)oneOf.AsT{i} : null);" : $"item{i} = (oneOf.Index == {i} ? (Nullable<T{i}>)oneOf.AsT{i} : null);"));

                yield return $$"""
                    /// <summary>
                    /// Deconstructs the {{className}}.
                    /// Only one element of the Tuple will have a non-null value.
                    /// All generic types of {{className}} should either be non-nullable value types or non-nullable reference types.
                    /// All optional parameters named "dummy" will be ignored - they are just used for compiler disambiguation (to find the right combination of reference-types and value-types)
                    /// </summary>
                    public static void Deconstruct<{{typesWithNullables}}>(this {{className}}<{{typesStr}}> oneOf, {{namedTypesWithNullables}})
                        {{constraints}}
                    {
                        {{setValues}}
                    }

                    """;
            }
        }
    }


    public static IEnumerable<String> GenerateStrings(IEnumerable<char> characters, int length)
    {
        if (length > 0)
        {
            foreach (char c in characters)
            {
                foreach (String suffix in GenerateStrings(characters, length - 1))
                {
                    yield return c + suffix;
                }
            }
        }
        else
        {
            yield return string.Empty;
        }
    }
}
