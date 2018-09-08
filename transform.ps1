msbuild .\SCurry.Builders\SCurry.Builders.csproj /v:m /m /t:Restore,Build /p:Configuration=Release

msbuild .\.build\SCurry.T4.sln /v:m /m /t:Restore,TransformAll,Build /p:Configuration=Release