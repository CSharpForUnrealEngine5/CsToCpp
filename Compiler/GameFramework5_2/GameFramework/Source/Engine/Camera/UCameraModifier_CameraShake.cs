#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Camera/CameraModifier_CameraShake.h")]
///<summary>A UCameraModifier_CameraShake is a camera modifier that can apply a UCameraShakeBase to</summary>
public partial class UCameraModifier_CameraShake : UCameraModifier {
// CameraModifier_CameraShake
	public TArray<FActiveCameraShakeInfo> ActiveShakes;
	public TMap<UClass,FPooledCameraShakes> ExpiredPooledShakesMap;
	public float SplitScreenShakeScale;
}
