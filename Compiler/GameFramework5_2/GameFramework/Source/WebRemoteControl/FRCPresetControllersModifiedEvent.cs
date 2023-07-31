#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event which is triggered whenever a Controller is modified.</summary>
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCPresetControllersModifiedEvent {
	public string Type;
	public string PresetName;
	public string PresetId;
	public FRCControllerModifiedDescription ModifiedControllers;
}
