#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PlatformSettingsManager.h")]
///<summary>The manager for all platform-specific settings</summary>
public partial class UPlatformSettingsManager : UObject {
// PlatformSettingsManager
	public TMap<UClass,FPlatformSettingsInstances> SettingsMap;
}
