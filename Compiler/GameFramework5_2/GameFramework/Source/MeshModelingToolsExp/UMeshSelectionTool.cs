#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSelectionTool.h")]
public partial class UMeshSelectionTool : UDynamicMeshBrushTool {
	///<summary>SelectionProps</summary>
	public UMeshSelectionToolProperties SelectionProps;
	///<summary>SelectionActions</summary>
	public UMeshSelectionEditActions SelectionActions;
	///<summary>EditActions</summary>
	public UMeshSelectionToolActionPropertySet EditActions;
	///<summary>MeshStatisticsProperties</summary>
	public UMeshStatisticsProperties MeshStatisticsProperties;
	///<summary>MeshElementsDisplay</summary>
	public UMeshElementsVisualizer MeshElementsDisplay;
	///<summary>UVChannelProperties</summary>
	public UMeshUVChannelProperties UVChannelProperties;
	///<summary>PolygroupLayerProperties</summary>
	public UPolygroupLayersProperties PolygroupLayerProperties;
	///<summary>Selection</summary>
	public UMeshSelectionSet Selection;
	///<summary>SpawnedActors</summary>
	public TArray<AActor> SpawnedActors;
}
