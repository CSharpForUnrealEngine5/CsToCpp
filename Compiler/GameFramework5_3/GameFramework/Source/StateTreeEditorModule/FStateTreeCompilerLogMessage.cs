namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>StateTree compiler log message</summary>
[CppInclude("StateTreeCompilerLog.h")]
public partial struct FStateTreeCompilerLogMessage {
	public int Severity;
	public UStateTreeState State;
	public FStateTreeBindableStructDesc Item;
	public string Message;
}
