
write-host "**************************" -foreground "Cyan"
write-host "*   Packaging to nuget   *" -foreground "Cyan"
write-host "**************************" -foreground "Cyan"

#$location  = "C:\Sources\NoSqlRepositories";
$location  = $env:APPVEYOR_BUILD_FOLDER

$locationNuspec = $location + "\nuspec"
$locationNuspec
	
Set-Location -Path $locationNuspec

$strPath = $location + '\MvvX.Plugins.LiteDb\bin\Release\MvvX.Plugins.LiteDb.dll'

$VersionInfos = [System.Diagnostics.FileVersionInfo]::GetVersionInfo($strPath)
$ProductVersion = $VersionInfos.ProductVersion
write-host "Product version : " $ProductVersion -foreground "Green"

write-host "Packaging to nuget..." -foreground "Magenta"

write-host "Update nuspec versions" -foreground "Green"

write-host "Update nuspec versions MvvX.Plugins.LiteDb.nuspec" -foreground "DarkGray"
$nuSpecFile =  $locationNuspec + '\MvvX.Plugins.LiteDb.nuspec'
(Get-Content $nuSpecFile) | 
Foreach-Object {$_ -replace "{BuildNumberVersion}", "$ProductVersion" } | 
Set-Content $nuSpecFile

write-host "Generate nuget packages" -foreground "Green"

write-host "Generate nuget package for MvvX.Plugins.LiteDb.nuspec" -foreground "DarkGray"
.\NuGet.exe pack MvvX.Plugins.LiteDb.nuspec

$apiKey = $env:NuGetApiKey
	
write-host "Publish nuget packages" -foreground "Green"

write-host MvvX.Plugins.LiteDb.$ProductVersion.nupkg -foreground "DarkGray"
.\NuGet push MvvX.Plugins.LiteDb.$ProductVersion.nupkg -Source https://www.nuget.org/api/v2/package -ApiKey $apiKey