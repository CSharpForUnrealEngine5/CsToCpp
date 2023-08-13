namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Keeps track of all data associated with settings presets.</summary>
[CppInclude("VirtualCameraSaveGame.h")]
public partial struct FVirtualCameraSettingsPreset {
	public bool bIsCameraSettingsSaved;
	public bool bIsStabilizationSettingsSaved;
	public bool bIsAxisLockingSettingsSaved;
	public bool bIsMotionScaleSettingsSaved;
	public bool bIsFavorited;
	public FVirtualCameraSettings CameraSettings;
	public FDateTime DateCreated;
}
