namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UInteractiveTool is the base class for all Tools in the InteractiveToolsFramework.</summary>
[CppInclude("InteractiveTool.h")]
public partial class UInteractiveTool : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The current set of InputBehaviors provided by this Tool</summary>
	public UInputBehaviorSet InputBehaviors;
	///<summary>The current set of Property UObjects provided by this Tool. May contain pointer to itself.</summary>
	public TArray<UObject> ToolPropertyObjects;
}
