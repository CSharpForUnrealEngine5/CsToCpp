#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RecomputeUVsTool.h")]
///<summary>URecomputeUVsTool Recomputes UVs based on existing segmentations of the mesh</summary>
public partial class URecomputeUVsTool : USingleSelectionMeshEditingTool {
// RecomputeUVsTool
	public UMeshUVChannelProperties UVChannelProperties;
	public URecomputeUVsToolProperties Settings;
	public UPolygroupLayersProperties PolygroupLayerProperties;
	public UExistingMeshMaterialProperties MaterialSettings;
	public bool bCreateUVLayoutViewOnSetup;
	public UUVLayoutPreview UVLayoutView;
	public URecomputeUVsOpFactory RecomputeUVsOpFactory;
	public UMeshOpPreviewWithBackgroundCompute Preview;
}
