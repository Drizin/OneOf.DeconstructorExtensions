[cmdletbinding()]
param(
    [Parameter(Mandatory=$False)]
    [ValidateSet('Release','Debug')]
    [string]$configuration
)

# How to run:
# .\build.ps1
# or
# .\build.ps1 -configuration Debug


$scriptpath = $MyInvocation.MyCommand.Path
$dir = Split-Path $scriptpath
Push-Location $dir

if (-not $PSBoundParameters.ContainsKey('configuration'))
{
	if (Test-Path Release.snk) { $configuration = "Release"; } else { $configuration = "Debug"; }
}
Write-Host "Using configuration $configuration..." -ForegroundColor Yellow

$msbuild = ( 
    "$Env:programfiles\Microsoft Visual Studio\2022\*\MSBuild\15.0\Bin\msbuild.exe",
    "$Env:programfiles (x86)\Microsoft Visual Studio\2022\*\MSBuild\15.0\Bin\msbuild.exe",
    "$Env:programfiles\Microsoft Visual Studio\2022\*\MSBuild\*\Bin\msbuild.exe",
    "$Env:programfiles (x86)\Microsoft Visual Studio\2022\*\MSBuild\*\Bin\msbuild.exe",
    "$Env:programfiles\Microsoft Visual Studio\2019\*\MSBuild\*\Bin\msbuild.exe",
    "$Env:programfiles (x86)\Microsoft Visual Studio\2019\*\MSBuild\*\Bin\msbuild.exe",
    "${Env:ProgramFiles(x86)}\MSBuild\15.0\Bin\MSBuild.exe",
    "${Env:ProgramFiles(x86)}\MSBuild\14.0\Bin\MSBuild.exe"
) | Where-Object { Test-Path $_ } | Select-Object -first 1


Remove-Item -Recurse -Force -ErrorAction Ignore ".\packages-local"
Remove-Item -Recurse -Force -ErrorAction Ignore "$env:HOMEDRIVE$env:HOMEPATH\.nuget\packages\oneof.totupleextensions"

New-Item -ItemType Directory -Force -Path ".\packages-local"


try {

	# when target frameworks are added/modified dotnet clean might fail and we may need to cleanup the old dependency tree
	Get-ChildItem .\ -Recurse | Where{$_.FullName -CMatch ".*\\bin$" -and $_.PSIsContainer} | Remove-Item -Recurse -Force -ErrorAction Ignore
	Get-ChildItem .\ -Recurse | Where{$_.FullName -CMatch ".*\\obj$" -and $_.PSIsContainer} | Remove-Item -Recurse -Force -ErrorAction Ignore
	Get-ChildItem .\ -Recurse | Where{$_.FullName -Match ".*\\obj\\.*project.assets.json$"} | Remove-Item
	Get-ChildItem .\ -Recurse | Where{$_.FullName -Match ".*\.csproj$" -and $_.FullName -NotMatch ".*\\VSExtensions\\" } | ForEach { dotnet clean $_.FullName }

	dotnet clean OneOf.DeconstructorExtensions.sln
	dotnet clean OneOf.DeconstructorExtensions\OneOf.DeconstructorExtensions.csproj
	dotnet clean OneOf.DeconstructorExtensions\OneOf.ToTupleExtensions.csproj
	
	dotnet restore OneOf.DeconstructorExtensions.sln

	
	# OneOf.DeconstructorExtensions + nupkg/snupkg (dotnet build is the best at restoring packages; but for deterministic builds we need msbuild)
	dotnet build -c release OneOf.DeconstructorExtensions\OneOf.DeconstructorExtensions.csproj
	& $msbuild "OneOf.DeconstructorExtensions\OneOf.DeconstructorExtensions.csproj" `
			   /t:Pack                                        `
			   /p:PackageOutputPath="..\packages-local\"      `
			   '/p:targetFrameworks="net45;netstandard1.3;netstandard2.0"'  `
			   /p:Configuration=$configuration                `
			   /p:IncludeSymbols=true                         `
			   /p:SymbolPackageFormat=snupkg                  `
			   /verbosity:minimal                             `
			   /p:ContinuousIntegrationBuild=true
	if (! $?) { throw "msbuild failed" }

	# OneOf.ToTupleExtensions + nupkg/snupkg (dotnet build is the best at restoring packages; but for deterministic builds we need msbuild)
	dotnet build -c release OneOf.ToTupleExtensions\OneOf.ToTupleExtensions.csproj
	& $msbuild "OneOf.ToTupleExtensions\OneOf.ToTupleExtensions.csproj" `
			   /t:Pack                                        `
			   /p:PackageOutputPath="..\packages-local\"      `
			   '/p:targetFrameworks="net45;netstandard1.3;netstandard2.0"'  `
			   /p:Configuration=$configuration                `
			   /p:IncludeSymbols=true                         `
			   /p:SymbolPackageFormat=snupkg                  `
			   /verbosity:minimal                             `
			   /p:ContinuousIntegrationBuild=true
	if (! $?) { throw "msbuild failed" }

} finally {
    Pop-Location
}


# Unit tests
if ($configuration -eq "Debug")
{
    dotnet build -c release OneOf.ToTupleExtensions.Tests\OneOf.ToTupleExtensions.Tests.csproj
    dotnet test  OneOf.ToTupleExtensions.Tests\OneOf.ToTupleExtensions.Tests.csproj
}
