namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UInputTriggerTap</summary>
[CppInclude("InputTriggers.h")]
public partial class UInputTriggerTap : UInputTriggerTimedBase {
	public static UClass StaticClass() {return default;}
	///<summary>Release within this time-frame to trigger a tap</summary>
	public float TapReleaseTimeThreshold;
}
