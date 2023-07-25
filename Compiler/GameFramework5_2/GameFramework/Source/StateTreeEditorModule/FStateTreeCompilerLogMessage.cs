#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeCompilerLog.h")]
///<summary>StateTree compiler log message</summary>
public partial struct FStateTreeCompilerLogMessage {
// StateTreeCompilerLogMessage
	public int Severity;
	public UStateTreeState State;
	public FStateTreeBindableStructDesc Item;
	public string Message;
}
