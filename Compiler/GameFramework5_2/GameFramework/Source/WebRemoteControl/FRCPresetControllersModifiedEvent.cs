#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
///<summary>Event which is triggered whenever a Controller is modified.</summary>
public partial struct FRCPresetControllersModifiedEvent {
// RCPresetControllersModifiedEvent
	public string Type;
	public string PresetName;
	public string PresetId;
	public FRCControllerModifiedDescription ModifiedControllers;
}
