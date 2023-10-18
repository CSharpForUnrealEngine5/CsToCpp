namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Polymodeling/ExtrudeMeshSelectionTool.h")]
public partial class UExtrudeMeshSelectionTool : USingleTargetWithSelectionTool {
	public static UClass StaticClass() {return default;}
	///<summary>ExtrudeProperties</summary>
	public UExtrudeMeshSelectionToolProperties ExtrudeProperties;
	///<summary>SourcePreview</summary>
	public UPreviewMesh SourcePreview;
	///<summary>EditCompute</summary>
	public UMeshOpPreviewWithBackgroundCompute EditCompute;
	///<summary>TransformGizmo</summary>
	public UCombinedTransformGizmo TransformGizmo;
	///<summary>TransformProxy</summary>
	public UTransformProxy TransformProxy;
}
