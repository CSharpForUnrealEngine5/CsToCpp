namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetControlTransform is used to retrieve a single transform from a hierarchy.</summary>
[CppInclude("Units/Hierarchy/RigUnit_GetControlInitialTransform.h")]
public partial struct FRigUnit_GetControlInitialTransform {
	public FName Control;
	public ERigVMTransformSpace Space;
	public FTransform Transform;
	public FCachedRigElement CachedControlIndex;
}
