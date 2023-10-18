namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Draws a line in the viewport given a start and end vector</summary>
[CppInclude("Units/Debug/RigUnit_DebugLine.h")]
public partial struct FRigUnit_DebugLineItemSpace {
	public FVector A;
	public FVector B;
	public FLinearColor Color;
	public float Thickness;
	public FRigElementKey Space;
	public FTransform WorldOffset;
	public bool bEnabled;
}
