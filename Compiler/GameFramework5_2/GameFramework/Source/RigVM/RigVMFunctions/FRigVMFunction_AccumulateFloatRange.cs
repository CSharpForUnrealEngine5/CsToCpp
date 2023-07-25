#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
///<summary>Accumulates the min and max values over time</summary>
public partial struct FRigVMFunction_AccumulateFloatRange {
// RigVMFunction_AccumulateFloatRange
	public float Value;
	public float Minimum;
	public float Maximum;
	public float AccumulatedMinimum;
	public float AccumulatedMaximum;
	public bool bIsInitialized;
}
