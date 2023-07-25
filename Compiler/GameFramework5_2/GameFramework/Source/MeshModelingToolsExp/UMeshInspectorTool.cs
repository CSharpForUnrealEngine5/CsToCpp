#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshInspectorTool.h")]
///<summary>Mesh Inspector Tool for visualizing mesh information</summary>
public partial class UMeshInspectorTool : USingleSelectionMeshEditingTool {
// MeshInspectorTool
	public UMeshInspectorProperties Settings;
	public UPolygroupLayersProperties PolygroupLayerProperties;
	public UMeshInspectorMaterialProperties MaterialSettings;
	public UPreviewMesh PreviewMesh;
	public ULineSetComponent DrawnLineSet;
	public UMaterialInterface DefaultMaterial;
}
