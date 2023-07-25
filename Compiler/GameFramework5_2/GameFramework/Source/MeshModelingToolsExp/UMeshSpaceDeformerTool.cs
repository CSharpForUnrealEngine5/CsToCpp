#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSpaceDeformerTool.h")]
///<summary>Applies non-linear deformations to a mesh</summary>
public partial class UMeshSpaceDeformerTool : USingleSelectionMeshEditingTool {
// MeshSpaceDeformerTool
	public UMeshSpaceDeformerToolProperties Settings;
	public UMeshSpaceDeformerToolActionPropertySet ToolActions;
	public UGizmoTransformChangeStateTarget StateTarget;
	public UDragAlignmentMechanic DragAlignmentMechanic;
	public UMeshOpPreviewWithBackgroundCompute Preview;
	public UPreviewMesh OriginalMeshPreview;
	public UIntervalGizmo IntervalGizmo;
	public UCombinedTransformGizmo TransformGizmo;
	public UTransformProxy TransformProxy;
	public UGizmoLocalFloatParameterSource UpIntervalSource;
	public UGizmoLocalFloatParameterSource DownIntervalSource;
	public UGizmoLocalFloatParameterSource ForwardIntervalSource;
}
