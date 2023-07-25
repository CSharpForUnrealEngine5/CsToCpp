#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotorPhysicsSimComponent.h")]
///<summary>Uses throttle input to run a physics simulation to drive RPM and shift gears when needed</summary>
public partial class UMotorPhysicsSimComponent : UAudioMotorSimComponent {
// MotorPhysicsSimComponent
	public float Weight;
	public float EngineTorque;
	public float BrakingHorsePower;
	public TArray<float> GearRatios;
	public float ClutchedGearRatio;
	public bool bUseInfiniteGears;
	public bool bAlwaysDownshiftToZerothGear;
	public float InfiniteGearRatio;
	public float UpShiftMaxRpm;
	public float DownShiftStartRpm;
	public float ClutchedForceModifier;
	public float EngineGearRatio;
	public float EngineFriction;
	public float GroundFriction;
	public float WindResistancePerVelocity;
	public float ThrottleInterpolationTime;
	public float RpmInterpSpeed;
	public FOnGearChanged OnGearChangedEvent;
}
