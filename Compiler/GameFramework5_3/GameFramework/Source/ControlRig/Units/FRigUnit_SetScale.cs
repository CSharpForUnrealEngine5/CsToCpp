namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetScale is used to set a single scale on hierarchy.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetTransform.h")]
public partial struct FRigUnit_SetScale {
	public FRigElementKey Item;
	public ERigVMTransformSpace Space;
	public bool bInitial;
	public FVector Scale;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedIndex;
}
