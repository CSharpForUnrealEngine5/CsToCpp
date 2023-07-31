#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A camera modifier that plays camera animation sequences.</summary>
[CppInclude("CameraAnimationCameraModifier.h")]
public partial class UCameraAnimationCameraModifier : UCameraModifier {
	///<summary>Play a new camera animation sequence.</summary>
	public  FCameraAnimationHandle PlayCameraAnimation(UCameraAnimationSequence Sequence,FCameraAnimationParams Params) { return default; }
	///<summary>Returns whether the given camera animation is playing.</summary>
	public  bool IsCameraAnimationActive(FCameraAnimationHandle Handle) { return default; }
	///<summary>Stops the given camera animation instance.</summary>
	public  void StopCameraAnimation(FCameraAnimationHandle Handle,bool bImmediate/*=false*/) {}
	///<summary>Stop playing all instances of the given camera animation sequence.</summary>
	public  void StopAllCameraAnimationsOf(UCameraAnimationSequence Sequence,bool bImmediate/*=false*/) {}
	///<summary>Stop all camera animation instances.</summary>
	public  void StopAllCameraAnimations(bool bImmediate/*=false*/) {}
	///<summary>GetCameraAnimationCameraModifier</summary>
	public static UCameraAnimationCameraModifier GetCameraAnimationCameraModifier(UObject WorldContextObject,int PlayerIndex) { return default; }
	///<summary>GetCameraAnimationCameraModifierFromID</summary>
	public static UCameraAnimationCameraModifier GetCameraAnimationCameraModifierFromID(UObject WorldContextObject,int ControllerID) { return default; }
	///<summary>GetCameraAnimationCameraModifierFromPlayerController</summary>
	public static UCameraAnimationCameraModifier GetCameraAnimationCameraModifierFromPlayerController(APlayerController PlayerController) { return default; }
	///<summary>List of active camera animation instances</summary>
	public TArray<FActiveCameraAnimationInfo> ActiveAnimations;
	///<summary>Next serial number to use for a camera animation instance</summary>
	public ushort NextInstanceSerialNumber;
}
