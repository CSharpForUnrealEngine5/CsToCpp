#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MultiUser/ConsoleVariableSyncData.h")]
public partial struct FConcertSetConsoleVariableEvent {
// ConcertSetConsoleVariableEvent
	public EConsoleVariableChangeType ChangeType;
	public string Variable;
	public string Value;
}
