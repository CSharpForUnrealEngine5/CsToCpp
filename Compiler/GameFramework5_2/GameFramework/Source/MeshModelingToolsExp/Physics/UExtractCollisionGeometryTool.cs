#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/ExtractCollisionGeometryTool.h")]
///<summary>Mesh Inspector Tool for visualizing mesh information</summary>
public partial class UExtractCollisionGeometryTool : USingleSelectionMeshEditingTool {
// ExtractCollisionGeometryTool
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	public UExtractCollisionToolProperties Settings;
	public UCollisionGeometryVisualizationProperties VizSettings;
	public UPhysicsObjectToolPropertySet ObjectProps;
	public UPreviewGeometry PreviewElements;
	public UPreviewMesh PreviewMesh;
}
