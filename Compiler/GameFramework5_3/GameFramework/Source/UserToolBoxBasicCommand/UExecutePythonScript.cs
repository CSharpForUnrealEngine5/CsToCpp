namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExecutePythonScript.h")]
public partial class UExecutePythonScript : UUTBBaseCommand {
	public static UClass StaticClass() {return default;}
	///<summary>ScriptPath</summary>
	public FFilePath ScriptPath;
	///<summary>Args</summary>
	public string Args;
}
