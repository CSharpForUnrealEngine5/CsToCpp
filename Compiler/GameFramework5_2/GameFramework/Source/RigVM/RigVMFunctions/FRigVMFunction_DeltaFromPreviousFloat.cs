#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_DeltaFromPrevious.h")]
///<summary>Computes the difference from the previous value going through the node</summary>
public partial struct FRigVMFunction_DeltaFromPreviousFloat {
// RigVMFunction_DeltaFromPreviousFloat
	public float Value;
	public float Delta;
	public float PreviousValue;
	public float Cache;
	public bool bIsInitialized;
}
