namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Draws a rectangle in the viewport given a transform</summary>
[CppInclude("RigVMFunctions/Debug/RigVMFunction_DebugPrimitives.h")]
public partial struct FRigVMFunction_DebugRectangleNoSpace {
	public FTransform Transform;
	public FLinearColor Color;
	public float Scale;
	public float Thickness;
	public FTransform WorldOffset;
	public bool bEnabled;
}
