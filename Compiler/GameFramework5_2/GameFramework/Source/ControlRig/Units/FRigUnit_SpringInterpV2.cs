#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Uses a simple spring model to interpolate a float from Current to Target.</summary>
[CppInclude("Units/Simulation/RigUnit_SpringInterp.h")]
public partial struct FRigUnit_SpringInterpV2 {
	public float Target;
	public float Strength;
	public float CriticalDamping;
	public float Force;
	public bool bUseCurrentInput;
	public float Current;
	public float TargetVelocityAmount;
	public bool bInitializeFromTarget;
	public float Result;
	public float Velocity;
	public float SimulatedResult;
	public FFloatSpringState SpringState;
}
