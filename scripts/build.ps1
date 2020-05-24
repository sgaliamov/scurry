param(
    [string][Alias("c")]$configuration = "Debug",
    [switch][Alias("t")]$transform = $false,
    [switch][Alias("test")]$runTest = $false,
    [switch][Alias("p")]$publish = $false,
    [switch]$clean = $false
)

$ErrorActionPreference = "Stop"

if ($clean) {
    .\scripts\clean.ps1 -c
}

dotnet restore .\SCurry.sln

if ($transform) {
    Write-Host "`nTransforming..." -ForegroundColor Green
    dotnet build .\src\SCurry.Builders\SCurry.Builders.csproj --no-restore -c $configuration
    msbuild .\scripts\SCurry.T4.sln /v:m /m /t:"TransformAll" /p:Configuration=$configuration
    Write-Host
}

Write-Host "Building..." -ForegroundColor Green
dotnet build .\SCurry.sln -c $configuration --no-restore

if ($runTest) {
    Write-Host "`nTesting..." -ForegroundColor Green
    Get-ChildItem .\**\*.Tests.csproj -Recurse | ForEach-Object {
        dotnet test $_ -c $configuration --no-restore
    }
}

if ($publish) {
    dotnet pack --include-source --include-symbols --no-restore --no-dependencies -c $configuration -o .\publish
}

Write-Host "`nDone.`n" -ForegroundColor Green
