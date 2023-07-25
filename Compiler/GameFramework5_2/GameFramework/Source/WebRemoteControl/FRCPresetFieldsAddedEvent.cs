#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCPresetFieldsAddedEvent {
// RCPresetFieldsAddedEvent
	public string Type;
	public string PresetName;
	public string PresetId;
	public FRCPresetDescription Description;
}
