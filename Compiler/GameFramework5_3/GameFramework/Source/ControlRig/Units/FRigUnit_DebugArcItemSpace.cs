namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Draws an arc in the viewport, can take in different min and max degrees</summary>
[CppInclude("Units/Debug/RigUnit_DebugPrimitives.h")]
public partial struct FRigUnit_DebugArcItemSpace {
	public FTransform Transform;
	public FLinearColor Color;
	public float Radius;
	public float MinimumDegrees;
	public float MaximumDegrees;
	public float Thickness;
	public int Detail;
	public FRigElementKey Space;
	public FTransform WorldOffset;
	public bool bEnabled;
}
