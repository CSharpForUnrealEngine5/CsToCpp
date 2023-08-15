namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCPresetFieldsAddedEvent {
	public string Type;
	public FName PresetName;
	public string PresetId;
	public FRCPresetDescription Description;
}
