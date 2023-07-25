#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_TwoBoneIKSimple.h")]
///<summary>Solves the two bone IK given transforms</summary>
public partial struct FRigUnit_TwoBoneIKSimpleTransforms {
// RigUnit_TwoBoneIKSimpleTransforms
	public FTransform Root;
	public FVector PoleVector;
	public FTransform Effector;
	public FVector PrimaryAxis;
	public FVector SecondaryAxis;
	public float SecondaryAxisWeight;
	public bool bEnableStretch;
	public float StretchStartRatio;
	public float StretchMaximumRatio;
	public float BoneALength;
	public float BoneBLength;
	public FTransform Elbow;
}
