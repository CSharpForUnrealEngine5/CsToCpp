#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ParametricMovement.h")]
///<summary>Extremely simple struct for defining parametric motion. This is editable in UParametricMovementComponent's defaults, and also used by the simulation code.</summary>
public partial struct FSimpleParametricMotion {
// SimpleParametricMotion
	public FVector ParametricDelta;
	public float MinTime;
	public float MaxTime;
}
