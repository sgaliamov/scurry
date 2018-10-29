# Creates artifacts

if ($env:APPVEYOR_REPO_BRANCH -eq "master") {
    dotnet pack .\SCurry\ --include-source --include-symbols --no-build --no-dependencies

    Get-ChildItem ".\SCurry\**\*.nupkg" -Recurse | ForEach-Object {
        Push-AppveyorArtifact $_.FullName -FileName $_.Name -DeploymentName "nuget-package"
    }
}
