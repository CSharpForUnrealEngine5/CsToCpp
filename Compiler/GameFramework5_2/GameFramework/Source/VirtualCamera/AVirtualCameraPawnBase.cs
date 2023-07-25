#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraPawnBase.h")]
///<summary>A class to handle aspects of virtual Camera related to general settings, and communicating with components.</summary>
public partial class AVirtualCameraPawnBase : APawn {
// VirtualCameraPawnBase
	public UVirtualCameraCineCameraComponent CineCamera;
	public bool bSaveSettingsWhenClosing;
	public string SavedSettingsSlotName;
	public TMap<string,FVirtualCameraSettingsPreset> SettingsPresets;
	public void HighlightTappedActor(UObject HighlightedActor) {}
	public void TriggerFocusPlaneTimer() {}
	public void LoadFinished() {}
	public bool bAllowFocusVisualization;
}
