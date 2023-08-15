namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetControlVector2D is used to retrieve a single Vector2D from a hierarchy.</summary>
[CppInclude("Units/Hierarchy/RigUnit_GetControlTransform.h")]
public partial struct FRigUnit_GetControlVector2D {
	public FName Control;
	public FVector2D Vector;
	public FVector2D Minimum;
	public FVector2D Maximum;
	public FCachedRigElement CachedControlIndex;
}
