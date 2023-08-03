#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PythonScriptLibrary.h")]
public partial class UPythonScriptLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Check to see whether Python support is available in the current build.</summary>
	public static bool IsPythonAvailable() { return default; }
	///<summary>Execute the given Python command.</summary>
	public static bool ExecutePythonCommand(string PythonCommand) { return default; }
	///<summary>Execute the given Python command.</summary>
	public static bool ExecutePythonCommandEx(string PythonCommand,string CommandResult,TArray<FPythonLogOutputEntry> LogOutput,EPythonCommandExecutionMode ExecutionMode/*=EPythonCommandExecutionMode.ExecuteFile*/,EPythonFileExecutionScope FileExecutionScope/*=EPythonFileExecutionScope.Private*/) { return default; }
	///<summary>Execute a Python script with argument marshaling.</summary>
	public static bool ExecutePythonScript(string PythonScript,TArray<string> PythonInputs,TArray<string> PythonOutputs) { return default; }
}
