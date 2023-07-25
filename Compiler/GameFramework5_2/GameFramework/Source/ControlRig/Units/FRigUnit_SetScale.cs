#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetTransform.h")]
///<summary>SetScale is used to set a single scale on hierarchy.</summary>
public partial struct FRigUnit_SetScale {
// RigUnit_SetScale
	public FRigElementKey Item;
	public ERigVMTransformSpace Space;
	public bool bInitial;
	public FVector Scale;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedIndex;
}
