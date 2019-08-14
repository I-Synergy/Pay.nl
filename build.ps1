$framework_version = "2.0.1.0"
$nuget_version = "2.0.1"
$msbuild = "${Env:ProgramFiles(x86)}\Microsoft Visual Studio\2019\Enterprise\MSBuild\Current\Bin\msbuild.exe"
$sourceNugetExe = "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe"
$targetNugetExe = "nuget.exe"
$ErrorActionPreference = "Stop"

Write-Host "Download latest nuget"
Invoke-WebRequest $sourceNugetExe -OutFile $targetNugetExe
Set-Alias nuget $targetNugetExe -Scope Global -Verbose

Write-Host "First build all projects in Release mode (Platform should be both x86 and x64)"

Write-Host "Build for .Net"
dotnet restore src\PayNL\PayNL.csproj --configfile nuget.config --verbosity Detailed
dotnet build src\PayNL\PayNL.csproj -c release -p:Version=$framework_version

Write-Host "NuGet pack"
./nuget pack nuget/Package.nuspec -OutputDirectory nuget/output -Properties "BuildConfiguration=release;Version=$nuget_version;PackageVersion=$nuget_version" -Verbosity Detailed