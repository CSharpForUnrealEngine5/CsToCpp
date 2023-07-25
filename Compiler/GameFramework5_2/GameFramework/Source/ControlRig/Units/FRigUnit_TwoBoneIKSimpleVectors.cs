#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_TwoBoneIKSimple.h")]
///<summary>Solves the two bone IK given positions</summary>
public partial struct FRigUnit_TwoBoneIKSimpleVectors {
// RigUnit_TwoBoneIKSimpleVectors
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
