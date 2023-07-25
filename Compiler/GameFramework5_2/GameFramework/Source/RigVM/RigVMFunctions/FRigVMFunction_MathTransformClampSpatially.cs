#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
///<summary>Clamps a position using a plane collision, cylindric collision or spherical collision.</summary>
public partial struct FRigVMFunction_MathTransformClampSpatially {
// RigVMFunction_MathTransformClampSpatially
	public FTransform Value;
	public byte Axis;
	public byte Type;
	public float Minimum;
	public float Maximum;
	public FTransform Space;
	public bool bDrawDebug;
	public FLinearColor DebugColor;
	public float DebugThickness;
	public FTransform Result;
}
