namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>List of platform-specific instances for a class</summary>
[CppInclude("Engine/PlatformSettingsManager.h")]
public partial struct FPlatformSettingsInstances {
	public UPlatformSettings PlatformInstance;
	public TMap<FName,UPlatformSettings> OtherPlatforms;
}
