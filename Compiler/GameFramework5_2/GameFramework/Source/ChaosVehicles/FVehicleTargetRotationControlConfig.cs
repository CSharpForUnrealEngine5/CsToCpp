#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosVehicleMovementComponent.h")]
public partial struct FVehicleTargetRotationControlConfig {
	public bool Enabled;
	public bool bRollVsSpeedEnabled;
	public float RollControlScaling;
	public float RollMaxAngle;
	public float PitchControlScaling;
	public float PitchMaxAngle;
	public float RotationStiffness;
	public float RotationDamping;
	public float MaxAccel;
	public float AutoCentreRollStrength;
	public float AutoCentrePitchStrength;
	public float AutoCentreYawStrength;
}
