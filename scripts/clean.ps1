param(
    [switch][Alias("c")]$cleanCode
)

Remove-Item \obj, \bin -Force -Recurse

if ($cleanCode) {
    Get-ChildItem ".\*\*.tt" -Recurse | ForEach-Object {
        Remove-Item $([io.path]::ChangeExtension($_.FullName, "generated.cs")) -Force -ErrorAction Ignore
    }
}