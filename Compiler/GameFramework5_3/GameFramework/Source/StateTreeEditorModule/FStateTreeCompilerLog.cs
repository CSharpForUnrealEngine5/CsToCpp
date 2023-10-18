namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Message log for StateTree compilation</summary>
[CppInclude("StateTreeCompilerLog.h")]
public partial struct FStateTreeCompilerLog {
	public TArray<UStateTreeState> StateStack;
	public TArray<FStateTreeCompilerLogMessage> Messages;
}
