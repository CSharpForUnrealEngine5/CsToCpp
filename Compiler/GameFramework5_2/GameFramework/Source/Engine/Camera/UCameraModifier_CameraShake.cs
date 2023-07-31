#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A UCameraModifier_CameraShake is a camera modifier that can apply a UCameraShakeBase to</summary>
[CppInclude("Camera/CameraModifier_CameraShake.h")]
public partial class UCameraModifier_CameraShake : UCameraModifier {
	///<summary>List of active CameraShake instances</summary>
	public TArray<FActiveCameraShakeInfo> ActiveShakes;
	///<summary>ExpiredPooledShakesMap</summary>
	public TMap<UClass,FPooledCameraShakes> ExpiredPooledShakesMap;
	///<summary>Scaling factor applied to all camera shakes in when in splitscreen mode. Normally used to reduce shaking, since shakes feel more intense in a smaller viewport.</summary>
	public float SplitScreenShakeScale;
}
