#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mesh Inspector Tool for visualizing mesh information</summary>
[CppInclude("Physics/ExtractCollisionGeometryTool.h")]
public partial class UExtractCollisionGeometryTool : USingleSelectionMeshEditingTool {
	///<summary>Property set for type of output object (StaticMesh, Volume, etc)</summary>
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	///<summary>Settings</summary>
	public UExtractCollisionToolProperties Settings;
	///<summary>VizSettings</summary>
	public UCollisionGeometryVisualizationProperties VizSettings;
	///<summary>ObjectProps</summary>
	public UPhysicsObjectToolPropertySet ObjectProps;
	///<summary>PreviewElements</summary>
	public UPreviewGeometry PreviewElements;
	///<summary>PreviewMesh</summary>
	public UPreviewMesh PreviewMesh;
}
