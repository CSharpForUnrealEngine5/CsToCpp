namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Multiplies a vector over time over and over again</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
public partial struct FRigVMFunction_AccumulateVectorMul {
	public FVector Multiplier;
	public FVector InitialValue;
	public bool bIntegrateDeltaTime;
	public FVector Result;
	public FVector AccumulatedValue;
	public bool bIsInitialized;
}
