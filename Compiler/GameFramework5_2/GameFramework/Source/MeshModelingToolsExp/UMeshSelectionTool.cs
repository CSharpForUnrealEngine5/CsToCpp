#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSelectionTool.h")]
public partial class UMeshSelectionTool : UDynamicMeshBrushTool {
// MeshSelectionTool
	public UMeshSelectionToolProperties SelectionProps;
	public UMeshSelectionEditActions SelectionActions;
	public UMeshSelectionToolActionPropertySet EditActions;
	public UMeshStatisticsProperties MeshStatisticsProperties;
	public UMeshElementsVisualizer MeshElementsDisplay;
	public UMeshUVChannelProperties UVChannelProperties;
	public UPolygroupLayersProperties PolygroupLayerProperties;
	public UMeshSelectionSet Selection;
	public TArray<AActor> SpawnedActors;
}
