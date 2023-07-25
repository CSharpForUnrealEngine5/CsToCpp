#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WeldMeshEdgesTool.h")]
///<summary>Mesh Weld Edges Tool</summary>
public partial class UWeldMeshEdgesTool : USingleSelectionMeshEditingTool {
// WeldMeshEdgesTool
	public UWeldMeshEdgesToolProperties Settings;
	public UMeshOpPreviewWithBackgroundCompute PreviewCompute;
	public UMeshElementsVisualizer MeshElementsDisplay;
	public UWeldMeshEdgesOperatorFactory OperatorFactory;
}
