#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A subsystem to provide and cache dynamically created ustructs.</summary>
[CppInclude("RemoteControlReflectionUtils.h")]
public partial class UWebRCStructRegistry : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Map of cached structs.</summary>
	public TMap<string,UScriptStruct> CachedStructs;
}
