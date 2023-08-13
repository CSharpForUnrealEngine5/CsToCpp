namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Extremely simple struct for defining parametric motion. This is editable in UParametricMovementComponent&#39;s defaults, and also used by the simulation code.</summary>
[CppInclude("ParametricMovement.h")]
public partial struct FSimpleParametricMotion {
	public FVector ParametricDelta;
	public float MinTime;
	public float MaxTime;
}
