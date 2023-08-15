namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCPresetControllersRenamedEvent {
	public string Type;
	public FName PresetName;
	public string PresetId;
	public TArray<FRCPresetFieldRenamed> RenamedControllers;
}
