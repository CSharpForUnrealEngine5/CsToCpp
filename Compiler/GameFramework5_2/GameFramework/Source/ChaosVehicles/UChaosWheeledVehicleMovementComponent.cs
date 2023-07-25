#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosWheeledVehicleMovementComponent.h")]
public partial class UChaosWheeledVehicleMovementComponent : UChaosVehicleMovementComponent {
// ChaosWheeledVehicleMovementComponent
	public bool bSuspensionEnabled;
	public bool bWheelFrictionEnabled;
	public bool bLegacyWheelFrictionPosition;
	public TArray<FChaosWheelSetup> WheelSetups;
	public FCollisionResponseContainer WheelTraceCollisionResponses;
	public bool bMechanicalSimEnabled;
	public FVehicleEngineConfig EngineSetup;
	public FVehicleDifferentialConfig DifferentialSetup;
	public FVehicleTransmissionConfig TransmissionSetup;
	public FVehicleSteeringConfig SteeringSetup;
	public TArray<UChaosVehicleWheel> Wheels;
	public float GetEngineRotationSpeed() { return default; }
	public float GetEngineMaxRotationSpeed() { return default; }
	public int GetNumWheels() { return default; }
	public void BreakWheelStatus(FWheelStatus Status,bool bInContact,FVector ContactPoint,UObject PhysMaterial,float NormalizedSuspensionLength,float SpringForce,float SlipAngle,bool bIsSlipping,float SlipMagnitude,bool bIsSkidding,float SkidMagnitude,FVector SkidNormal,float DriveTorque,float BrakeTorque,bool bABSActivated) {}
	public FWheelStatus MakeWheelStatus(bool bInContact,FVector ContactPoint,UObject PhysMaterial,float NormalizedSuspensionLength,float SpringForce,float SlipAngle,bool bIsSlipping,float SlipMagnitude,bool bIsSkidding,float SkidMagnitude,FVector SkidNormal,float DriveTorque,float BrakeTorque,bool bABSActivated) { return default; }
	public void BreakWheeledSnapshot(FWheeledSnaphotData Snapshot,FTransform Transform,FVector LinearVelocity,FVector AngularVelocity,int SelectedGear,float EngineRPM,TArray<FWheelSnapshot> WheelSnapshots) {}
	public FWheeledSnaphotData MakeWheeledSnapshot(FTransform Transform,FVector LinearVelocity,FVector AngularVelocity,int SelectedGear,float EngineRPM,TArray<FWheelSnapshot> WheelSnapshots) { return default; }
	public void BreakWheelSnapshot(FWheelSnapshot Snapshot,float SuspensionOffset,float WheelRotationAngle,float SteeringAngle,float WheelRadius,float WheelAngularVelocity) {}
	public FWheelSnapshot MakeWheelSnapshot(float SuspensionOffset,float WheelRotationAngle,float SteeringAngle,float WheelRadius,float WheelAngularVelocity) { return default; }
	public FWheelStatus GetWheelState(int WheelIndex) { return default; }
	public void EnableMechanicalSim(bool InState) {}
	public void EnableSuspension(bool InState) {}
	public void EnableWheelFriction(bool InState) {}
	public void SetWheelClass(int WheelIndex,UClass InWheelClass) {}
	public FWheeledSnaphotData GetSnapshot() { return default; }
	public void SetSnapshot(FWheeledSnaphotData SnapshotIn) {}
	public void SetMaxEngineTorque(float Torque) {}
	public void SetDragCoefficient(float DragCoeff) {}
	public void SetDownforceCoefficient(float DownforceCoeff) {}
	public void SetDifferentialFrontRearSplit(float FrontRearSlpit) {}
	public void SetTractionControlEnabled(int WheelIndex,bool Enabled) {}
	public void SetABSEnabled(int WheelIndex,bool Enabled) {}
	public void SetAffectedByBrake(int WheelIndex,bool Enabled) {}
	public void SetAffectedByHandbrake(int WheelIndex,bool Enabled) {}
	public void SetAffectedBySteering(int WheelIndex,bool Enabled) {}
	public void SetAffectedByEngine(int WheelIndex,bool Enabled) {}
	public void SetWheelRadius(int WheelIndex,float Radius) {}
	public void SetWheelFrictionMultiplier(int WheelIndex,float Friction) {}
	public void SetWheelSlipGraphMultiplier(int WheelIndex,float Multiplier) {}
	public void SetWheelMaxBrakeTorque(int WheelIndex,float Torque) {}
	public void SetWheelHandbrakeTorque(int WheelIndex,float Torque) {}
	public void SetWheelMaxSteerAngle(int WheelIndex,float AngleDegrees) {}
	public void SetTorqueCombineMethod(ETorqueCombineMethod InCombineMethod,int WheelIndex) {}
	public void SetDriveTorque(float DriveTorque,int WheelIndex) {}
	public void SetBrakeTorque(float BrakeTorque,int WheelIndex) {}
	public void SetSuspensionParams(float Rate,float Damping,float Preload,float MaxRaise,float MaxDrop,int WheelIndex) {}
}
