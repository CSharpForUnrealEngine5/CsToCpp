namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCPresetControllersRemovedEvent {
	public string Type;
	public FName PresetName;
	public string PresetId;
	public TArray<FName> RemovedControllers;
	public TArray<string> RemovedControllerIds;
}
