#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/PlatformsMenuSettings.h")]
public partial class UPlatformsMenuSettings : UObject {
// PlatformsMenuSettings
	public FDirectoryPath StagingDirectory;
	public string LaunchOnTarget;
	public TMap<string,EProjectPackagingBuildConfigurations> PerPlatformBuildConfig;
	public TMap<string,string> PerPlatformTargetFlavorName;
	public TMap<string,string> PerPlatformBuildTarget;
}
