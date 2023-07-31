#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Log output entry captured from Python.</summary>
[CppInclude("PythonScriptTypes.h")]
public partial struct FPythonLogOutputEntry {
	public EPythonLogOutputType Type;
	public string Output;
}
