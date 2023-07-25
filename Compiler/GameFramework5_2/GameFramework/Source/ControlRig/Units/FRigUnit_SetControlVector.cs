#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
///<summary>SetControlVector is used to perform a change in the hierarchy by setting a single control's Vector value.</summary>
public partial struct FRigUnit_SetControlVector {
// RigUnit_SetControlVector
	public string Control;
	public float Weight;
	public FVector Vector;
	public ERigVMTransformSpace Space;
	public FCachedRigElement CachedControlIndex;
}
