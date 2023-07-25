#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VelocitySyncMotorSimComponent.h")]
///<summary>Sets Rpm directly from speed using a curve, if under a speed threshold or if the throttle is released for a period of time</summary>
public partial class UVelocitySyncMotorSimComponent : UAudioMotorSimComponent {
// VelocitySyncMotorSimComponent
	public float NoThrottleTime;
	public float SpeedThreshold;
	public FRuntimeFloatCurve SpeedToRpmCurve;
	public float InterpSpeed;
	public float InterpTime;
	public float FirstGearThrottleThreshold;
}
