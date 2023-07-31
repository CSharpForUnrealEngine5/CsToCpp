#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UInputTriggerTap</summary>
[CppInclude("InputTriggers.h")]
public partial class UInputTriggerTap : UInputTriggerTimedBase {
	///<summary>Release within this time-frame to trigger a tap</summary>
	public float TapReleaseTimeThreshold;
}
