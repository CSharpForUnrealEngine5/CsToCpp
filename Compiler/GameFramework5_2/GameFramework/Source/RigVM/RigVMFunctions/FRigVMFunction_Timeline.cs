#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Timeline.h")]
///<summary>Simulates a time value - can act as a timeline playing back</summary>
public partial struct FRigVMFunction_Timeline {
// RigVMFunction_Timeline
	public float Speed;
	public float Time;
	public float AccumulatedValue;
	public bool bIsInitialized;
}
