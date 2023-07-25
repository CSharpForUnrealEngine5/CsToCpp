#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemeshMeshTool.h")]
///<summary>Simple Mesh Remeshing Tool</summary>
public partial class URemeshMeshTool : UMultiSelectionMeshEditingTool {
// RemeshMeshTool
	public URemeshMeshToolProperties BasicProperties;
	public UMeshStatisticsProperties MeshStatisticsProperties;
	public UMeshOpPreviewWithBackgroundCompute Preview;
	public UMeshElementsVisualizer MeshElementsDisplay;
}
