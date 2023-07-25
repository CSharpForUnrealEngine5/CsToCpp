#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sensors/MLAdapterSensor.h")]
///<summary>Controls the frequency that a sensor should tick at.</summary>
public enum EMLAdapterTickPolicy {
	EveryTick=0,
	EveryXSeconds=1,
	EveryNTicks=2,
	Never=3,
}
