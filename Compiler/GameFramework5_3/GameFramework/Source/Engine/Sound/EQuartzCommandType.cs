namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/QuartzQuantizationUtilities.h")]
///<summary>An enumeration for specifying Quartz command types</summary>
public enum EQuartzCommandType {
	PlaySound=0,
	QueueSoundToPlay=1,
	RetriggerSound=2,
	TickRateChange=3,
	TransportReset=4,
	StartOtherClock=5,
	Notify=6,
	Custom=7,
}
