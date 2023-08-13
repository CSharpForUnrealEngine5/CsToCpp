namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCPresetFieldsRenamedEvent {
	public string Type;
	public string PresetName;
	public string PresetId;
	public TArray<FRCPresetFieldRenamed> RenamedFields;
}
