#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Debug/RigUnit_DebugBezier.h")]
public partial struct FRigUnit_DebugBezier {
// RigUnit_DebugBezier
	public FRigVMFourPointBezier Bezier;
	public float MinimumU;
	public float MaximumU;
	public FLinearColor Color;
	public float Thickness;
	public int Detail;
	public string Space;
	public FTransform WorldOffset;
	public bool bEnabled;
}
