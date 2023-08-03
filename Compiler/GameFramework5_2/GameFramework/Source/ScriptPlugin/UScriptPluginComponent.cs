#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Script-extendable component class</summary>
[CppInclude("ScriptPluginComponent.h")]
public partial class UScriptPluginComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Calls a script-defined function (no arguments)</summary>
	public  bool CallScriptFunction(string FunctionName) { return default; }
}
