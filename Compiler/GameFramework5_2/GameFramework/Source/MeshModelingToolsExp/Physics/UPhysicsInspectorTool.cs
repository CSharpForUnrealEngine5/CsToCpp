#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/PhysicsInspectorTool.h")]
///<summary>Mesh Inspector Tool for visualizing mesh information</summary>
public partial class UPhysicsInspectorTool : UMultiSelectionMeshEditingTool {
// PhysicsInspectorTool
	public UCollisionGeometryVisualizationProperties VizSettings;
	public TArray<UPhysicsObjectToolPropertySet> ObjectData;
	public UMaterialInterface LineMaterial;
	public TArray<UPreviewGeometry> PreviewElements;
}
