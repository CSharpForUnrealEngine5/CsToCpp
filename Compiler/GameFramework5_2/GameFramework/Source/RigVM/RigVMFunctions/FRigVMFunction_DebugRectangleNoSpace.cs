#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Debug/RigVMFunction_DebugPrimitives.h")]
///<summary>Draws a rectangle in the viewport given a transform</summary>
public partial struct FRigVMFunction_DebugRectangleNoSpace {
// RigVMFunction_DebugRectangleNoSpace
	public FTransform Transform;
	public FLinearColor Color;
	public float Scale;
	public float Thickness;
	public FTransform WorldOffset;
	public bool bEnabled;
}
