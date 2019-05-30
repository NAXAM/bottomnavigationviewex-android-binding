// Tools needed by cake addins
#tool nuget:?package=ILRepack&version=2.0.13
#tool nuget:?package=Cake.MonoApiTools&version=3.0.1
#tool nuget:?package=Microsoft.DotNet.BuildTools.GenAPI&version=1.0.0-beta-00081
#tool nuget:?package=vswhere

// Cake Addins
#addin nuget:?package=Cake.FileHelpers&version=3.1.0
#addin nuget:?package=Cake.Compression&version=0.1.6
#addin nuget:?package=Cake.MonoApiTools&version=3.0.1
#addin nuget:?package=Xamarin.Nuget.Validator&version=1.1.1

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

var VERSION = "2.0.4";

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

var slnFile = "./Naxam.Ittianyu.BottomNavExtension.sln";
var downloadUrl = string.Format("https://jitpack.io/com/github/ittianyu/BottomNavigationViewEx/{0}/BottomNavigationViewEx-{0}.aar", VERSION);
var downloadTarget = string.Format("./Naxam.Ittianyu.BottomNavExtension/Jars/BottomNavigationViewEx.aar", VERSION);

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Downloads")
    .Does(() =>
{
    DownloadFile(downloadUrl, downloadTarget);
});

Task("Clean")
    .Does(() =>
{
    var nugetPackages = GetFiles("./*.nupkg");

    foreach (var package in nugetPackages)
    {
        DeleteFile(package);
    }

    //CleanDirectory("./packages");
});

Task("Restore-NuGet-Packages")
    .IsDependentOn("Clean")
    .Does(() =>
{
    NuGetRestore(slnFile);
});

Task("Build")
    .IsDependentOn("Downloads")
    .IsDependentOn("Restore-NuGet-Packages")
    .Does(() =>
{
    MSBuild(slnFile, settings => {
        settings.ToolVersion = MSBuildToolVersion.VS2019;
        settings.SetConfiguration(configuration);
    });
});

Task("UpdateVersion")
    .Does(() => 
{
    var assemblyInfoPath = "./Naxam.Ittianyu.BottomNavExtension/Properties/AssemblyInfo.cs";
    ReplaceRegexInFiles(assemblyInfoPath, "\\[assembly\\: AssemblyVersion([^\\]]+)\\]", string.Format("[assembly: AssemblyVersion(\"{0}\")]", VERSION));
});

Task("Pack")
    .IsDependentOn("UpdateVersion")
    .IsDependentOn("Build")
    .Does(() =>
{
    NuGetPack("./bottom-nav-ex.nuspec", new NuGetPackSettings {
        Version = VERSION
    });
});

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Pack");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);
