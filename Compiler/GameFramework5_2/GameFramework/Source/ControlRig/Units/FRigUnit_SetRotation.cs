#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetTransform.h")]
///<summary>SetRotation is used to set a single rotation on hierarchy.</summary>
public partial struct FRigUnit_SetRotation {
// RigUnit_SetRotation
	public FRigElementKey Item;
	public ERigVMTransformSpace Space;
	public bool bInitial;
	public FQuat Value;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedIndex;
}
