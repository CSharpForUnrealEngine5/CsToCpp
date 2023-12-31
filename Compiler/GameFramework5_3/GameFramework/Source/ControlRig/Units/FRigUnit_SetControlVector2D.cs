namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetControlVector2D is used to perform a change in the hierarchy by setting a single control&#39;s Vector2D value.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
public partial struct FRigUnit_SetControlVector2D {
	public FName Control;
	public float Weight;
	public FVector2D Vector;
	public FCachedRigElement CachedControlIndex;
}
