namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UInteractiveToolManager allows users of the tools framework to create and operate Tool instances.</summary>
[CppInclude("InteractiveToolManager.h")]
public partial class UInteractiveToolManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Currently-active Left Tool, or null if no Tool is active</summary>
	public UInteractiveTool ActiveLeftTool;
	///<summary>Currently-active Right Tool, or null if no Tool is active</summary>
	public UInteractiveTool ActiveRightTool;
	///<summary>Current set of named ToolBuilders</summary>
	public TMap<string,UInteractiveToolBuilder> ToolBuilders;
}
