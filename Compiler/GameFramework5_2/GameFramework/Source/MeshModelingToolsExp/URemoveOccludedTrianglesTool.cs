#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoveOccludedTrianglesTool.h")]
///<summary>Simple Mesh Normal Updating Tool</summary>
public partial class URemoveOccludedTrianglesTool : UMultiSelectionMeshEditingTool {
// RemoveOccludedTrianglesTool
	public URemoveOccludedTrianglesToolProperties BasicProperties;
	public UPolygroupLayersProperties PolygroupLayersProperties;
	public URemoveOccludedTrianglesAdvancedProperties AdvancedProperties;
	public TArray<UMeshOpPreviewWithBackgroundCompute> Previews;
	public TArray<UPreviewMesh> PreviewCopies;
}
