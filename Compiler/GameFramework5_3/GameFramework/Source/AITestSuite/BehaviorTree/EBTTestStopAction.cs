namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/TestBTStopAction.h")]
public enum EBTTestStopAction {
	StopTree=0,
	UnInitialize=1,
	Cleanup=2,
	Restart_ForceReevaluateRootNode=3,
	Restart_Complete=4,
	StartTree=5,
}
