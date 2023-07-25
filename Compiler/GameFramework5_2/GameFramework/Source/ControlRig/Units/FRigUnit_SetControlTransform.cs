#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
///<summary>SetControlTransform is used to perform a change in the hierarchy by setting a single control's transform.</summary>
public partial struct FRigUnit_SetControlTransform {
// RigUnit_SetControlTransform
	public string Control;
	public float Weight;
	public FTransform Transform;
	public ERigVMTransformSpace Space;
	public FCachedRigElement CachedControlIndex;
}
