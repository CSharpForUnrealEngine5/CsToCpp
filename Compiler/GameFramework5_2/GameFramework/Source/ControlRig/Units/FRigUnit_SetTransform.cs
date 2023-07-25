#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetTransform.h")]
///<summary>SetTransform is used to set a single transform on hierarchy.</summary>
public partial struct FRigUnit_SetTransform {
// RigUnit_SetTransform
	public FRigElementKey Item;
	public ERigVMTransformSpace Space;
	public bool bInitial;
	public FTransform Value;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedIndex;
}
