namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Solves the two bone IK given positions</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_TwoBoneIKSimple.h")]
public partial struct FRigUnit_TwoBoneIKSimpleVectors {
	public FVector Root;
	public FVector PoleVector;
	public FVector Effector;
	public bool bEnableStretch;
	public float StretchStartRatio;
	public float StretchMaximumRatio;
	public float BoneALength;
	public float BoneBLength;
	public FVector Elbow;
}
