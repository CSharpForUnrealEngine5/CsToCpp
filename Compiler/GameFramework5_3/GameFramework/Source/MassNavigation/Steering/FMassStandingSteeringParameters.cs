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
