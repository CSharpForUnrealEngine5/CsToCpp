namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCPresetFieldsRemovedEvent {
	public string Type;
	public FName PresetName;
	public string PresetId;
	public TArray<FName> RemovedFields;
	public TArray<string> RemovedFieldIds;
}
