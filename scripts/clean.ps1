param(
    [switch][Alias("c")]$cleanCode
)

$ErrorActionPreference = "Stop"

Write-Host "Cleaning..." -ForegroundColor Green

Get-ChildItem -Include bin, obj -Recurse | Remove-Item -Force -Recurse

if ($cleanCode) {
    Get-ChildItem ".\**\*.tt" -Recurse | ForEach-Object {
        Remove-Item $([io.path]::ChangeExtension($_.FullName, "generated.cs")) -Force -ErrorAction Ignore
    }
}

Write-Host
