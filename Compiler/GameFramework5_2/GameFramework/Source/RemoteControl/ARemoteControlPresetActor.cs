#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor that wraps a remote control preset, allows linking a specific preset to a level.</summary>
[CppInclude("RemoteControlPresetActor.h")]
public partial class ARemoteControlPresetActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Preset</summary>
	public URemoteControlPreset Preset;
}
