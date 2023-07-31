#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathRBFInterpolate.h")]
public partial struct FRigVMFunction_MathRBFInterpolateQuatBase {
	public FQuat Input;
	public ERBFQuatDistanceType DistanceFunction;
	public ERBFKernelType SmoothingFunction;
	public float SmoothingAngle;
	public bool bNormalizeOutput;
	public FVector TwistAxis;
	public FRigVMFunction_MathRBFInterpolateQuatWorkData WorkData;
}
