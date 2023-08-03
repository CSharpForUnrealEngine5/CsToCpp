#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>URecomputeUVsTool Recomputes UVs based on existing segmentations of the mesh</summary>
[CppInclude("RecomputeUVsTool.h")]
public partial class URecomputeUVsTool : USingleSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>UVChannelProperties</summary>
	public UMeshUVChannelProperties UVChannelProperties;
	///<summary>Settings</summary>
	public URecomputeUVsToolProperties Settings;
	///<summary>PolygroupLayerProperties</summary>
	public UPolygroupLayersProperties PolygroupLayerProperties;
	///<summary>MaterialSettings</summary>
	public UExistingMeshMaterialProperties MaterialSettings;
	///<summary>bCreateUVLayoutViewOnSetup</summary>
	public bool bCreateUVLayoutViewOnSetup;
	///<summary>UVLayoutView</summary>
	public UUVLayoutPreview UVLayoutView;
	///<summary>RecomputeUVsOpFactory</summary>
	public URecomputeUVsOpFactory RecomputeUVsOpFactory;
	///<summary>Preview</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
}
