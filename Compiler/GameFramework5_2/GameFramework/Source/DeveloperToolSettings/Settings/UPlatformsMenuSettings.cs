namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/PlatformsMenuSettings.h")]
public partial class UPlatformsMenuSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The directory to which the packaged project will be copied.</summary>
	public FDirectoryPath StagingDirectory;
	///<summary>Name of the target to use for LaunchOn (only Game/Client targets)</summary>
	public string LaunchOnTarget;
	///<summary>Per platform build configuration</summary>
	public TMap<FName,EProjectPackagingBuildConfigurations> PerPlatformBuildConfig;
	///<summary>Per platform flavor cooking target</summary>
	public TMap<FName,FName> PerPlatformTargetFlavorName;
	///<summary>Per platform build target</summary>
	public TMap<FName,string> PerPlatformBuildTarget;
}
