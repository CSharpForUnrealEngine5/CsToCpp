namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Interpolates two vectors over time over and over again</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
public partial struct FRigVMFunction_AccumulateVectorLerp {
	public FVector TargetValue;
	public FVector InitialValue;
	public float Blend;
	public bool bIntegrateDeltaTime;
	public FVector Result;
	public FVector AccumulatedValue;
	public bool bIsInitialized;
}
