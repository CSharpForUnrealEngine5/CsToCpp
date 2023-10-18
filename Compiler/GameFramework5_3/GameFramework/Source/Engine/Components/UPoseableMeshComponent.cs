namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UPoseableMeshComponent that allows bone transforms to be driven by blueprint.</summary>
[CppInclude("Components/PoseableMeshComponent.h")]
public partial class UPoseableMeshComponent : USkinnedMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>SetBoneTransformByName</summary>
	public void SetBoneTransformByName(FName BoneName,FTransform InTransform,EBoneSpaces BoneSpace) {}
	///<summary>SetBoneLocationByName</summary>
	public void SetBoneLocationByName(FName BoneName,FVector InLocation,EBoneSpaces BoneSpace) {}
	///<summary>SetBoneRotationByName</summary>
	public void SetBoneRotationByName(FName BoneName,FRotator InRotation,EBoneSpaces BoneSpace) {}
	///<summary>SetBoneScaleByName</summary>
	public void SetBoneScaleByName(FName BoneName,FVector InScale3D,EBoneSpaces BoneSpace) {}
	///<summary>GetBoneTransformByName</summary>
	public FTransform GetBoneTransformByName(FName BoneName,EBoneSpaces BoneSpace) { return default; }
	///<summary>GetBoneLocationByName</summary>
	public FVector GetBoneLocationByName(FName BoneName,EBoneSpaces BoneSpace) { return default; }
	///<summary>GetBoneRotationByName</summary>
	public FRotator GetBoneRotationByName(FName BoneName,EBoneSpaces BoneSpace) { return default; }
	///<summary>GetBoneScaleByName</summary>
	public FVector GetBoneScaleByName(FName BoneName,EBoneSpaces BoneSpace) { return default; }
	///<summary>ResetBoneTransformByName</summary>
	public void ResetBoneTransformByName(FName BoneName) {}
	///<summary>CopyPoseFromSkeletalComponent</summary>
	public void CopyPoseFromSkeletalComponent(USkeletalMeshComponent InComponentToCopy) {}
}
