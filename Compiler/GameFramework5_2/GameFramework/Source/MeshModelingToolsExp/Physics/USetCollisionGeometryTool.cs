#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/SetCollisionGeometryTool.h")]
///<summary>Mesh Inspector Tool for visualizing mesh information</summary>
public partial class USetCollisionGeometryTool : UMultiSelectionMeshEditingTool {
// SetCollisionGeometryTool
	public USetCollisionGeometryToolProperties Settings;
	public UPolygroupLayersProperties PolygroupLayerProperties;
	public UCollisionGeometryVisualizationProperties VizSettings;
	public UPhysicsObjectToolPropertySet CollisionProps;
	public UMaterialInterface LineMaterial;
	public UPreviewGeometry PreviewGeom;
}
