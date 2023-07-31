#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tool that allows for blocky boolean operations on an orientable power-of-two grid.</summary>
[CppInclude("CubeGridTool.h")]
public partial class UCubeGridTool : UInteractiveTool {
	///<summary>GridGizmo</summary>
	public UCombinedTransformGizmo GridGizmo;
	///<summary>GridGizmoAlignmentMechanic</summary>
	public UDragAlignmentMechanic GridGizmoAlignmentMechanic;
	///<summary>GridGizmoTransformProxy</summary>
	public UTransformProxy GridGizmoTransformProxy;
	///<summary>LineSets</summary>
	public UPreviewGeometry LineSets;
	///<summary>ClickDragBehavior</summary>
	public UClickDragInputBehavior ClickDragBehavior;
	///<summary>HoverBehavior</summary>
	public UMouseHoverBehavior HoverBehavior;
	///<summary>CtrlMiddleClickBehavior</summary>
	public ULocalSingleClickInputBehavior CtrlMiddleClickBehavior;
	///<summary>MiddleClickDragBehavior</summary>
	public ULocalClickDragInputBehavior MiddleClickDragBehavior;
	///<summary>Properties, etc</summary>
	public UCubeGridToolProperties Settings;
	///<summary>ToolActions</summary>
	public UCubeGridToolActions ToolActions;
	///<summary>DuringActivityActions</summary>
	public UCubeGridDuringActivityActions DuringActivityActions;
	///<summary>MaterialProperties</summary>
	public UNewMeshMaterialProperties MaterialProperties;
	///<summary>OutputTypeProperties</summary>
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	///<summary>Existing asset to modify, if one was selected</summary>
	public UToolTarget Target;
	///<summary>Preview</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
}
