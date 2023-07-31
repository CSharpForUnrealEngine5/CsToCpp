#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Draws an arc in the viewport, can take in different min and max degrees</summary>
[CppInclude("RigVMFunctions/Debug/RigVMFunction_DebugPrimitives.h")]
public partial struct FRigVMFunction_DebugArcNoSpace {
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
