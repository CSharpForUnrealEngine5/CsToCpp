#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
///<summary>Interpolates two transforms over time over and over again</summary>
public partial struct FRigVMFunction_AccumulateTransformLerp {
// RigVMFunction_AccumulateTransformLerp
	public FTransform TargetValue;
	public FTransform InitialValue;
	public float Blend;
	public bool bIntegrateDeltaTime;
	public FTransform Result;
	public FTransform AccumulatedValue;
	public bool bIsInitialized;
}
