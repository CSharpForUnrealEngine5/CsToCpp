#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_GetControlInitialTransform.h")]
///<summary>GetControlTransform is used to retrieve a single transform from a hierarchy.</summary>
public partial struct FRigUnit_GetControlInitialTransform {
// RigUnit_GetControlInitialTransform
	public string Control;
	public ERigVMTransformSpace Space;
	public FTransform Transform;
	public FCachedRigElement CachedControlIndex;
}
