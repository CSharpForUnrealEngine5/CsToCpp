namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simulates a time value - can act as a timeline playing back</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Timeline.h")]
public partial struct FRigVMFunction_Timeline {
	public float Speed;
	public float Time;
	public float AccumulatedValue;
	public bool bIsInitialized;
}
