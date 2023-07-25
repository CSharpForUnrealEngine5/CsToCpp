#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ParameterizeMeshTool.h")]
///<summary>UParameterizeMeshTool automatically decomposes the input mesh into charts, solves for UVs,</summary>
public partial class UParameterizeMeshTool : USingleSelectionMeshEditingTool {
// ParameterizeMeshTool
	public UMeshUVChannelProperties UVChannelProperties;
	public UParameterizeMeshToolProperties Settings;
	public UParameterizeMeshToolUVAtlasProperties UVAtlasProperties;
	public UParameterizeMeshToolXAtlasProperties XAtlasProperties;
	public UParameterizeMeshToolPatchBuilderProperties PatchBuilderProperties;
	public UPolygroupLayersProperties PolygroupLayerProperties;
	public UExistingMeshMaterialProperties MaterialSettings;
	public bool bCreateUVLayoutViewOnSetup;
	public UUVLayoutPreview UVLayoutView;
	public UMeshOpPreviewWithBackgroundCompute Preview;
	public UParameterizeMeshOperatorFactory Factory;
}
