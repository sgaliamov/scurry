param(
    [string][Alias("c")]$configuration = "Debug"
)

Write-Host "Transforming..." -ForegroundColor Green
msbuild .\SCurry.Builders\SCurry.Builders.csproj /v:m /m /t:Restore,Build /p:Configuration=$configuration
msbuild .\.build\SCurry.T4.sln /v:m /m /t:Restore,TransformAll /p:Configuration=$configuration

Write-Host
Write-Host "Building..." -ForegroundColor Green
msbuild .\SCurry.sln /v:m /m /t:Restore,Build /p:Configuration=$configuration

Write-Host "Done." -ForegroundColor Green
Write-Host