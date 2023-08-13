namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UInputTriggerHoldAndRelease</summary>
[CppInclude("InputTriggers.h")]
public partial class UInputTriggerHoldAndRelease : UInputTriggerTimedBase {
	public static UClass StaticClass() {return default;}
	///<summary>How long does the input have to be held to cause trigger?</summary>
	public float HoldTimeThreshold;
}
