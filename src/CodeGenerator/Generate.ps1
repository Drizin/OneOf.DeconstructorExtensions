# This is requivalent of running Program.cs
dotnet tool install -g dotnet-codegencs
dotnet-codegencs template run $PSScriptRoot\GeneratorTemplate.cs --OutputFolder $PSScriptRoot\..\OneOf.ToTupleExtensions