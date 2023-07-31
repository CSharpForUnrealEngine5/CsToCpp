#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Utility class for Python scripting functionality.</summary>
[CppInclude("EditorPythonScriptingLibrary.h")]
public partial class UEditorPythonScriptingLibrary : UBlueprintFunctionLibrary {
	///<summary>Sets the bKeepPythonScriptAlive flag.</summary>
	public static void SetKeepPythonScriptAlive(bool bNewKeepAlive) {}
	///<summary>Returns the value of the bKeepPythonScriptAlive flag.</summary>
	public static bool GetKeepPythonScriptAlive() { return default; }
}
