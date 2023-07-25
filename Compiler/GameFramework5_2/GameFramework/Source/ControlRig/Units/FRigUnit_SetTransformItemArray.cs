#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetTransform.h")]
///<summary>SetTransformArray is used to set an array of transforms on the hierarchy.</summary>
public partial struct FRigUnit_SetTransformItemArray {
// RigUnit_SetTransformItemArray
	public TArray<FRigElementKey> Items;
	public ERigVMTransformSpace Space;
	public bool bInitial;
	public TArray<FTransform> Transforms;
	public float Weight;
	public bool bPropagateToChildren;
	public TArray<FCachedRigElement> CachedIndex;
}
