param(
    [switch][Alias("c")]$cleanCode
)

Remove-Item ".\*\obj\*" -Force -Recurse
Remove-Item ".\*\bin\*" -Force -Recurse

if ($cleanCode) {
    Get-ChildItem ".\*\*.tt" -Recurse | ForEach-Object {
        Remove-Item $([io.path]::ChangeExtension($_.FullName, "cs")) -Force -ErrorAction Ignore
    }
}