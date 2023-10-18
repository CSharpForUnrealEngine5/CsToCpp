namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosVehicleMovementComponent.h")]
public partial struct FVehicleTorqueControlConfig {
	public bool Enabled;
	public float YawTorqueScaling;
	public float YawFromSteering;
	public float YawFromRollTorqueScaling;
	public float PitchTorqueScaling;
	public float RollTorqueScaling;
	public float RollFromSteering;
	public float RotationDamping;
}
