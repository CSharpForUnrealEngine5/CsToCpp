#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
///<summary>SetControlVector2D is used to perform a change in the hierarchy by setting a single control's Vector2D value.</summary>
public partial struct FRigUnit_SetControlVector2D {
// RigUnit_SetControlVector2D
	public string Control;
	public float Weight;
	public FVector2D Vector;
	public FCachedRigElement CachedControlIndex;
}
