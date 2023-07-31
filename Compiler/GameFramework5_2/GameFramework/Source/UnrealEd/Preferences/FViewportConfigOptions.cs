#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Persistent per-viewport options</summary>
[CppInclude("Preferences/PersonaOptions.h")]
public partial struct FViewportConfigOptions {
	public EViewModeIndex ViewModeIndex;
	public float ViewFOV;
	public int CameraSpeedSetting;
	public float CameraSpeedScalar;
	public EAnimationViewportCameraFollowMode CameraFollowMode;
	public string CameraFollowBoneName;
}
