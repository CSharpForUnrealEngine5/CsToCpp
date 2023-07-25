#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RevLimiterMotorSimComponent.h")]
///<summary>Temporarily cuts throttle and reduces RPM when drifting or in the air</summary>
public partial class URevLimiterMotorSimComponent : UAudioMotorSimComponent {
// RevLimiterMotorSimComponent
	public float LimitTime;
	public float DecelScale;
	public float AirMaxThrottleTime;
	public float SideSpeedThreshold;
	public float LimiterMaxRpm;
	public FOnRevLimiterHit OnRevLimiterHit;
	public FOnRevLimiterStateChanged OnRevLimiterStateChanged;
}
