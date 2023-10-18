namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeExecutionTypes.h")]
///<summary>Status describing current run status of a State Tree.</summary>
public enum EStateTreeRunStatus {
	Running=0,
	Failed=1,
	Succeeded=2,
	Stopped=3,
	Unset=4,
}
