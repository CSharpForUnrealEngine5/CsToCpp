#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetControlInteger is used to perform a change in the hierarchy by setting a single control&#39;s int32 value.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
public partial struct FRigUnit_SetControlInteger {
	public string Control;
	public int Weight;
	public int IntegerValue;
	public FCachedRigElement CachedControlIndex;
}
