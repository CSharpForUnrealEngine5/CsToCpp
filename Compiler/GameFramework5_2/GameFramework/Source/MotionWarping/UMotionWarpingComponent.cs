#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionWarpingComponent.h")]
public partial class UMotionWarpingComponent : UActorComponent {
// MotionWarpingComponent
	public bool bSearchForWindowsInAnimsWithinMontages;
	public FMotionWarpingPreUpdate OnPreUpdate;
	public  void DisableAllRootMotionModifiers() {}
	public  void AddOrUpdateWarpTarget(FMotionWarpingTarget WarpTarget) {}
	public  void AddOrUpdateWarpTargetFromTransform(string WarpTargetName,FTransform TargetTransform) {}
	public  void AddOrUpdateWarpTargetFromComponent(string WarpTargetName,USceneComponent Component,string BoneName,bool bFollowComponent) {}
	public  void AddOrUpdateWarpTargetFromLocation(string WarpTargetName,FVector TargetLocation) {}
	public  void AddOrUpdateWarpTargetFromLocationAndRotation(string WarpTargetName,FVector TargetLocation,FRotator TargetRotation) {}
	public  int RemoveWarpTarget(string WarpTargetName) { return default; }
	public TWeakObjectPtr<ACharacter> CharacterOwner;
	public TArray<URootMotionModifier> Modifiers;
	public TArray<FMotionWarpingTarget> WarpTargets;
}
