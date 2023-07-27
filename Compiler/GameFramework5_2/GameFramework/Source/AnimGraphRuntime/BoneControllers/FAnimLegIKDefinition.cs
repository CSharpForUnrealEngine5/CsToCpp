#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_LegIK.h")]
///<summary>Per foot definitions</summary>
public partial struct FAnimLegIKDefinition {
// AnimLegIKDefinition
	public FBoneReference IKFootBone;
	public FBoneReference FKFootBone;
	public int NumBonesInLimb;
	public float MinRotationAngle;
	public EAxis FootBoneForwardAxis;
	public EAxis HingeRotationAxis;
	public bool bEnableRotationLimit;
	public bool bEnableKneeTwistCorrection;
}
