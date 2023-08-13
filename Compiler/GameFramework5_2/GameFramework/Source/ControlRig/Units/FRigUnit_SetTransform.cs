namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetTransform is used to set a single transform on hierarchy.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetTransform.h")]
public partial struct FRigUnit_SetTransform {
	public FRigElementKey Item;
	public ERigVMTransformSpace Space;
	public bool bInitial;
	public FTransform Value;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedIndex;
}
