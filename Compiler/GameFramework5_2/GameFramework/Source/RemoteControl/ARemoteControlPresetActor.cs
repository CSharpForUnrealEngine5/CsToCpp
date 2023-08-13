namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor that wraps a remote control preset, allows linking a specific preset to a level.</summary>
[CppInclude("RemoteControlPresetActor.h")]
public partial class ARemoteControlPresetActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Preset</summary>
	public URemoteControlPreset Preset;
}
