#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlReflectionUtils.h")]
///<summary>A subsystem to provide and cache dynamically created ustructs.</summary>
public partial class UWebRCStructRegistry : UEngineSubsystem {
// WebRCStructRegistry
	public TMap<string,UScriptStruct> CachedStructs;
}
