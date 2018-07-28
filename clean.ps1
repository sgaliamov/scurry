Remove-Item ".\*\obj\" -Force -Recurse
Remove-Item ".\*\bin\" -Force -Recurse
Get-ChildItem ".\*.tt" -Recurse | ForEach-Object {
    Remove-Item $([io.path]::ChangeExtension($_.FullName, "cs")) -Force -ErrorAction Ignore
}