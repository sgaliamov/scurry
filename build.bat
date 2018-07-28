msbuild .\SCurry.Builders.sln /v:m /m /t:Restore,Build
msbuild .\SCurry.sln /v:m /m /t:Restore,TransformAll,Build