#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_GetTransform.h")]
///<summary>GetTransform is used to retrieve a single transform from a hierarchy.</summary>
public partial struct FRigUnit_GetTransform {
// RigUnit_GetTransform
	public FRigElementKey Item;
	public ERigVMTransformSpace Space;
	public bool bInitial;
	public FTransform Transform;
	public FCachedRigElement CachedIndex;
}
