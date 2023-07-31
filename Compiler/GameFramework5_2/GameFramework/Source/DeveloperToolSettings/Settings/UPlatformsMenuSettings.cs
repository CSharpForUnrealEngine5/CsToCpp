#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/PlatformsMenuSettings.h")]
public partial class UPlatformsMenuSettings : UObject {
	///<summary>The directory to which the packaged project will be copied.</summary>
	public FDirectoryPath StagingDirectory;
	///<summary>Name of the target to use for LaunchOn (only Game/Client targets)</summary>
	public string LaunchOnTarget;
	///<summary>Per platform build configuration</summary>
	public TMap<string,EProjectPackagingBuildConfigurations> PerPlatformBuildConfig;
	///<summary>Per platform flavor cooking target</summary>
	public TMap<string,string> PerPlatformTargetFlavorName;
	///<summary>Per platform build target</summary>
	public TMap<string,string> PerPlatformBuildTarget;
}
