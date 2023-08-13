namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCPresetFieldsAddedEvent {
	public string Type;
	public string PresetName;
	public string PresetId;
	public FRCPresetDescription Description;
}
