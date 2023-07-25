#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InteractiveTool.h")]
///<summary>UInteractiveTool is the base class for all Tools in the InteractiveToolsFramework.</summary>
public partial class UInteractiveTool : UObject {
// InteractiveTool
	public UInputBehaviorSet InputBehaviors;
	public TArray<UObject> ToolPropertyObjects;
}
