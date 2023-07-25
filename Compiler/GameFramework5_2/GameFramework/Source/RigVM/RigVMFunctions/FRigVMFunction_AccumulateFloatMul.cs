#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
///<summary>Multiplies a value over time over and over again</summary>
public partial struct FRigVMFunction_AccumulateFloatMul {
// RigVMFunction_AccumulateFloatMul
	public float Multiplier;
	public float InitialValue;
	public bool bIntegrateDeltaTime;
	public float Result;
	public float AccumulatedValue;
	public bool bIsInitialized;
}
