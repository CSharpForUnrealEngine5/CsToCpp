namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetShapeTransform is used to perform a change in the hierarchy by setting a single control&#39;s shape transform.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetControlOffset.h")]
public partial struct FRigUnit_SetShapeTransform {
	public string Control;
	public FTransform Transform;
	public FCachedRigElement CachedControlIndex;
}
