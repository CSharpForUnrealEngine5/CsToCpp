#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A pose for a skeletal mesh</summary>
[CppInclude("Animation/PoseSnapshot.h")]
public partial struct FPoseSnapshot {
	public TArray<FTransform> LocalTransforms;
	public TArray<string> BoneNames;
	public string SkeletalMeshName;
	public string SnapshotName;
	public bool bIsValid;
}
