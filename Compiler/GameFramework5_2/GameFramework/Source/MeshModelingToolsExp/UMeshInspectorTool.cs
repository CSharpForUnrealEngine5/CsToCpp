#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mesh Inspector Tool for visualizing mesh information</summary>
[CppInclude("MeshInspectorTool.h")]
public partial class UMeshInspectorTool : USingleSelectionMeshEditingTool {
	///<summary>Settings</summary>
	public UMeshInspectorProperties Settings;
	///<summary>PolygroupLayerProperties</summary>
	public UPolygroupLayersProperties PolygroupLayerProperties;
	///<summary>MaterialSettings</summary>
	public UMeshInspectorMaterialProperties MaterialSettings;
	///<summary>PreviewMesh</summary>
	public UPreviewMesh PreviewMesh;
	///<summary>DrawnLineSet</summary>
	public ULineSetComponent DrawnLineSet;
	///<summary>DefaultMaterial</summary>
	public UMaterialInterface DefaultMaterial;
}
