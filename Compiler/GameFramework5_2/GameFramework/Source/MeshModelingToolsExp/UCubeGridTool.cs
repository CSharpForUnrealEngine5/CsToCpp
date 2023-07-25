#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CubeGridTool.h")]
///<summary>Tool that allows for blocky boolean operations on an orientable power-of-two grid.</summary>
public partial class UCubeGridTool : UInteractiveTool {
// CubeGridTool
	public UCombinedTransformGizmo GridGizmo;
	public UDragAlignmentMechanic GridGizmoAlignmentMechanic;
	public UTransformProxy GridGizmoTransformProxy;
	public UPreviewGeometry LineSets;
	public UClickDragInputBehavior ClickDragBehavior;
	public UMouseHoverBehavior HoverBehavior;
	public ULocalSingleClickInputBehavior CtrlMiddleClickBehavior;
	public ULocalClickDragInputBehavior MiddleClickDragBehavior;
	public UCubeGridToolProperties Settings;
	public UCubeGridToolActions ToolActions;
	public UCubeGridDuringActivityActions DuringActivityActions;
	public UNewMeshMaterialProperties MaterialProperties;
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	public UToolTarget Target;
	public UMeshOpPreviewWithBackgroundCompute Preview;
}
