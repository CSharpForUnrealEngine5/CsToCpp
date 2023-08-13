namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MultiUser/ConsoleVariableSyncData.h")]
public partial struct FConcertSetConsoleVariableEvent {
	public EConsoleVariableChangeType ChangeType;
	public string Variable;
	public string Value;
}
