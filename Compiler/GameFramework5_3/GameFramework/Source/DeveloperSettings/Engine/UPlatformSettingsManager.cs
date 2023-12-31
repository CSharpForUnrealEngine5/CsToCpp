namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The manager for all platform-specific settings</summary>
[CppInclude("Engine/PlatformSettingsManager.h")]
public partial class UPlatformSettingsManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Created platform-specific settings</summary>
	public TMap<UClass,FPlatformSettingsInstances> SettingsMap;
}
