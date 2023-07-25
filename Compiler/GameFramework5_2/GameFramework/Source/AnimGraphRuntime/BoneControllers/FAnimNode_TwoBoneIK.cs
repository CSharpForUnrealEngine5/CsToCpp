#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_TwoBoneIK.h")]
///<summary>Simple 2 Bone IK Controller.</summary>
public partial struct FAnimNode_TwoBoneIK {
// AnimNode_TwoBoneIK
	public FBoneReference IKBone;
	public double StartStretchRatio;
	public double MaxStretchScale;
	public FVector2D StretchLimits_DEPRECATED;
	public bool bNoTwist_DEPRECATED;
	public string JointTargetSpaceBoneName_DEPRECATED;
	public string EffectorSpaceBoneName_DEPRECATED;
	public FVector EffectorLocation;
	public FBoneSocketTarget EffectorTarget;
	public FVector JointTargetLocation;
	public FBoneSocketTarget JointTarget;
	public FAxis TwistAxis;
	public byte EffectorLocationSpace;
	public byte JointTargetLocationSpace;
	public bool bAllowStretching;
	public bool bTakeRotationFromEffectorSpace;
	public bool bMaintainEffectorRelRot;
	public bool bAllowTwist;
}
