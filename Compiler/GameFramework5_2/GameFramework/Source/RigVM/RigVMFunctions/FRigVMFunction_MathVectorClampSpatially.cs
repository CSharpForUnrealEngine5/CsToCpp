#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Clamps a position using a plane collision, cylindric collision or spherical collision.</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
public partial struct FRigVMFunction_MathVectorClampSpatially {
	public FVector Value;
	public EAxis Axis;
	public ERigVMClampSpatialMode Type;
	public float Minimum;
	public float Maximum;
	public FTransform Space;
	public bool bDrawDebug;
	public FLinearColor DebugColor;
	public float DebugThickness;
	public FVector Result;
}
