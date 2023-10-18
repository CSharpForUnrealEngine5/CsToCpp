namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Script-extendable component class</summary>
[CppInclude("ScriptContextComponent.h")]
public partial class UScriptContextComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Calls a script-defined function (no arguments)</summary>
	public void CallScriptFunction(string FunctionName) {}
}
