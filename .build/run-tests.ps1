Write-Information "Testing..."
New-Item -ItemType "directory" -Name "coverage"
Get-ChildItem .\**\*.Tests.csproj -Recurse | ForEach-Object {
    .\OpenCover.$($env:OpenCoverVersion)\tools\OpenCover.Console.exe `
        -register:user `
        -target:"C:\Program Files\dotnet\dotnet.exe" `
        -targetargs:"test $_" `
        -output:".\coverage\$($_.Name).coverage.xml" `
        -oldstyle
}

Get-ChildItem .\coverage\ -include *.coverage.xml -Recurse | ForEach-Object { Get-Content $_ } | Out-File .\coverage.xml
Write-Host "Publish test coverage..." -ForegroundColor Green
$env:PATH = 'C:\msys64\usr\bin;' + $env:PATH
bash .build\codecov.sh -f "coverage.xml" -t $env:OpenCoverToken