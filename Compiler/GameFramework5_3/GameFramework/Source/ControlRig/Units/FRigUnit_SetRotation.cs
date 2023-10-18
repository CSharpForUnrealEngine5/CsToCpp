namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetRotation is used to set a single rotation on hierarchy.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetTransform.h")]
public partial struct FRigUnit_SetRotation {
	public FRigElementKey Item;
	public ERigVMTransformSpace Space;
	public bool bInitial;
	public FQuat Value;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedIndex;
}
