#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConvertToPolygonsTool.h")]
public partial class UConvertToPolygonsTool : USingleSelectionMeshEditingTool {
// ConvertToPolygonsTool
	public UConvertToPolygonsToolProperties Settings;
	public UPolygroupLayersProperties CopyFromLayerProperties;
	public UOutputPolygroupLayerProperties OutputProperties;
	public UMeshOpPreviewWithBackgroundCompute PreviewCompute;
	public UPreviewGeometry PreviewGeometry;
}
