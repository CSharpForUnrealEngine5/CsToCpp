#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputTriggers.h")]
///<summary>Base class for building triggers that have firing conditions governed by elapsed time.</summary>
public partial class UInputTriggerTimedBase : UInputTrigger {
// InputTriggerTimedBase
	public float HeldDuration;
	public bool bAffectedByTimeDilation;
}
