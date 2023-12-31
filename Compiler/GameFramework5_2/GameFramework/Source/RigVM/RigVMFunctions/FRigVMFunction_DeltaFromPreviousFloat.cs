namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Computes the difference from the previous value going through the node</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_DeltaFromPrevious.h")]
public partial struct FRigVMFunction_DeltaFromPreviousFloat {
	public float Value;
	public float Delta;
	public float PreviousValue;
	public float Cache;
	public bool bIsInitialized;
}
