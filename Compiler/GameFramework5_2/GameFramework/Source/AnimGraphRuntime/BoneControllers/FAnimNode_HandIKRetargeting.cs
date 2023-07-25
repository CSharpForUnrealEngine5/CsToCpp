#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_HandIKRetargeting.h")]
///<summary>Node to handle re-targeting of Hand IK bone chain.</summary>
public partial struct FAnimNode_HandIKRetargeting {
// AnimNode_HandIKRetargeting
	public FBoneReference RightHandFK;
	public FBoneReference LeftHandFK;
	public FBoneReference RightHandIK;
	public FBoneReference LeftHandIK;
	public TArray<FBoneReference> IKBonesToMove;
	public float HandFKWeight;
}
