namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeExecutionTypes.h")]
///<summary>Enumeration for the different update phases.</summary>
public enum EStateTreeUpdatePhase {
	Unset=0,
	StartTree=1,
	StopTree=2,
	StartGlobalTasks=3,
	StopGlobalTasks=4,
	TickStateTree=5,
	ApplyTransitions=6,
	TriggerTransitions=7,
	TickingGlobalTasks=8,
	TickingTasks=9,
	TransitionConditions=10,
	StateSelection=11,
	EnterConditions=12,
	EnterStates=13,
	ExitStates=14,
}
