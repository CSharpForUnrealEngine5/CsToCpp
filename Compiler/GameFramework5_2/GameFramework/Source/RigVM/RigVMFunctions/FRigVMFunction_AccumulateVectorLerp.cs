#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
///<summary>Interpolates two vectors over time over and over again</summary>
public partial struct FRigVMFunction_AccumulateVectorLerp {
// RigVMFunction_AccumulateVectorLerp
	public FVector TargetValue;
	public FVector InitialValue;
	public float Blend;
	public bool bIntegrateDeltaTime;
	public FVector Result;
	public FVector AccumulatedValue;
	public bool bIsInitialized;
}
