msbuild .\SCurry.Builders\SCurry.Builders.csproj /v:m /m /t:Restore,Build

msbuild .\SCurry.Package.sln /v:m /m /t:Restore,TransformAll,Build