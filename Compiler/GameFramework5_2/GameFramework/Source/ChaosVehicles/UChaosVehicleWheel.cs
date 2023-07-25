#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosVehicleWheel.h")]
public partial class UChaosVehicleWheel : UObject {
// ChaosVehicleWheel
	public UStaticMesh CollisionMesh;
	public EAxleType AxleType;
	public FVector Offset;
	public float WheelRadius;
	public float WheelWidth;
	public float WheelMass;
	public float CorneringStiffness;
	public float FrictionForceMultiplier;
	public float SideSlipModifier;
	public float SlipThreshold;
	public float SkidThreshold;
	public float MaxSteerAngle;
	public bool bAffectedBySteering;
	public bool bAffectedByBrake;
	public bool bAffectedByHandbrake;
	public bool bAffectedByEngine;
	public bool bABSEnabled;
	public bool bTractionControlEnabled;
	public float MaxWheelspinRotation;
	public ETorqueCombineMethod ExternalTorqueCombineMethod;
	public FRuntimeFloatCurve LateralSlipGraph;
	public FVector SuspensionAxis;
	public FVector SuspensionForceOffset;
	public float SuspensionMaxRaise;
	public float SuspensionMaxDrop;
	public float SuspensionDampingRatio;
	public float WheelLoadRatio;
	public float SpringRate;
	public float SpringPreload;
	public int SuspensionSmoothing;
	public float RollbarScaling;
	public ESweepShape SweepShape;
	public ESweepType SweepType;
	public float MaxBrakeTorque;
	public float MaxHandBrakeTorque;
	public UChaosWheeledVehicleMovementComponent VehicleComponent;
	public int WheelIndex;
	public float DebugLongSlip;
	public float DebugLatSlip;
	public float DebugNormalizedTireLoad;
	public float DebugWheelTorque;
	public float DebugLongForce;
	public float DebugLatForce;
	public FVector Location;
	public FVector OldLocation;
	public FVector Velocity;
	public float GetSteerAngle() { return default; }
	public float GetRotationAngle() { return default; }
	public float GetRotationAngularVelocity() { return default; }
	public float GetSuspensionOffset() { return default; }
	public float GetWheelRadius() { return default; }
	public float GetWheelAngularVelocity() { return default; }
	public FVector GetSuspensionAxis() { return default; }
	public bool IsInAir() { return default; }
	public EAxleType GetAxleType() { return default; }
}
