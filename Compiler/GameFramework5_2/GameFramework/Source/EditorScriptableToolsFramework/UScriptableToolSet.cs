#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UScriptableToolSet represents a set of UScriptableInteractiveTool types.</summary>
[CppInclude("ScriptableToolSet.h")]
public partial class UScriptableToolSet : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ToolBuilders</summary>
	public TArray<UBaseScriptableToolBuilder> ToolBuilders;
}
