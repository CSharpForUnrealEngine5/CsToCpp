#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Interpolates two quaternions over time over and over again</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
public partial struct FRigVMFunction_AccumulateQuatLerp {
	public FQuat TargetValue;
	public FQuat InitialValue;
	public float Blend;
	public bool bIntegrateDeltaTime;
	public FQuat Result;
	public FQuat AccumulatedValue;
	public bool bIsInitialized;
}
