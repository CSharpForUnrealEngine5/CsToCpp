namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Accumulates the min and max values over time</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
public partial struct FRigVMFunction_AccumulateFloatRange {
	public float Value;
	public float Minimum;
	public float Maximum;
	public float AccumulatedMinimum;
	public float AccumulatedMaximum;
	public bool bIsInitialized;
}
