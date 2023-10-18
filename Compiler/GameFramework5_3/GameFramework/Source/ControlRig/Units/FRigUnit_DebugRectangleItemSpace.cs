namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Draws a rectangle in the viewport given a transform</summary>
[CppInclude("Units/Debug/RigUnit_DebugPrimitives.h")]
public partial struct FRigUnit_DebugRectangleItemSpace {
	public FTransform Transform;
	public FLinearColor Color;
	public float Scale;
	public float Thickness;
	public FRigElementKey Space;
	public FTransform WorldOffset;
	public bool bEnabled;
}
