namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adds a value over time over and over again</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
public partial struct FRigVMFunction_AccumulateFloatAdd {
	public float Increment;
	public float InitialValue;
	public bool bIntegrateDeltaTime;
	public float Result;
	public float AccumulatedValue;
	public bool bIsInitialized;
}
