namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>World subsystem that holds global objects for handling camera animation sequences.</summary>
[CppInclude("GameplayCamerasSubsystem.h")]
public partial class UGameplayCamerasSubsystem : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Play a new camera animation sequence.</summary>
	public FCameraAnimationHandle PlayCameraAnimation(APlayerController PlayerController,UCameraAnimationSequence Sequence,FCameraAnimationParams Params) { return default; }
	///<summary>Returns whether the given camera animation is playing.</summary>
	public bool IsCameraAnimationActive(APlayerController PlayerController,FCameraAnimationHandle Handle) { return default; }
	///<summary>Stops the given camera animation instance.</summary>
	public void StopCameraAnimation(APlayerController PlayerController,FCameraAnimationHandle Handle,bool bImmediate/*=false*/) {}
	///<summary>Stop playing all instances of the given camera animation sequence.</summary>
	public void StopAllCameraAnimationsOf(APlayerController PlayerController,UCameraAnimationSequence Sequence,bool bImmediate/*=false*/) {}
	///<summary>Stop all camera animation instances.</summary>
	public void StopAllCameraAnimations(APlayerController PlayerController,bool bImmediate/*=false*/) {}
}
