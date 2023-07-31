#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UInputTriggerHold</summary>
[CppInclude("InputTriggers.h")]
public partial class UInputTriggerHold : UInputTriggerTimedBase {
	///<summary>How long does the input have to be held to cause trigger?</summary>
	public float HoldTimeThreshold;
	///<summary>Should this trigger fire only once, or fire every frame once the hold time threshold is met?</summary>
	public bool bIsOneShot;
}
