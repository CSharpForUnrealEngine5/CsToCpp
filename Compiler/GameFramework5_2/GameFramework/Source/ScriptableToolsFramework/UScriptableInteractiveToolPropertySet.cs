namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UScriptableInteractiveToolPropertySet is a Blueprintable extension of UInteractiveToolPropertySet.</summary>
[CppInclude("ScriptableInteractiveTool.h")]
public partial class UScriptableInteractiveToolPropertySet : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Access the Tool that owns this PropertySet</summary>
	public UScriptableInteractiveTool GetOwningTool(EToolsFrameworkOutcomePins Outcome) { return default; }
}
