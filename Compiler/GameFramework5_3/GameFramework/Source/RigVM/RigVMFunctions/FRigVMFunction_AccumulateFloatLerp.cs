namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Interpolates two values over time over and over again</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
public partial struct FRigVMFunction_AccumulateFloatLerp {
	public float TargetValue;
	public float InitialValue;
	public float Blend;
	public bool bIntegrateDeltaTime;
	public float Result;
	public float AccumulatedValue;
	public bool bIsInitialized;
}
