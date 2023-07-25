#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
///<summary>SetControlInteger is used to perform a change in the hierarchy by setting a single control's int32 value.</summary>
public partial struct FRigUnit_SetControlInteger {
// RigUnit_SetControlInteger
	public string Control;
	public int Weight;
	public int IntegerValue;
	public FCachedRigElement CachedControlIndex;
}
