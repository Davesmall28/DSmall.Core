SET packageVersion=1.1.0

NuGet.exe pack ../Springboard365.Core.csproj -Build -symbols -Version %packageVersion%

NuGet.exe push Springboard365.Core.%packageVersion%.nupkg

pause