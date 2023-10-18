namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetControlInteger is used to perform a change in the hierarchy by setting a single control&#39;s int32 value.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
public partial struct FRigUnit_SetControlInteger {
	public FName Control;
	public int Weight;
	public int IntegerValue;
	public FCachedRigElement CachedControlIndex;
}
