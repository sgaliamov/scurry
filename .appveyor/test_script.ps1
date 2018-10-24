if ($env:APPVEYOR_REPO_BRANCH -in "develop", "master") {
    Get-ChildItem .\**\*.Tests.csproj -Recurse | ForEach-Object {
        .\OpenCover.4.6.519\tools\OpenCover.Console.exe `
            -register:user `
            -target:"C:\Program Files\dotnet\dotnet.exe" `
            -targetargs:"test $_ --no-build -c $env:CONFIGURATION" `
            -output:"coverage.xml" `
            -oldstyle `
			-returntargetcode

		if (!$?) {
			throw "Tests for $_ failed."
		}

        bash .appveyor\codecov.sh -f "coverage.xml" -t $env:OpenCoverToken
    }
}
