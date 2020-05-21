if ($env:APPVEYOR_REPO_BRANCH -eq "master") {
    dotnet pack --include-source --include-symbols --no-build --no-dependencies -o .\publish

    # Get-ChildItem ".\**\*.nupkg" -Recurse | ForEach-Object {
    #     Push-AppveyorArtifact $_.FullName -FileName $_.Name -DeploymentName "nuget-package"
    # }
}
