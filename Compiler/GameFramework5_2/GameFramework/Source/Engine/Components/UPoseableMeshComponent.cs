#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/PoseableMeshComponent.h")]
///<summary>UPoseableMeshComponent that allows bone transforms to be driven by blueprint.</summary>
public partial class UPoseableMeshComponent : USkinnedMeshComponent {
// PoseableMeshComponent
	public  void SetBoneTransformByName(string BoneName,FTransform InTransform,EBoneSpaces BoneSpace) {}
	public  void SetBoneLocationByName(string BoneName,FVector InLocation,EBoneSpaces BoneSpace) {}
	public  void SetBoneRotationByName(string BoneName,FRotator InRotation,EBoneSpaces BoneSpace) {}
	public  void SetBoneScaleByName(string BoneName,FVector InScale3D,EBoneSpaces BoneSpace) {}
	public  FTransform GetBoneTransformByName(string BoneName,EBoneSpaces BoneSpace) { return default; }
	public  FVector GetBoneLocationByName(string BoneName,EBoneSpaces BoneSpace) { return default; }
	public  FRotator GetBoneRotationByName(string BoneName,EBoneSpaces BoneSpace) { return default; }
	public  FVector GetBoneScaleByName(string BoneName,EBoneSpaces BoneSpace) { return default; }
	public  void ResetBoneTransformByName(string BoneName) {}
	public  void CopyPoseFromSkeletalComponent(USkeletalMeshComponent InComponentToCopy) {}
}
