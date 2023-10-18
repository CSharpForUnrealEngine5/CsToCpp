namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Interpolates two transforms over time over and over again</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
public partial struct FRigVMFunction_AccumulateTransformLerp {
	public FTransform TargetValue;
	public FTransform InitialValue;
	public float Blend;
	public bool bIntegrateDeltaTime;
	public FTransform Result;
	public FTransform AccumulatedValue;
	public bool bIsInitialized;
}
