#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for building triggers that have firing conditions governed by elapsed time.</summary>
[CppInclude("InputTriggers.h")]
public partial class UInputTriggerTimedBase : UInputTrigger {
	public static UClass StaticClass() {return default;}
	///<summary>How long have we been actuating this trigger?</summary>
	public float HeldDuration;
	///<summary>Should global time dilation be applied to the held duration?</summary>
	public bool bAffectedByTimeDilation;
}
