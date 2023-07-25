#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ISMEditorTool.h")]
public partial class UISMEditorTool : UInteractiveTool {
// ISMEditorTool
	public USingleClickOrDragInputBehavior ClickOrDragBehavior;
	public URectangleMarqueeMechanic RectangleMarqueeMechanic;
	public UISMEditorToolProperties TransformProps;
	public UISMEditorToolActionPropertySet ToolActions;
	public UISMEditorToolReplacePropertySet ReplaceAction;
	public TArray<UInstancedStaticMeshComponent> TargetComponents;
	public TArray<FISMEditorTarget> ActiveGizmos;
	public UPreviewGeometry PreviewGeometry;
}
