#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCamerasSubsystem.h")]
///<summary>World subsystem that holds global objects for handling camera animation sequences.</summary>
public partial class UGameplayCamerasSubsystem : UWorldSubsystem {
// GameplayCamerasSubsystem
	public  FCameraAnimationHandle PlayCameraAnimation(APlayerController PlayerController,UCameraAnimationSequence Sequence,FCameraAnimationParams Params) { return default; }
	public  bool IsCameraAnimationActive(APlayerController PlayerController,FCameraAnimationHandle Handle) { return default; }
	public  void StopCameraAnimation(APlayerController PlayerController,FCameraAnimationHandle Handle,bool bImmediate/*=false*/) {}
	public  void StopAllCameraAnimationsOf(APlayerController PlayerController,UCameraAnimationSequence Sequence,bool bImmediate/*=false*/) {}
	public  void StopAllCameraAnimations(APlayerController PlayerController,bool bImmediate/*=false*/) {}
}
