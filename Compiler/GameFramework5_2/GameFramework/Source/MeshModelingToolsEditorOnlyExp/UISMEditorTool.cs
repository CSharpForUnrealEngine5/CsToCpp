#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ISMEditorTool.h")]
public partial class UISMEditorTool : UInteractiveTool {
	public static UClass StaticClass() {return default;}
	///<summary>ClickOrDragBehavior</summary>
	public USingleClickOrDragInputBehavior ClickOrDragBehavior;
	///<summary>RectangleMarqueeMechanic</summary>
	public URectangleMarqueeMechanic RectangleMarqueeMechanic;
	///<summary>TransformProps</summary>
	public UISMEditorToolProperties TransformProps;
	///<summary>ToolActions</summary>
	public UISMEditorToolActionPropertySet ToolActions;
	///<summary>ReplaceAction</summary>
	public UISMEditorToolReplacePropertySet ReplaceAction;
	///<summary>TargetComponents</summary>
	public TArray<UInstancedStaticMeshComponent> TargetComponents;
	///<summary>ActiveGizmos</summary>
	public TArray<FISMEditorTarget> ActiveGizmos;
	///<summary>PreviewGeometry</summary>
	public UPreviewGeometry PreviewGeometry;
}
