#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetTransformArray is used to set an array of transforms on the hierarchy.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetTransform.h")]
public partial struct FRigUnit_SetTransformItemArray {
	public TArray<FRigElementKey> Items;
	public ERigVMTransformSpace Space;
	public bool bInitial;
	public TArray<FTransform> Transforms;
	public float Weight;
	public bool bPropagateToChildren;
	public TArray<FCachedRigElement> CachedIndex;
}
