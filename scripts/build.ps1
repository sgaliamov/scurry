param(
    [string][Alias("c")]$configuration = "Debug",
    [switch][Alias("t")]$transform = $false,
    [switch][Alias("test")]$runTest = $false
)

$ErrorActionPreference = "Stop"

msbuild .\SCurry.sln /v:m /m /t:"Restore" /p:Configuration=$configuration

if ($transform) {
    Write-Host "Transforming..." -ForegroundColor Green
    msbuild .\src\SCurry.Builders\SCurry.Builders.csproj /v:m /m /t:"Build" /p:Configuration=$configuration
    msbuild .\scripts\SCurry.T4.sln /v:m /m /t:"TransformAll" /p:Configuration=$configuration
    Write-Host
}

Write-Host "Building..." -ForegroundColor Green
msbuild .\SCurry.sln /v:m /m /t:"Build" /p:Configuration=$configuration

if ($runTest) {
    Write-Host "`nTesting..." -ForegroundColor Green
    Get-ChildItem .\**\*.Tests.csproj -Recurse | ForEach-Object {
        dotnet test $_ -c $configuration --no-build
    }
}

Write-Host "Done." -ForegroundColor Green
Write-Host