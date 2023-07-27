#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CameraAnimationCameraModifier.h")]
///<summary>A camera modifier that plays camera animation sequences.</summary>
public partial class UCameraAnimationCameraModifier : UCameraModifier {
// CameraAnimationCameraModifier
	public  FCameraAnimationHandle PlayCameraAnimation(UCameraAnimationSequence Sequence,FCameraAnimationParams Params) { return default; }
	public  bool IsCameraAnimationActive(FCameraAnimationHandle Handle) { return default; }
	public  void StopCameraAnimation(FCameraAnimationHandle Handle,bool bImmediate/*=false*/) {}
	public  void StopAllCameraAnimationsOf(UCameraAnimationSequence Sequence,bool bImmediate/*=false*/) {}
	public  void StopAllCameraAnimations(bool bImmediate/*=false*/) {}
	public static UCameraAnimationCameraModifier GetCameraAnimationCameraModifier(UObject WorldContextObject,int PlayerIndex) { return default; }
	public static UCameraAnimationCameraModifier GetCameraAnimationCameraModifierFromID(UObject WorldContextObject,int ControllerID) { return default; }
	public static UCameraAnimationCameraModifier GetCameraAnimationCameraModifierFromPlayerController(APlayerController PlayerController) { return default; }
	public TArray<FActiveCameraAnimationInfo> ActiveAnimations;
	public ushort NextInstanceSerialNumber;
}
