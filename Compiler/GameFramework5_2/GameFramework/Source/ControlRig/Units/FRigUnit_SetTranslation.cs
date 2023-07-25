#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetTransform.h")]
///<summary>SetTranslation is used to set a single translation on hierarchy.</summary>
public partial struct FRigUnit_SetTranslation {
// RigUnit_SetTranslation
	public FRigElementKey Item;
	public ERigVMTransformSpace Space;
	public bool bInitial;
	public FVector Value;
	public float Weight;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedIndex;
}
