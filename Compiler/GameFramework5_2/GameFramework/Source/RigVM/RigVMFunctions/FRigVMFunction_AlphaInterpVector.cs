namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Takes in a vector value and outputs an accumulated value with a customized scale and clamp</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_AlphaInterp.h")]
public partial struct FRigVMFunction_AlphaInterpVector {
	public FVector Value;
	public float Scale;
	public float Bias;
	public bool bMapRange;
	public FInputRange InRange;
	public FInputRange OutRange;
	public bool bClampResult;
	public float ClampMin;
	public float ClampMax;
	public bool bInterpResult;
	public float InterpSpeedIncreasing;
	public float InterpSpeedDecreasing;
	public FVector Result;
	public FInputScaleBiasClamp ScaleBiasClamp;
}
