#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_TwoBoneIKSimple.h")]
///<summary>Solves the two bone IK given two bones.</summary>
public partial struct FRigUnit_TwoBoneIKSimplePerItem {
// RigUnit_TwoBoneIKSimplePerItem
	public FRigElementKey ItemA;
	public FRigElementKey ItemB;
	public FRigElementKey EffectorItem;
	public FTransform Effector;
	public FVector PrimaryAxis;
	public FVector SecondaryAxis;
	public float SecondaryAxisWeight;
	public FVector PoleVector;
	public EControlRigVectorKind PoleVectorKind;
	public FRigElementKey PoleVectorSpace;
	public bool bEnableStretch;
	public float StretchStartRatio;
	public float StretchMaximumRatio;
	public float Weight;
	public float ItemALength;
	public float ItemBLength;
	public bool bPropagateToChildren;
	public FRigUnit_TwoBoneIKSimple_DebugSettings DebugSettings;
	public FCachedRigElement CachedItemAIndex;
	public FCachedRigElement CachedItemBIndex;
	public FCachedRigElement CachedEffectorItemIndex;
	public FCachedRigElement CachedPoleVectorSpaceIndex;
}
