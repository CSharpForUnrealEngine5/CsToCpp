namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationState.h")]
///<summary>Enumeration of unit test status for special dialog</summary>
public enum EAutomationState {
	NotRun=0,
	InProcess=1,
	Fail=2,
	Success=3,
	Skipped=4,
}
