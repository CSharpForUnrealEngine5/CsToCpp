#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
///<summary>SetControlRotator is used to perform a change in the hierarchy by setting a single control's Rotator value.</summary>
public partial struct FRigUnit_SetControlRotator {
// RigUnit_SetControlRotator
	public string Control;
	public float Weight;
	public FRotator Rotator;
	public ERigVMTransformSpace Space;
	public FCachedRigElement CachedControlIndex;
}
