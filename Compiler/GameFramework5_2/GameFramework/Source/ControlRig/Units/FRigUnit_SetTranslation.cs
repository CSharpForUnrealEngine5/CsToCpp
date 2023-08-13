namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetTranslation is used to set a single translation on hierarchy.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetTransform.h")]
public partial struct FRigUnit_SetTranslation {
	public FRigElementKey Item;
	public ERigVMTransformSpace Space;
	public bool bInitial;
	public FVector Value;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedIndex;
}
