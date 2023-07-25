#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetControlOffset.h")]
///<summary>SetControlOffset is used to perform a change in the hierarchy by setting a single control's transform.</summary>
public partial struct FRigUnit_SetControlOffset {
// RigUnit_SetControlOffset
	public string Control;
	public FTransform Offset;
	public ERigVMTransformSpace Space;
	public FCachedRigElement CachedControlIndex;
}
