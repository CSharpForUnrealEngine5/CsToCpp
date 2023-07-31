#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>List of platform-specific instances for a class</summary>
[CppInclude("Engine/PlatformSettingsManager.h")]
public partial struct FPlatformSettingsInstances {
	public UPlatformSettings PlatformInstance;
	public TMap<string,UPlatformSettings> OtherPlatforms;
}
