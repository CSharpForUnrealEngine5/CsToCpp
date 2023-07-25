#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
///<summary>Interpolates two values over time over and over again</summary>
public partial struct FRigVMFunction_AccumulateFloatLerp {
// RigVMFunction_AccumulateFloatLerp
	public float TargetValue;
	public float InitialValue;
	public float Blend;
	public bool bIntegrateDeltaTime;
	public float Result;
	public float AccumulatedValue;
	public bool bIsInitialized;
}
