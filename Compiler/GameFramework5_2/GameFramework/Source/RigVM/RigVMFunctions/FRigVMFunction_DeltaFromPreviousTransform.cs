#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_DeltaFromPrevious.h")]
///<summary>Computes the difference from the previous value going through the node</summary>
public partial struct FRigVMFunction_DeltaFromPreviousTransform {
// RigVMFunction_DeltaFromPreviousTransform
	public FTransform Value;
	public FTransform Delta;
	public FTransform PreviousValue;
	public FTransform Cache;
	public bool bIsInitialized;
}
