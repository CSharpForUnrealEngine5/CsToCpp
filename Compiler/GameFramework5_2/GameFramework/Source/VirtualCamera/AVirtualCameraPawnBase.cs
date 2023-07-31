#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A class to handle aspects of virtual Camera related to general settings, and communicating with components.</summary>
[CppInclude("VirtualCameraPawnBase.h")]
public partial class AVirtualCameraPawnBase : APawn {
	///<summary>Cinematic camera used for view</summary>
	public UVirtualCameraCineCameraComponent CineCamera;
	///<summary>Determines if values should be saved between sessions</summary>
	public bool bSaveSettingsWhenClosing;
	///<summary>Stores the name of the save slot being used currently</summary>
	public string SavedSettingsSlotName;
	///<summary>Stores the list of settings presets, and saved presets</summary>
	public TMap<string,FVirtualCameraSettingsPreset> SettingsPresets;
	///<summary>Blueprint event to trigger the highlighting of a specific actor.</summary>
	public  void HighlightTappedActor(AActor HighlightedActor) {}
	///<summary>Blueprint event to trigger focus plane visualization for a set amount of time.</summary>
	public  void TriggerFocusPlaneTimer() {}
	///<summary>Blueprint event for signaling UI that game settings have been loaded.</summary>
	public  void LoadFinished() {}
	///<summary>Should focus plane be shown on all touch focus events</summary>
	public bool bAllowFocusVisualization;
}
