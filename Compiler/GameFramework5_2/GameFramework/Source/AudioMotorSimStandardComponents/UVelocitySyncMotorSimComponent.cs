#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sets Rpm directly from speed using a curve, if under a speed threshold or if the throttle is released for a period of time</summary>
[CppInclude("VelocitySyncMotorSimComponent.h")]
public partial class UVelocitySyncMotorSimComponent : UAudioMotorSimComponent {
	///<summary>NoThrottleTime</summary>
	public float NoThrottleTime;
	///<summary>Speed below which gears will be ignored, and RPM will sync directly to velocity</summary>
	public float SpeedThreshold;
	///<summary>SpeedToRpmCurve</summary>
	public FRuntimeFloatCurve SpeedToRpmCurve;
	///<summary>InterpSpeed</summary>
	public float InterpSpeed;
	///<summary>InterpTime</summary>
	public float InterpTime;
	///<summary>FirstGearThrottleThreshold</summary>
	public float FirstGearThrottleThreshold;
}
