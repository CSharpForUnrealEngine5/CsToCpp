#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosVehicleWheel.h")]
public partial class UChaosVehicleWheel : UObject {
	///<summary>Static mesh with collision setup for wheel, will be used to create wheel shape</summary>
	public UStaticMesh CollisionMesh;
	///<summary>If left undefined then the bAffectedByEngine value is used, if defined then bAffectedByEngine is ignored and the differential setup on the vehicle defines which wheels get power from the engine</summary>
	public EAxleType AxleType;
	///<summary>If BoneName is specified, offset the wheel from the bone&#39;s location.</summary>
	public FVector Offset;
	///<summary>Radius of the wheel</summary>
	public float WheelRadius;
	///<summary>Width of the wheel</summary>
	public float WheelWidth;
	///<summary>Mass of the wheel Kg</summary>
	public float WheelMass;
	///<summary>Tyre Cornering Ability</summary>
	public float CorneringStiffness;
	///<summary>Friction Force Multiplier</summary>
	public float FrictionForceMultiplier;
	///<summary>Wheel Lateral Skid Grip Loss, lower number less grip on skid</summary>
	public float SideSlipModifier;
	///<summary>Wheel Longitudinal Slip Threshold</summary>
	public float SlipThreshold;
	///<summary>Wheel Lateral Skid Threshold</summary>
	public float SkidThreshold;
	///<summary>steer angle in degrees for this wheel</summary>
	public float MaxSteerAngle;
	///<summary>Whether steering should affect this wheel</summary>
	public bool bAffectedBySteering;
	///<summary>Whether brake should affect this wheel</summary>
	public bool bAffectedByBrake;
	///<summary>Whether handbrake should affect this wheel</summary>
	public bool bAffectedByHandbrake;
	///<summary>Whether engine should power this wheel</summary>
	public bool bAffectedByEngine;
	///<summary>Advanced Braking System Enabled</summary>
	public bool bABSEnabled;
	///<summary>Straight Line Traction Control Enabled</summary>
	public bool bTractionControlEnabled;
	///<summary>Max Wheelspin rotation rad/sec</summary>
	public float MaxWheelspinRotation;
	///<summary>Determines how the SetDriveTorque/SetBrakeTorque inputs are combined with the internal torques</summary>
	public ETorqueCombineMethod ExternalTorqueCombineMethod;
	///<summary>LateralSlipGraph</summary>
	public FRuntimeFloatCurve LateralSlipGraph;
	///<summary>Local body direction in which where suspension forces are applied (typically along -Z-axis)</summary>
	public FVector SuspensionAxis;
	///<summary>Vertical offset from where suspension forces are applied (along Z-axis)</summary>
	public FVector SuspensionForceOffset;
	///<summary>How far the wheel can go above the resting position</summary>
	public float SuspensionMaxRaise;
	///<summary>How far the wheel can drop below the resting position</summary>
	public float SuspensionMaxDrop;
	///<summary>Suspension damping, larger value causes the suspension to come to rest faster [range 0 to 1]</summary>
	public float SuspensionDampingRatio;
	///<summary>Amount wheel load effects wheel friction.</summary>
	public float WheelLoadRatio;
	///<summary>Spring Force (N/m)</summary>
	public float SpringRate;
	///<summary>Spring Preload (N/m)</summary>
	public float SpringPreload;
	///<summary>Smooth suspension [0-off, 10-max] - Warning might cause momentary visual inter-penetration of the wheel against objects/terrain</summary>
	public int SuspensionSmoothing;
	///<summary>Anti-roll effect</summary>
	public float RollbarScaling;
	///<summary>Wheel suspension trace type, defaults to ray trace</summary>
	public ESweepShape SweepShape;
	///<summary>Whether wheel suspension considers simple, complex</summary>
	public ESweepType SweepType;
	///<summary>max brake torque for this wheel (Nm)</summary>
	public float MaxBrakeTorque;
	///<summary>Max handbrake brake torque for this wheel (Nm). A handbrake should have a stronger brake torque</summary>
	public float MaxHandBrakeTorque;
	///<summary>The vehicle that owns us</summary>
	public UChaosWheeledVehicleMovementComponent VehicleComponent;
	///<summary>Our index in the vehicle&#39;s (and setup&#39;s) wheels array</summary>
	public int WheelIndex;
	///<summary>Longitudinal slip experienced by the wheel</summary>
	public float DebugLongSlip;
	///<summary>Lateral slip experienced by the wheel</summary>
	public float DebugLatSlip;
	///<summary>How much force the tire experiences at rest divided by how much force it is experiencing now</summary>
	public float DebugNormalizedTireLoad;
	///<summary>Wheel torque</summary>
	public float DebugWheelTorque;
	///<summary>Longitudinal force the wheel is applying to the chassis</summary>
	public float DebugLongForce;
	///<summary>Lateral force the wheel is applying to the chassis</summary>
	public float DebugLatForce;
	///<summary>Worldspace location of this wheel</summary>
	public FVector Location;
	///<summary>Worldspace location of this wheel last frame</summary>
	public FVector OldLocation;
	///<summary>Current velocity of the wheel center (change in location over time)</summary>
	public FVector Velocity;
	///<summary>GetSteerAngle</summary>
	public  float GetSteerAngle() { return default; }
	///<summary>GetRotationAngle</summary>
	public  float GetRotationAngle() { return default; }
	///<summary>GetRotationAngularVelocity</summary>
	public  float GetRotationAngularVelocity() { return default; }
	///<summary>GetSuspensionOffset</summary>
	public  float GetSuspensionOffset() { return default; }
	///<summary>GetWheelRadius</summary>
	public  float GetWheelRadius() { return default; }
	///<summary>GetWheelAngularVelocity</summary>
	public  float GetWheelAngularVelocity() { return default; }
	///<summary>GetSuspensionAxis</summary>
	public  FVector GetSuspensionAxis() { return default; }
	///<summary>IsInAir</summary>
	public  bool IsInAir() { return default; }
	///<summary>GetAxleType</summary>
	public  EAxleType GetAxleType() { return default; }
}
