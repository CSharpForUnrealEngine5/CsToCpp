namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mesh Inspector Tool for visualizing mesh information</summary>
[CppInclude("Physics/PhysicsInspectorTool.h")]
public partial class UPhysicsInspectorTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>VizSettings</summary>
	public UCollisionGeometryVisualizationProperties VizSettings;
	///<summary>ObjectData</summary>
	public TArray<UPhysicsObjectToolPropertySet> ObjectData;
	///<summary>LineMaterial</summary>
	public UMaterialInterface LineMaterial;
	///<summary>PreviewElements</summary>
	public TArray<UPreviewGeometry> PreviewElements;
}
