#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
///<summary>Adds a value over time over and over again</summary>
public partial struct FRigVMFunction_AccumulateFloatAdd {
// RigVMFunction_AccumulateFloatAdd
	public float Increment;
	public float InitialValue;
	public bool bIntegrateDeltaTime;
	public float Result;
	public float AccumulatedValue;
	public bool bIsInitialized;
}
