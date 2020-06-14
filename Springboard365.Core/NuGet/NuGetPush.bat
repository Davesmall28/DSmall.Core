SET packageVersion=2.0.0

NuGet.exe pack ../Springboard365.Core.csproj -Build -Symbols -Version %packageVersion% -Properties Configuration=Release

NuGet.exe push Springboard365.Core.%packageVersion%.nupkg -source "https://api.nuget.org/v3/index.json"

pause