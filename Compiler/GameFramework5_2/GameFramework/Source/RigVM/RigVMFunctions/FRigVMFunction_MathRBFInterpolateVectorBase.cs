#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathRBFInterpolate.h")]
public partial struct FRigVMFunction_MathRBFInterpolateVectorBase {
// RigVMFunction_MathRBFInterpolateVectorBase
	public FVector Input;
	public ERBFVectorDistanceType DistanceFunction;
	public ERBFKernelType SmoothingFunction;
	public float SmoothingRadius;
	public bool bNormalizeOutput;
	public FRigVMFunction_MathRBFInterpolateVectorWorkData WorkData;
}
