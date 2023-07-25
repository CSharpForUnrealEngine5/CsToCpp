#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Simulation/RigUnit_SpringInterp.h")]
///<summary>Uses a simple spring model to interpolate a vector from Current to Target.</summary>
public partial struct FRigUnit_SpringInterpVectorV2 {
// RigUnit_SpringInterpVectorV2
	public FVector Target;
	public float Strength;
	public float CriticalDamping;
	public FVector Force;
	public bool bUseCurrentInput;
	public FVector Current;
	public float TargetVelocityAmount;
	public bool bInitializeFromTarget;
	public FVector Result;
	public FVector Velocity;
	public FVector SimulatedResult;
	public FVectorSpringState SpringState;
}
