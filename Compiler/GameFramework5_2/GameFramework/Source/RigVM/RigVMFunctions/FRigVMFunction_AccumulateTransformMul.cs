#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Multiplies a transform over time over and over again</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
public partial struct FRigVMFunction_AccumulateTransformMul {
	public FTransform Multiplier;
	public FTransform InitialValue;
	public bool bFlipOrder;
	public bool bIntegrateDeltaTime;
	public FTransform Result;
	public FTransform AccumulatedValue;
	public bool bIsInitialized;
}
