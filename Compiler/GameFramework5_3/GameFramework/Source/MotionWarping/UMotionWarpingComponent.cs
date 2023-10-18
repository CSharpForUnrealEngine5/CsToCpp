namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionWarpingComponent.h")]
public partial class UMotionWarpingComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to look inside animations within montage when looking for warping windows</summary>
	public bool bSearchForWindowsInAnimsWithinMontages;
	///<summary>Event called before Root Motion Modifiers are updated</summary>
	public FMotionWarpingPreUpdate OnPreUpdate;
	///<summary>Mark all the modifiers as Disable</summary>
	public void DisableAllRootMotionModifiers() {}
	///<summary>Adds or update a warp target</summary>
	public void AddOrUpdateWarpTarget(FMotionWarpingTarget WarpTarget) {}
	///<summary>Create and adds or update a target associated with a specified name</summary>
	public void AddOrUpdateWarpTargetFromTransform(FName WarpTargetName,FTransform TargetTransform) {}
	///<summary>Create and adds or update a target associated with a specified name</summary>
	public void AddOrUpdateWarpTargetFromComponent(FName WarpTargetName,USceneComponent Component,FName BoneName,bool bFollowComponent) {}
	///<summary>Create and adds or update a target associated with a specified name</summary>
	public void AddOrUpdateWarpTargetFromLocation(FName WarpTargetName,FVector TargetLocation) {}
	///<summary>Create and adds or update a target associated with a specified name</summary>
	public void AddOrUpdateWarpTargetFromLocationAndRotation(FName WarpTargetName,FVector TargetLocation,FRotator TargetRotation) {}
	///<summary>Removes the warp target associated with the specified key</summary>
	public int RemoveWarpTarget(FName WarpTargetName) { return default; }
	///<summary>Character this component belongs to</summary>
	public TWeakObjectPtr<ACharacter> CharacterOwner;
	///<summary>List of root motion modifiers</summary>
	public TArray<URootMotionModifier> Modifiers;
	///<summary>WarpTargets</summary>
	public TArray<FMotionWarpingTarget> WarpTargets;
}
