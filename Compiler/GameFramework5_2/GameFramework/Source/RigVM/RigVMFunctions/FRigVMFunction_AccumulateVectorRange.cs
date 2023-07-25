#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
///<summary>Accumulates the min and max values over time</summary>
public partial struct FRigVMFunction_AccumulateVectorRange {
// RigVMFunction_AccumulateVectorRange
	public FVector Value;
	public FVector Minimum;
	public FVector Maximum;
	public FVector AccumulatedMinimum;
	public FVector AccumulatedMaximum;
	public bool bIsInitialized;
}
