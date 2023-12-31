namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Utility class for Python scripting functionality.</summary>
[CppInclude("EditorPythonScriptingLibrary.h")]
public partial class UEditorPythonScriptingLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Sets the bKeepPythonScriptAlive flag.</summary>
	public static void SetKeepPythonScriptAlive(bool bNewKeepAlive) {}
	///<summary>Returns the value of the bKeepPythonScriptAlive flag.</summary>
	public static bool GetKeepPythonScriptAlive() { return default; }
}
