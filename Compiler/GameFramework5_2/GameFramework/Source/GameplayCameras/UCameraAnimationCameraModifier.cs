#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CameraAnimationCameraModifier.h")]
///<summary>A camera modifier that plays camera animation sequences.</summary>
public partial class UCameraAnimationCameraModifier : UCameraModifier {
// CameraAnimationCameraModifier
	public FCameraAnimationHandle PlayCameraAnimation(UObject Sequence,FCameraAnimationParams Params) { return default; }
	public bool IsCameraAnimationActive(FCameraAnimationHandle Handle) { return default; }
	public void StopCameraAnimation(FCameraAnimationHandle Handle,bool bImmediate/*=false*/) {}
	public void StopAllCameraAnimationsOf(UObject Sequence,bool bImmediate/*=false*/) {}
	public void StopAllCameraAnimations(bool bImmediate/*=false*/) {}
	public UObject GetCameraAnimationCameraModifier(UObject WorldContextObject,int PlayerIndex) { return default; }
	public UObject GetCameraAnimationCameraModifierFromID(UObject WorldContextObject,int ControllerID) { return default; }
	public UObject GetCameraAnimationCameraModifierFromPlayerController(UObject PlayerController) { return default; }
	public TArray<FActiveCameraAnimationInfo> ActiveAnimations;
	public ushort NextInstanceSerialNumber;
}
