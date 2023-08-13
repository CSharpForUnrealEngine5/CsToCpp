namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetControlFloat is used to perform a change in the hierarchy by setting a single control&#39;s float value.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
public partial struct FRigUnit_SetControlFloat {
	public string Control;
	public float Weight;
	public float FloatValue;
	public FCachedRigElement CachedControlIndex;
}
