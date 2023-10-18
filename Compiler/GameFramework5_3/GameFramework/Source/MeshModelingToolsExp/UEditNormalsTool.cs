namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Mesh Normal Updating Tool</summary>
[CppInclude("EditNormalsTool.h")]
public partial class UEditNormalsTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>BasicProperties</summary>
	public UEditNormalsToolProperties BasicProperties;
	///<summary>PolygroupLayerProperties</summary>
	public UPolygroupLayersProperties PolygroupLayerProperties;
	///<summary>Previews</summary>
	public TArray<UMeshOpPreviewWithBackgroundCompute> Previews;
	///<summary>Selection</summary>
	public UGeometrySelectionVisualizationProperties GeometrySelectionVizProperties;
	///<summary>GeometrySelectionViz</summary>
	public UPreviewGeometry GeometrySelectionViz;
}
