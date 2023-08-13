namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Script-extendable component class</summary>
[CppInclude("ScriptPluginComponent.h")]
public partial class UScriptPluginComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Calls a script-defined function (no arguments)</summary>
	public virtual bool CallScriptFunction(string FunctionName) { return default; }
}
