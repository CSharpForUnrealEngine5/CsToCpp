namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Uses throttle input to run a physics simulation to drive RPM and shift gears when needed</summary>
[CppInclude("MotorPhysicsSimComponent.h")]
public partial class UMotorPhysicsSimComponent : UAudioMotorSimComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Weight</summary>
	public float Weight;
	///<summary>EngineTorque</summary>
	public float EngineTorque;
	///<summary>BrakingHorsePower</summary>
	public float BrakingHorsePower;
	///<summary>GearRatios</summary>
	public TArray<float> GearRatios;
	///<summary>ClutchedGearRatio</summary>
	public float ClutchedGearRatio;
	///<summary>bUseInfiniteGears</summary>
	public bool bUseInfiniteGears;
	///<summary>bAlwaysDownshiftToZerothGear</summary>
	public bool bAlwaysDownshiftToZerothGear;
	///<summary>how much to scale gear ratio per gear past the max gear</summary>
	public float InfiniteGearRatio;
	///<summary>UpShiftMaxRpm</summary>
	public float UpShiftMaxRpm;
	///<summary>DownShiftStartRpm</summary>
	public float DownShiftStartRpm;
	///<summary>ClutchedForceModifier</summary>
	public float ClutchedForceModifier;
	///<summary>EngineGearRatio</summary>
	public float EngineGearRatio;
	///<summary>How much of the torque is loss due to engine friction</summary>
	public float EngineFriction;
	///<summary>Coefficient of Rolling Resistance</summary>
	public float GroundFriction;
	///<summary>WindResistancePerVelocity</summary>
	public float WindResistancePerVelocity;
	///<summary>ThrottleInterpolationTime</summary>
	public float ThrottleInterpolationTime;
	///<summary>RpmInterpSpeed</summary>
	public float RpmInterpSpeed;
	///<summary>OnGearChangedEvent</summary>
	public FOnGearChanged OnGearChangedEvent;
}
