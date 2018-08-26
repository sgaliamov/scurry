msbuild .\SCurry.Builders\SCurry.Builders.csproj /v:m /m /t:Restore,Build

msbuild .\.build\SCurry.T4.sln /v:m /m /t:Restore,TransformAll,Build