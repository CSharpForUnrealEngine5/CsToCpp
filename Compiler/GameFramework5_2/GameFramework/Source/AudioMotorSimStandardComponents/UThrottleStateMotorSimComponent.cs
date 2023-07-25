#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ThrottleStateMotorSimComponent.h")]
///<summary>Provides events for when the throttle changes state</summary>
public partial class UThrottleStateMotorSimComponent : UAudioMotorSimComponent {
// ThrottleStateMotorSimComponent
	public FOnThrottleChanged OnThrottleEngaged;
	public FOnThrottleChanged OnThrottleReleased;
	public FOnEngineBlowoff OnEngineBlowoff;
	public float BlowoffMinThrottleTime;
}
