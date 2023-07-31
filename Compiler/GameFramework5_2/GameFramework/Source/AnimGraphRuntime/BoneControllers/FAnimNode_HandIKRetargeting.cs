#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Node to handle re-targeting of Hand IK bone chain.</summary>
[CppInclude("BoneControllers/AnimNode_HandIKRetargeting.h")]
public partial struct FAnimNode_HandIKRetargeting {
	public FBoneReference RightHandFK;
	public FBoneReference LeftHandFK;
	public FBoneReference RightHandIK;
	public FBoneReference LeftHandIK;
	public TArray<FBoneReference> IKBonesToMove;
	public float HandFKWeight;
}
