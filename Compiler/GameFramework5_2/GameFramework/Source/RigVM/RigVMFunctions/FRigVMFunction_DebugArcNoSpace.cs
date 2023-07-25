#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Debug/RigVMFunction_DebugPrimitives.h")]
///<summary>Draws an arc in the viewport, can take in different min and max degrees</summary>
public partial struct FRigVMFunction_DebugArcNoSpace {
// RigVMFunction_DebugArcNoSpace
	public FTransform Transform;
	public FLinearColor Color;
	public float Radius;
	public float MinimumDegrees;
	public float MaximumDegrees;
	public float Thickness;
	public int Detail;
	public FTransform WorldOffset;
	public bool bEnabled;
}
