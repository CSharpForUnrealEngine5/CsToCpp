#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeCompilerLog.h")]
///<summary>Message log for StateTree compilation</summary>
public partial struct FStateTreeCompilerLog {
// StateTreeCompilerLog
	public TArray<UStateTreeState> StateStack;
	public TArray<FStateTreeCompilerLogMessage> Messages;
}
