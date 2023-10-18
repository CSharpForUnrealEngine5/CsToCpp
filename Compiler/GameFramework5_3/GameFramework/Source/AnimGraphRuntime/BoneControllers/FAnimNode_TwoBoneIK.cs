namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple 2 Bone IK Controller.</summary>
[CppInclude("BoneControllers/AnimNode_TwoBoneIK.h")]
public partial struct FAnimNode_TwoBoneIK {
	public FBoneReference IKBone;
	public double StartStretchRatio;
	public double MaxStretchScale;
	public FVector2D StretchLimits_DEPRECATED;
	public bool bNoTwist_DEPRECATED;
	public FName JointTargetSpaceBoneName_DEPRECATED;
	public FName EffectorSpaceBoneName_DEPRECATED;
	public FVector EffectorLocation;
	public FBoneSocketTarget EffectorTarget;
	public FVector JointTargetLocation;
	public FBoneSocketTarget JointTarget;
	public FAxis TwistAxis;
	public EBoneControlSpace EffectorLocationSpace;
	public EBoneControlSpace JointTargetLocationSpace;
	public bool bAllowStretching;
	public bool bTakeRotationFromEffectorSpace;
	public bool bMaintainEffectorRelRot;
	public bool bAllowTwist;
}
