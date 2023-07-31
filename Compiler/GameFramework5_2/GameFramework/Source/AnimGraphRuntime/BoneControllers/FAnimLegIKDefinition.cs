#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Per foot definitions</summary>
[CppInclude("BoneControllers/AnimNode_LegIK.h")]
public partial struct FAnimLegIKDefinition {
	public FBoneReference IKFootBone;
	public FBoneReference FKFootBone;
	public int NumBonesInLimb;
	public float MinRotationAngle;
	public EAxis FootBoneForwardAxis;
	public EAxis HingeRotationAxis;
	public bool bEnableRotationLimit;
	public bool bEnableKneeTwistCorrection;
}
