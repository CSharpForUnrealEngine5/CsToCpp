namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mesh Inspector Tool for visualizing mesh information</summary>
[CppInclude("Physics/SetCollisionGeometryTool.h")]
public partial class USetCollisionGeometryTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public USetCollisionGeometryToolProperties Settings;
	///<summary>PolygroupLayerProperties</summary>
	public UPolygroupLayersProperties PolygroupLayerProperties;
	///<summary>VizSettings</summary>
	public UCollisionGeometryVisualizationProperties VizSettings;
	///<summary>CollisionProps</summary>
	public UPhysicsObjectToolPropertySet CollisionProps;
	///<summary>LineMaterial</summary>
	public UMaterialInterface LineMaterial;
	///<summary>PreviewGeom</summary>
	public UPreviewGeometry PreviewGeom;
}
