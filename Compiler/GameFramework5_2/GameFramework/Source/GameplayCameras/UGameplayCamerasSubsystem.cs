#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCamerasSubsystem.h")]
///<summary>World subsystem that holds global objects for handling camera animation sequences.</summary>
public partial class UGameplayCamerasSubsystem : UWorldSubsystem {
// GameplayCamerasSubsystem
	public FCameraAnimationHandle PlayCameraAnimation(UObject PlayerController,UObject Sequence,FCameraAnimationParams Params) { return default; }
	public bool IsCameraAnimationActive(UObject PlayerController,FCameraAnimationHandle Handle) { return default; }
	public void StopCameraAnimation(UObject PlayerController,FCameraAnimationHandle Handle,bool bImmediate/*=false*/) {}
	public void StopAllCameraAnimationsOf(UObject PlayerController,UObject Sequence,bool bImmediate/*=false*/) {}
	public void StopAllCameraAnimations(UObject PlayerController,bool bImmediate/*=false*/) {}
}
