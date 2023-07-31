#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Solves the two bone IK given transforms</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_TwoBoneIKSimple.h")]
public partial struct FRigUnit_TwoBoneIKSimpleTransforms {
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
