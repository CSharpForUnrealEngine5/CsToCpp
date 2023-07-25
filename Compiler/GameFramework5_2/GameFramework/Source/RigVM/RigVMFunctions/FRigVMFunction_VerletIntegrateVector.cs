#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Verlet.h")]
///<summary>Simulates a single position over time using Verlet integration. It is recommended to use SpringInterp instead as it</summary>
public partial struct FRigVMFunction_VerletIntegrateVector {
// RigVMFunction_VerletIntegrateVector
	public FVector Target;
	public float Strength;
	public float Damp;
	public float Blend;
	public FVector Force;
	public FVector Position;
	public FVector Velocity;
	public FVector Acceleration;
	public FRigVMSimPoint Point;
	public bool bInitialized;
}
