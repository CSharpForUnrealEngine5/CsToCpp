namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Debugger/StateTreeTraceTypes.h")]
public enum EStateTreeTraceEventType {
	Unset=0,
	OnEntering=1,
	OnEntered=2,
	OnExiting=3,
	OnExited=4,
	Push=5,
	Pop=6,
	OnStateSelected=7,
	OnStateCompleted=8,
	OnTicking=9,
	OnTaskCompleted=10,
	OnTicked=11,
	Passed=12,
	Failed=13,
	OnEvaluating=14,
	OnTransition=15,
	OnTreeStarted=16,
	OnTreeStopped=17,
}
