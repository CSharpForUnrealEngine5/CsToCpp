#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetControlRotator is used to perform a change in the hierarchy by setting a single control&#39;s Rotator value.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
public partial struct FRigUnit_SetControlRotator {
	public string Control;
	public float Weight;
	public FRotator Rotator;
	public ERigVMTransformSpace Space;
	public FCachedRigElement CachedControlIndex;
}
