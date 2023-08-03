#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_Switch.h")]
public partial class UK2Node_Switch : UK2Node {
	public static UClass StaticClass() {return default;}
	///<summary>If true switch has a default pin</summary>
	public bool bHasDefaultPin;
	///<summary>The function underpining the switch, if required</summary>
	public string FunctionName;
	///<summary>The class that the function is from.</summary>
	public UClass FunctionClass;
}
