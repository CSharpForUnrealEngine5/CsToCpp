#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InteractiveToolManager.h")]
///<summary>UInteractiveToolManager allows users of the tools framework to create and operate Tool instances.</summary>
public partial class UInteractiveToolManager : UObject {
// InteractiveToolManager
	public UInteractiveTool ActiveLeftTool;
	public UInteractiveTool ActiveRightTool;
	public TMap<string,UInteractiveToolBuilder> ToolBuilders;
}
