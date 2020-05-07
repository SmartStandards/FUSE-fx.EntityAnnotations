nuget pack ./EntityAnnotations.nuspec -Build -Symbols -OutputDirectory "..\(NuGetRepo)" -InstallPackageToOutputPath
IF NOT EXIST "..\(NuGetRepo)" GOTO NOCOPYTOGLOBALREPO
xcopy ".\(Stage)\Packages\*.nuspec" "..\(NuGetRepo)\" /d /r /y /s
xcopy ".\(Stage)\Packages\*.nupkg*" "..\(NuGetRepo)\" /d /r /y /s
:NOCOPYTOGLOBALREPO
PAUSE