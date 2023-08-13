namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UPoseableMeshComponent that allows bone transforms to be driven by blueprint.</summary>
[CppInclude("Components/PoseableMeshComponent.h")]
public partial class UPoseableMeshComponent : USkinnedMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>SetBoneTransformByName</summary>
	public void SetBoneTransformByName(string BoneName,FTransform InTransform,EBoneSpaces BoneSpace) {}
	///<summary>SetBoneLocationByName</summary>
	public void SetBoneLocationByName(string BoneName,FVector InLocation,EBoneSpaces BoneSpace) {}
	///<summary>SetBoneRotationByName</summary>
	public void SetBoneRotationByName(string BoneName,FRotator InRotation,EBoneSpaces BoneSpace) {}
	///<summary>SetBoneScaleByName</summary>
	public void SetBoneScaleByName(string BoneName,FVector InScale3D,EBoneSpaces BoneSpace) {}
	///<summary>GetBoneTransformByName</summary>
	public FTransform GetBoneTransformByName(string BoneName,EBoneSpaces BoneSpace) { return default; }
	///<summary>GetBoneLocationByName</summary>
	public FVector GetBoneLocationByName(string BoneName,EBoneSpaces BoneSpace) { return default; }
	///<summary>GetBoneRotationByName</summary>
	public FRotator GetBoneRotationByName(string BoneName,EBoneSpaces BoneSpace) { return default; }
	///<summary>GetBoneScaleByName</summary>
	public FVector GetBoneScaleByName(string BoneName,EBoneSpaces BoneSpace) { return default; }
	///<summary>ResetBoneTransformByName</summary>
	public void ResetBoneTransformByName(string BoneName) {}
	///<summary>CopyPoseFromSkeletalComponent</summary>
	public void CopyPoseFromSkeletalComponent(USkeletalMeshComponent InComponentToCopy) {}
}
