namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Solves the two bone IK given two bones.</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_TwoBoneIKSimple.h")]
public partial struct FRigUnit_TwoBoneIKSimple {
	public FName BoneA;
	public FName BoneB;
	public FName EffectorBone;
	public FTransform Effector;
	public FVector PrimaryAxis;
	public FVector SecondaryAxis;
	public float SecondaryAxisWeight;
	public FVector PoleVector;
	public EControlRigVectorKind PoleVectorKind;
	public FName PoleVectorSpace;
	public bool bEnableStretch;
	public float StretchStartRatio;
	public float StretchMaximumRatio;
	public float Weight;
	public float BoneALength;
	public float BoneBLength;
	public bool bPropagateToChildren;
	public FRigUnit_TwoBoneIKSimple_DebugSettings DebugSettings;
	public FCachedRigElement CachedBoneAIndex;
	public FCachedRigElement CachedBoneBIndex;
	public FCachedRigElement CachedEffectorBoneIndex;
	public FCachedRigElement CachedPoleVectorSpaceIndex;
}
