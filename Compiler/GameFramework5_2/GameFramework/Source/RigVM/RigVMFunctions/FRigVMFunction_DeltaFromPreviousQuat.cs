#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Computes the difference from the previous value going through the node</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_DeltaFromPrevious.h")]
public partial struct FRigVMFunction_DeltaFromPreviousQuat {
	public FQuat Value;
	public FQuat Delta;
	public FQuat PreviousValue;
	public FQuat Cache;
	public bool bIsInitialized;
}
