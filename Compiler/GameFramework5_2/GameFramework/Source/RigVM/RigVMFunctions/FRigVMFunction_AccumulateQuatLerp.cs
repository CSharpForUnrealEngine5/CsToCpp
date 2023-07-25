#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
///<summary>Interpolates two quaternions over time over and over again</summary>
public partial struct FRigVMFunction_AccumulateQuatLerp {
// RigVMFunction_AccumulateQuatLerp
	public FQuat TargetValue;
	public FQuat InitialValue;
	public float Blend;
	public bool bIntegrateDeltaTime;
	public FQuat Result;
	public FQuat AccumulatedValue;
	public bool bIsInitialized;
}
