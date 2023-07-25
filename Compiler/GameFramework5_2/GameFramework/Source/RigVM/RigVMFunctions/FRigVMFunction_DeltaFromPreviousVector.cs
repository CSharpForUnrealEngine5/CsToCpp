#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_DeltaFromPrevious.h")]
///<summary>Computes the difference from the previous value going through the node</summary>
public partial struct FRigVMFunction_DeltaFromPreviousVector {
// RigVMFunction_DeltaFromPreviousVector
	public FVector Value;
	public FVector Delta;
	public FVector PreviousValue;
	public FVector Cache;
	public bool bIsInitialized;
}
