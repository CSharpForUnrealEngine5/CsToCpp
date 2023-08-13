namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adds a vector over time over and over again</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
public partial struct FRigVMFunction_AccumulateVectorAdd {
	public FVector Increment;
	public FVector InitialValue;
	public bool bIntegrateDeltaTime;
	public FVector Result;
	public FVector AccumulatedValue;
	public bool bIsInitialized;
}
