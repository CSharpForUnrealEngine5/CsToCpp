#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetControlOffset.h")]
///<summary>SetShapeTransform is used to perform a change in the hierarchy by setting a single control's shape transform.</summary>
public partial struct FRigUnit_SetShapeTransform {
// RigUnit_SetShapeTransform
	public string Control;
	public FTransform Transform;
	public FCachedRigElement CachedControlIndex;
}
