#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A package of the needed information for an asset being operated on by a</summary>
[CppInclude("ToolTargets/UVEditorToolMeshInput.h")]
public partial class UUVEditorToolMeshInput : UToolTarget {
	///<summary>Preview of the unwrapped UV layer, suitable for being manipulated by background ops.</summary>
	public UMeshOpPreviewWithBackgroundCompute UnwrapPreview;
	///<summary>3d preview of the asset with the UV layer updated, suitable for use with background ops.</summary>
	public UMeshOpPreviewWithBackgroundCompute AppliedPreview;
	///<summary>Optional: a wireframe to track the mesh in unwrap preview. If set, it gets updated whenever the</summary>
	public UMeshElementsVisualizer WireframeDisplay;
}
