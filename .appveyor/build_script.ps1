if ($env:APPVEYOR_REPO_BRANCH -eq "master") {
    ..\build.ps1 $env:CONFIGURATION
} else {
    ..\build.ps1 Debug
}
