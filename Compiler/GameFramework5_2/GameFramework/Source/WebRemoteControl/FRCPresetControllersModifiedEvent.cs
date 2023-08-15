namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event which is triggered whenever a Controller is modified.</summary>
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCPresetControllersModifiedEvent {
	public string Type;
	public FName PresetName;
	public string PresetId;
	public FRCControllerModifiedDescription ModifiedControllers;
}
