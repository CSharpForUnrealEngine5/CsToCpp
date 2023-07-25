#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
///<summary>Multiplies a quaternion over time over and over again</summary>
public partial struct FRigVMFunction_AccumulateQuatMul {
// RigVMFunction_AccumulateQuatMul
	public FQuat Multiplier;
	public FQuat InitialValue;
	public bool bFlipOrder;
	public bool bIntegrateDeltaTime;
	public FQuat Result;
	public FQuat AccumulatedValue;
	public bool bIsInitialized;
}
