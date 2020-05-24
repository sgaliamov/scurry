param(
    [string][Alias("c")]$configuration = "Debug",
    [switch][Alias("t")]$transform = $false,
    [switch][Alias("test")]$runTest = $false,
    [switch]$clean = $false
)

$ErrorActionPreference = "Stop"

if ($clean) {
    .\scripts\clean.ps1 -c
    Write-Host
}

if ($transform) {
    Write-Host "Transforming..." -ForegroundColor Green
    dotnet build .\src\SCurry.Builders\SCurry.Builders.csproj -c $configuration
    msbuild .\scripts\SCurry.T4.sln /v:m /m /t:"TransformAll" /p:Configuration=$configuration
    Write-Host
}

Write-Host "Building..." -ForegroundColor Green
msbuild .\SCurry.sln /v:m /m /t:"Restore,Build" /p:Configuration=$configuration

if ($runTest) {
    Write-Host "`nTesting..." -ForegroundColor Green
    Get-ChildItem .\**\*.Tests.csproj -Recurse | ForEach-Object {
        dotnet test $_ -c $configuration --no-build
    }
}

Write-Host "Done." -ForegroundColor Green
Write-Host