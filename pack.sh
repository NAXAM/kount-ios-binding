rm -rf KountDataCollector.iOS/bin
rm -rf KountDataCollector.iOS/obj

dotnet clean
dotnet restore
dotnet pack -c Release KountDataCollector.iOS/KountDataCollector.iOS.csproj

mv KountDataCollector.iOS/bin/Release/KountDataCollector.iOS*.nupkg nugets/