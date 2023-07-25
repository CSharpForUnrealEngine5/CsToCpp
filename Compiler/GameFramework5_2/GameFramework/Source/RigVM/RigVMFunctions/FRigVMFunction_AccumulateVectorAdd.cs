#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
///<summary>Adds a vector over time over and over again</summary>
public partial struct FRigVMFunction_AccumulateVectorAdd {
// RigVMFunction_AccumulateVectorAdd
	public FVector Increment;
	public FVector InitialValue;
	public bool bIntegrateDeltaTime;
	public FVector Result;
	public FVector AccumulatedValue;
	public bool bIsInitialized;
}
