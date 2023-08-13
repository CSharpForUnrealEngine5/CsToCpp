namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Temporarily cuts throttle and reduces RPM when drifting or in the air</summary>
[CppInclude("RevLimiterMotorSimComponent.h")]
public partial class URevLimiterMotorSimComponent : UAudioMotorSimComponent {
	public static UClass StaticClass() {return default;}
	///<summary>LimitTime</summary>
	public float LimitTime;
	///<summary>DecelScale</summary>
	public float DecelScale;
	///<summary>AirMaxThrottleTime</summary>
	public float AirMaxThrottleTime;
	///<summary>SideSpeedThreshold</summary>
	public float SideSpeedThreshold;
	///<summary>LimiterMaxRpm</summary>
	public float LimiterMaxRpm;
	///<summary>OnRevLimiterHit</summary>
	public FOnRevLimiterHit OnRevLimiterHit;
	///<summary>OnRevLimiterStateChanged</summary>
	public FOnRevLimiterStateChanged OnRevLimiterStateChanged;
}
