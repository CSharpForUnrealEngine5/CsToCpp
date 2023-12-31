namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Clamps a position using a plane collision, cylindric collision or spherical collision.</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
public partial struct FRigVMFunction_MathTransformClampSpatially {
	public FTransform Value;
	public EAxis Axis;
	public ERigVMClampSpatialMode Type;
	public float Minimum;
	public float Maximum;
	public FTransform Space;
	public bool bDrawDebug;
	public FLinearColor DebugColor;
	public float DebugThickness;
	public FTransform Result;
}
