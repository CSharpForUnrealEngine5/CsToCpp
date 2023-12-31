namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Computes the difference from the previous value going through the node</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_DeltaFromPrevious.h")]
public partial struct FRigVMFunction_DeltaFromPreviousVector {
	public FVector Value;
	public FVector Delta;
	public FVector PreviousValue;
	public FVector Cache;
	public bool bIsInitialized;
}
