namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosWheeledVehicleMovementComponent.h")]
public partial class UChaosWheeledVehicleMovementComponent : UChaosVehicleMovementComponent {
	public static UClass StaticClass() {return default;}
	///<summary>bSuspensionEnabled</summary>
	public bool bSuspensionEnabled;
	///<summary>bWheelFrictionEnabled</summary>
	public bool bWheelFrictionEnabled;
	///<summary>bLegacyWheelFrictionPosition</summary>
	public bool bLegacyWheelFrictionPosition;
	///<summary>Wheels to create</summary>
	public TArray<FChaosWheelSetup> WheelSetups;
	///<summary>WheelTraceCollisionResponses</summary>
	public FCollisionResponseContainer WheelTraceCollisionResponses;
	///<summary>bMechanicalSimEnabled</summary>
	public bool bMechanicalSimEnabled;
	///<summary>Engine</summary>
	public FVehicleEngineConfig EngineSetup;
	///<summary>Differential</summary>
	public FVehicleDifferentialConfig DifferentialSetup;
	///<summary>Transmission data</summary>
	public FVehicleTransmissionConfig TransmissionSetup;
	///<summary>Transmission data</summary>
	public FVehicleSteeringConfig SteeringSetup;
	///<summary>Our instanced wheels</summary>
	public TArray<UChaosVehicleWheel> Wheels;
	///<summary>Get current engine&#39;s rotation speed</summary>
	public float GetEngineRotationSpeed() { return default; }
	///<summary>Get current engine&#39;s max rotation speed</summary>
	public float GetEngineMaxRotationSpeed() { return default; }
	///<summary>GetNumWheels</summary>
	public int GetNumWheels() { return default; }
	///<summary>BreakWheelStatus</summary>
	public static void BreakWheelStatus(FWheelStatus Status,bool bInContact,FVector ContactPoint,UPhysicalMaterial PhysMaterial,float NormalizedSuspensionLength,float SpringForce,float SlipAngle,bool bIsSlipping,float SlipMagnitude,bool bIsSkidding,float SkidMagnitude,FVector SkidNormal,float DriveTorque,float BrakeTorque,bool bABSActivated) {}
	///<summary>MakeWheelStatus</summary>
	public static FWheelStatus MakeWheelStatus(bool bInContact,FVector ContactPoint,UPhysicalMaterial PhysMaterial,float NormalizedSuspensionLength,float SpringForce,float SlipAngle,bool bIsSlipping,float SlipMagnitude,bool bIsSkidding,float SkidMagnitude,FVector SkidNormal,float DriveTorque,float BrakeTorque,bool bABSActivated) { return default; }
	///<summary>BreakWheeledSnapshot</summary>
	public static void BreakWheeledSnapshot(FWheeledSnaphotData Snapshot,FTransform Transform,FVector LinearVelocity,FVector AngularVelocity,int SelectedGear,float EngineRPM,TArray<FWheelSnapshot> WheelSnapshots) {}
	///<summary>MakeWheeledSnapshot</summary>
	public static FWheeledSnaphotData MakeWheeledSnapshot(FTransform Transform,FVector LinearVelocity,FVector AngularVelocity,int SelectedGear,float EngineRPM,TArray<FWheelSnapshot> WheelSnapshots) { return default; }
	///<summary>BreakWheelSnapshot</summary>
	public static void BreakWheelSnapshot(FWheelSnapshot Snapshot,float SuspensionOffset,float WheelRotationAngle,float SteeringAngle,float WheelRadius,float WheelAngularVelocity) {}
	///<summary>MakeWheelSnapshot</summary>
	public static FWheelSnapshot MakeWheelSnapshot(float SuspensionOffset,float WheelRotationAngle,float SteeringAngle,float WheelRadius,float WheelAngularVelocity) { return default; }
	///<summary>Get a wheels current simulation state</summary>
	public FWheelStatus GetWheelState(int WheelIndex) { return default; }
	///<summary>Enable or completely bypass the ProcessMechanicalSimulation call</summary>
	public void EnableMechanicalSim(bool InState) {}
	///<summary>Enable or completely bypass the ApplySuspensionForces call</summary>
	public void EnableSuspension(bool InState) {}
	///<summary>Enable or completely bypass the ApplyWheelFrictionForces call</summary>
	public void EnableWheelFriction(bool InState) {}
	///<summary>SetWheelClass</summary>
	public void SetWheelClass(int WheelIndex,UClass InWheelClass) {}
	///<summary>Grab a snapshot of the vehicle instance dynamic state</summary>
	public virtual FWheeledSnaphotData GetSnapshot() { return default; }
	///<summary>Set snapshot of vehicle instance dynamic state</summary>
	public virtual void SetSnapshot(FWheeledSnaphotData SnapshotIn) {}
	///<summary>change handling via blueprint at runtime</summary>
	public void SetMaxEngineTorque(float Torque) {}
	///<summary>SetDragCoefficient</summary>
	public void SetDragCoefficient(float DragCoeff) {}
	///<summary>SetDownforceCoefficient</summary>
	public void SetDownforceCoefficient(float DownforceCoeff) {}
	///<summary>SetDifferentialFrontRearSplit</summary>
	public void SetDifferentialFrontRearSplit(float FrontRearSlpit) {}
	///<summary>SetTractionControlEnabled</summary>
	public void SetTractionControlEnabled(int WheelIndex,bool Enabled) {}
	///<summary>SetABSEnabled</summary>
	public void SetABSEnabled(int WheelIndex,bool Enabled) {}
	///<summary>SetAffectedByBrake</summary>
	public void SetAffectedByBrake(int WheelIndex,bool Enabled) {}
	///<summary>SetAffectedByHandbrake</summary>
	public void SetAffectedByHandbrake(int WheelIndex,bool Enabled) {}
	///<summary>SetAffectedBySteering</summary>
	public void SetAffectedBySteering(int WheelIndex,bool Enabled) {}
	///<summary>SetAffectedByEngine</summary>
	public void SetAffectedByEngine(int WheelIndex,bool Enabled) {}
	///<summary>SetWheelRadius</summary>
	public void SetWheelRadius(int WheelIndex,float Radius) {}
	///<summary>SetWheelFrictionMultiplier</summary>
	public void SetWheelFrictionMultiplier(int WheelIndex,float Friction) {}
	///<summary>SetWheelSlipGraphMultiplier</summary>
	public void SetWheelSlipGraphMultiplier(int WheelIndex,float Multiplier) {}
	///<summary>SetWheelMaxBrakeTorque</summary>
	public void SetWheelMaxBrakeTorque(int WheelIndex,float Torque) {}
	///<summary>SetWheelHandbrakeTorque</summary>
	public void SetWheelHandbrakeTorque(int WheelIndex,float Torque) {}
	///<summary>SetWheelMaxSteerAngle</summary>
	public void SetWheelMaxSteerAngle(int WheelIndex,float AngleDegrees) {}
	///<summary>SetTorqueCombineMethod</summary>
	public void SetTorqueCombineMethod(ETorqueCombineMethod InCombineMethod,int WheelIndex) {}
	///<summary>SetDriveTorque</summary>
	public void SetDriveTorque(float DriveTorque,int WheelIndex) {}
	///<summary>SetBrakeTorque</summary>
	public void SetBrakeTorque(float BrakeTorque,int WheelIndex) {}
	///<summary>SetSuspensionParams</summary>
	public void SetSuspensionParams(float Rate,float Damping,float Preload,float MaxRaise,float MaxDrop,int WheelIndex) {}
}
