namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetTransform is used to retrieve a single transform from a hierarchy.</summary>
[CppInclude("Units/Hierarchy/RigUnit_GetTransform.h")]
public partial struct FRigUnit_GetTransform {
	public FRigElementKey Item;
	public ERigVMTransformSpace Space;
	public bool bInitial;
	public FTransform Transform;
	public FCachedRigElement CachedIndex;
}
