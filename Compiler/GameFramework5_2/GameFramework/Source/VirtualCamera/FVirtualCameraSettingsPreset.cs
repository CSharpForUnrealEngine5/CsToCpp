#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraSaveGame.h")]
///<summary>Keeps track of all data associated with settings presets.</summary>
public partial struct FVirtualCameraSettingsPreset {
// VirtualCameraSettingsPreset
	public bool bIsCameraSettingsSaved;
	public bool bIsStabilizationSettingsSaved;
	public bool bIsAxisLockingSettingsSaved;
	public bool bIsMotionScaleSettingsSaved;
	public bool bIsFavorited;
	public FVirtualCameraSettings CameraSettings;
	public FDateTime DateCreated;
}
