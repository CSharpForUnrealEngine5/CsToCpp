namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Draws a line strip in the viewport given any number of points</summary>
[CppInclude("Units/Debug/RigUnit_DebugLineStrip.h")]
public partial struct FRigUnit_DebugLineStripItemSpace {
	public TArray<FVector> Points;
	public FLinearColor Color;
	public float Thickness;
	public FRigElementKey Space;
	public FTransform WorldOffset;
	public bool bEnabled;
}
