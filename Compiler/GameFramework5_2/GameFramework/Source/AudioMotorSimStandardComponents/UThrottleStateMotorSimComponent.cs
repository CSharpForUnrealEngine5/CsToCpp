#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Provides events for when the throttle changes state</summary>
[CppInclude("ThrottleStateMotorSimComponent.h")]
public partial class UThrottleStateMotorSimComponent : UAudioMotorSimComponent {
	public static UClass StaticClass() {return default;}
	///<summary>OnThrottleEngaged</summary>
	public FOnThrottleChanged OnThrottleEngaged;
	///<summary>OnThrottleReleased</summary>
	public FOnThrottleChanged OnThrottleReleased;
	///<summary>Fires when the throttle is released, keeping track of how long the throttle was held for</summary>
	public FOnEngineBlowoff OnEngineBlowoff;
	///<summary>BlowoffMinThrottleTime</summary>
	public float BlowoffMinThrottleTime;
}
