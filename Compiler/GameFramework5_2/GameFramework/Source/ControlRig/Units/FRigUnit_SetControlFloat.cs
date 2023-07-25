#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
///<summary>SetControlFloat is used to perform a change in the hierarchy by setting a single control's float value.</summary>
public partial struct FRigUnit_SetControlFloat {
// RigUnit_SetControlFloat
	public string Control;
	public float Weight;
	public float FloatValue;
	public FCachedRigElement CachedControlIndex;
}
