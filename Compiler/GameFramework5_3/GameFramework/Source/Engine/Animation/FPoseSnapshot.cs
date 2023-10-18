namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A pose for a skeletal mesh</summary>
[CppInclude("Animation/PoseSnapshot.h")]
public partial struct FPoseSnapshot {
	public TArray<FTransform> LocalTransforms;
	public TArray<FName> BoneNames;
	public FName SkeletalMeshName;
	public FName SnapshotName;
	public bool bIsValid;
}
