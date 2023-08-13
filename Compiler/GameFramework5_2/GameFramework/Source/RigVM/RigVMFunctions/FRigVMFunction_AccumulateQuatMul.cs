namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Multiplies a quaternion over time over and over again</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
public partial struct FRigVMFunction_AccumulateQuatMul {
	public FQuat Multiplier;
	public FQuat InitialValue;
	public bool bFlipOrder;
	public bool bIntegrateDeltaTime;
	public FQuat Result;
	public FQuat AccumulatedValue;
	public bool bIsInitialized;
}
