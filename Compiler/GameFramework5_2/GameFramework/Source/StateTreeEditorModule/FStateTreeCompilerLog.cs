#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Message log for StateTree compilation</summary>
[CppInclude("StateTreeCompilerLog.h")]
public partial struct FStateTreeCompilerLog {
	public TArray<UStateTreeState> StateStack;
	public TArray<FStateTreeCompilerLogMessage> Messages;
}
