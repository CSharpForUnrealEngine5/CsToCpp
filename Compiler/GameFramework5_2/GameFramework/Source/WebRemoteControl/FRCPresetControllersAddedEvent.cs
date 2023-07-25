#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCPresetControllersAddedEvent {
// RCPresetControllersAddedEvent
	public string Type;
	public string PresetName;
	public string PresetId;
	public FRCPresetDescription Description;
}
