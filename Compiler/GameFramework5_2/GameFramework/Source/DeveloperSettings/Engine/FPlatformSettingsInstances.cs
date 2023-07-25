#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PlatformSettingsManager.h")]
///<summary>List of platform-specific instances for a class</summary>
public partial struct FPlatformSettingsInstances {
// PlatformSettingsInstances
	public UPlatformSettings PlatformInstance;
	public TMap<string,UPlatformSettings> OtherPlatforms;
}
