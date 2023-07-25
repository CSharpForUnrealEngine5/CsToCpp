#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
///<summary>Multiplies a transform over time over and over again</summary>
public partial struct FRigVMFunction_AccumulateTransformMul {
// RigVMFunction_AccumulateTransformMul
	public FTransform Multiplier;
	public FTransform InitialValue;
	public bool bFlipOrder;
	public bool bIntegrateDeltaTime;
	public FTransform Result;
	public FTransform AccumulatedValue;
	public bool bIsInitialized;
}
