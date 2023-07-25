#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Polymodeling/ExtrudeMeshSelectionTool.h")]
public partial class UExtrudeMeshSelectionTool : USingleTargetWithSelectionTool {
// ExtrudeMeshSelectionTool
	public UExtrudeMeshSelectionToolProperties ExtrudeProperties;
	public UPreviewMesh SourcePreview;
	public UMeshOpPreviewWithBackgroundCompute EditCompute;
	public UCombinedTransformGizmo TransformGizmo;
	public UTransformProxy TransformProxy;
}
