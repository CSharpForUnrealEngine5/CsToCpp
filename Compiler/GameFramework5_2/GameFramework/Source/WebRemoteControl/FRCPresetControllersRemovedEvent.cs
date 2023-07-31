#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCPresetControllersRemovedEvent {
	public string Type;
	public string PresetName;
	public string PresetId;
	public TArray<string> RemovedControllers;
	public TArray<string> RemovedControllerIds;
}
