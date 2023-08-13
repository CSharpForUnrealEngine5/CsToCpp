namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Accumulates the min and max values over time</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
public partial struct FRigVMFunction_AccumulateVectorRange {
	public FVector Value;
	public FVector Minimum;
	public FVector Maximum;
	public FVector AccumulatedMinimum;
	public FVector AccumulatedMaximum;
	public bool bIsInitialized;
}
