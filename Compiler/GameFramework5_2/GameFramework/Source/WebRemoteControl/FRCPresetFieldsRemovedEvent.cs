namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCPresetFieldsRemovedEvent {
	public string Type;
	public string PresetName;
	public string PresetId;
	public TArray<string> RemovedFields;
	public TArray<string> RemovedFieldIds;
}
