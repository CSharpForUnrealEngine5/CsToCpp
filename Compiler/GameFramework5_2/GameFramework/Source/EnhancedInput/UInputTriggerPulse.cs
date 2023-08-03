#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UInputTriggerPulse</summary>
[CppInclude("InputTriggers.h")]
public partial class UInputTriggerPulse : UInputTriggerTimedBase {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to trigger when the input first exceeds the actuation threshold or wait for the first interval?</summary>
	public bool bTriggerOnStart;
	///<summary>How long between each trigger fire while input is held, in seconds?</summary>
	public float Interval;
	///<summary>How many times can the trigger fire while input is held? (0 = no limit)</summary>
	public int TriggerLimit;
}
