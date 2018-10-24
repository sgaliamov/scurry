param(
    [string][Alias("c")]$configuration = "Debug",
    [switch][Alias("t")]$transform = $false,
    [switch][Alias("test")]$runTest = $false
)

if ($transform) {
    Write-Host "Transforming..." -ForegroundColor Green
    msbuild .\SCurry.Builders\SCurry.Builders.csproj /v:m /m /t:"Restore,Build" /p:Configuration=$configuration
    msbuild .\.build\SCurry.T4.sln /v:m /m /t:"Restore,TransformAll" /p:Configuration=$configuration
    Write-Host
}

Write-Host "Building..." -ForegroundColor Green
msbuild .\SCurry.sln /v:m /m /t:"Restore,Build" /p:Configuration=$configuration

if ($runTest) {
    Write-Host
    Write-Host "Testing..." -ForegroundColor Green
    Get-ChildItem .\**\*.Tests.csproj -Recurse | ForEach-Object {
        dotnet test $_ -c $configuration --no-build
    }
}

Write-Host "Done." -ForegroundColor Green
Write-Host