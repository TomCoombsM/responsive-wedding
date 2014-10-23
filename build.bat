C:\Windows\Microsoft.NET\Framework64\v4.0.30319\msbuild.exe /t:Rebuild /p:configuration=release;RunOctoPack=true /fileLogger /flp:logfile=buildlog.txt /flp1:logfile=builderrors.txt;errorsonly /flp2:logfile=buildwarnings.txt;warningsonly dotnnet\Wedding\wedding.sln



dotnnet\Wedding\.nuget\NuGet.exe push "C:\Program Files (x86)\Go Agent\pipelines\Wedding\dotnnet\Wedding\wedding3\bin\wedding3.1.0.0.0.nupkg" -ApiKey API-WLVJX7Z98ZHLDAX4MGX9LTNDXG8 -Source http://goserver/nuget/packages