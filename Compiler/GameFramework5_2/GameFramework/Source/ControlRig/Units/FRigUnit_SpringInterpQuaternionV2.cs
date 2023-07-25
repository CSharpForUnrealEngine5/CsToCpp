#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Simulation/RigUnit_SpringInterp.h")]
///<summary>Uses a simple spring model to interpolate a quaternion from Current to Target.</summary>
public partial struct FRigUnit_SpringInterpQuaternionV2 {
// RigUnit_SpringInterpQuaternionV2
	public FQuat Target;
	public float Strength;
	public float CriticalDamping;
	public FVector Torque;
	public bool bUseCurrentInput;
	public FQuat Current;
	public float TargetVelocityAmount;
	public bool bInitializeFromTarget;
	public FQuat Result;
	public FVector AngularVelocity;
	public FQuat SimulatedResult;
	public FQuaternionSpringState SpringState;
}
