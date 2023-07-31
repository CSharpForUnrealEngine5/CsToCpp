#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Steering/MassSteeringFragments.h")]
public partial struct FMassStandingSteeringParameters {
	public float ReactionTime;
	public float TargetMoveThreshold;
	public float TargetMoveThresholdVariance;
	public float LowSpeedThreshold;
	public float TargetSpeedHysteresisScale;
	public float TargetSelectionCooldown;
	public float TargetSelectionCooldownVariance;
	public float DeadZoneRadius;
}
