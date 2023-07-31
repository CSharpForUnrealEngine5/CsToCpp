#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeTypes.h")]
///<summary>Transitions trigger.</summary>
public enum EStateTreeTransitionTrigger {
	None=0,
	OnStateCompleted=-1,
	OnStateSucceeded=1,
	OnStateFailed=2,
	OnTick=4,
	OnEvent=8,
	MAX=9,
}
