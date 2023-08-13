namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Applies non-linear deformations to a mesh</summary>
[CppInclude("MeshSpaceDeformerTool.h")]
public partial class UMeshSpaceDeformerTool : USingleSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public UMeshSpaceDeformerToolProperties Settings;
	///<summary>ToolActions</summary>
	public UMeshSpaceDeformerToolActionPropertySet ToolActions;
	///<summary>StateTarget</summary>
	public UGizmoTransformChangeStateTarget StateTarget;
	///<summary>DragAlignmentMechanic</summary>
	public UDragAlignmentMechanic DragAlignmentMechanic;
	///<summary>Preview</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
	///<summary>OriginalMeshPreview</summary>
	public UPreviewMesh OriginalMeshPreview;
	///<summary>IntervalGizmo</summary>
	public UIntervalGizmo IntervalGizmo;
	///<summary>TransformGizmo</summary>
	public UCombinedTransformGizmo TransformGizmo;
	///<summary>TransformProxy</summary>
	public UTransformProxy TransformProxy;
	///<summary>Interval Parameter sources that reflect UI settings.</summary>
	public UGizmoLocalFloatParameterSource UpIntervalSource;
	///<summary>DownIntervalSource</summary>
	public UGizmoLocalFloatParameterSource DownIntervalSource;
	///<summary>ForwardIntervalSource</summary>
	public UGizmoLocalFloatParameterSource ForwardIntervalSource;
}
