#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_DeltaFromPrevious.h")]
///<summary>Computes the difference from the previous value going through the node</summary>
public partial struct FRigVMFunction_DeltaFromPreviousQuat {
// RigVMFunction_DeltaFromPreviousQuat
	public FQuat Value;
	public FQuat Delta;
	public FQuat PreviousValue;
	public FQuat Cache;
	public bool bIsInitialized;
}
