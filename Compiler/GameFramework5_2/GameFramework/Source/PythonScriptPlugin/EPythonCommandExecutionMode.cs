#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PythonScriptTypes.h")]
///<summary>Controls the execution mode used for the Python command.</summary>
public enum EPythonCommandExecutionMode {
	ExecuteFile=0,
	ExecuteStatement=1,
	EvaluateStatement=2,
}
