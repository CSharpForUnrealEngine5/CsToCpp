#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PythonScriptLibrary.h")]
public partial class UPythonScriptLibrary : UBlueprintFunctionLibrary {
// PythonScriptLibrary
	public bool IsPythonAvailable() { return default; }
	public bool ExecutePythonCommand(string PythonCommand) { return default; }
	public bool ExecutePythonCommandEx(string PythonCommand,string CommandResult,TArray<FPythonLogOutputEntry> LogOutput,EPythonCommandExecutionMode ExecutionMode/*=EPythonCommandExecutionMode.ExecuteFile*/,EPythonFileExecutionScope FileExecutionScope/*=EPythonFileExecutionScope.Private*/) { return default; }
	public bool ExecutePythonScript(string PythonScript,TArray<string> PythonInputs,TArray<string> PythonOutputs) { return default; }
}
