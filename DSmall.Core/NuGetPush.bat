..\NuGet\NuGet.exe pack DSmall.Core.csproj -Build -symbols -Properties Configuration=Release

..\NuGet\NuGet push DSmall.Core.1.0.5.nupkg

pause