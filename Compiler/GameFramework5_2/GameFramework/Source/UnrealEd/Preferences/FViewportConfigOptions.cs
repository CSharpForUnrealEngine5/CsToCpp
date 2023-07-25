#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Preferences/PersonaOptions.h")]
///<summary>Persistent per-viewport options</summary>
public partial struct FViewportConfigOptions {
// ViewportConfigOptions
	public byte ViewModeIndex;
	public float ViewFOV;
	public int CameraSpeedSetting;
	public float CameraSpeedScalar;
	public EAnimationViewportCameraFollowMode CameraFollowMode;
	public string CameraFollowBoneName;
}
