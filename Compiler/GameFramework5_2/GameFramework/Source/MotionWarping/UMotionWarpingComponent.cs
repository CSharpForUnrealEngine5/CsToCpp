#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionWarpingComponent.h")]
public partial class UMotionWarpingComponent : UActorComponent {
	///<summary>Whether to look inside animations within montage when looking for warping windows</summary>
	public bool bSearchForWindowsInAnimsWithinMontages;
	///<summary>Event called before Root Motion Modifiers are updated</summary>
	public FMotionWarpingPreUpdate OnPreUpdate;
	///<summary>Mark all the modifiers as Disable</summary>
	public  void DisableAllRootMotionModifiers() {}
	///<summary>Adds or update a warp target</summary>
	public  void AddOrUpdateWarpTarget(FMotionWarpingTarget WarpTarget) {}
	///<summary>Create and adds or update a target associated with a specified name</summary>
	public  void AddOrUpdateWarpTargetFromTransform(string WarpTargetName,FTransform TargetTransform) {}
	///<summary>Create and adds or update a target associated with a specified name</summary>
	public  void AddOrUpdateWarpTargetFromComponent(string WarpTargetName,USceneComponent Component,string BoneName,bool bFollowComponent) {}
	///<summary>Create and adds or update a target associated with a specified name</summary>
	public  void AddOrUpdateWarpTargetFromLocation(string WarpTargetName,FVector TargetLocation) {}
	///<summary>Create and adds or update a target associated with a specified name</summary>
	public  void AddOrUpdateWarpTargetFromLocationAndRotation(string WarpTargetName,FVector TargetLocation,FRotator TargetRotation) {}
	///<summary>Removes the warp target associated with the specified key</summary>
	public  int RemoveWarpTarget(string WarpTargetName) { return default; }
	///<summary>Character this component belongs to</summary>
	public TWeakObjectPtr<ACharacter> CharacterOwner;
	///<summary>List of root motion modifiers</summary>
	public TArray<URootMotionModifier> Modifiers;
	///<summary>WarpTargets</summary>
	public TArray<FMotionWarpingTarget> WarpTargets;
}
