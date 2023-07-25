#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SimplifyMeshTool.h")]
///<summary>Simple Mesh Simplifying Tool</summary>
public partial class USimplifyMeshTool : USingleSelectionMeshEditingTool {
// SimplifyMeshTool
	public USimplifyMeshToolProperties SimplifyProperties;
	public UMeshStatisticsProperties MeshStatisticsProperties;
	public UMeshOpPreviewWithBackgroundCompute Preview;
	public UMeshElementsVisualizer MeshElementsDisplay;
}
