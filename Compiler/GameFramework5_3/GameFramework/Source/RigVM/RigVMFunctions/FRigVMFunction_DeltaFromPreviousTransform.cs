namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Computes the difference from the previous value going through the node</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_DeltaFromPrevious.h")]
public partial struct FRigVMFunction_DeltaFromPreviousTransform {
	public FTransform Value;
	public FTransform Delta;
	public FTransform PreviousValue;
	public FTransform Cache;
	public bool bIsInitialized;
}
