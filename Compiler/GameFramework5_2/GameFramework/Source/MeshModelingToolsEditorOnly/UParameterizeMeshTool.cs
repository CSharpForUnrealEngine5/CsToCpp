#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UParameterizeMeshTool automatically decomposes the input mesh into charts, solves for UVs,</summary>
[CppInclude("ParameterizeMeshTool.h")]
public partial class UParameterizeMeshTool : USingleSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>UVChannelProperties</summary>
	public UMeshUVChannelProperties UVChannelProperties;
	///<summary>Settings</summary>
	public UParameterizeMeshToolProperties Settings;
	///<summary>UVAtlasProperties</summary>
	public UParameterizeMeshToolUVAtlasProperties UVAtlasProperties;
	///<summary>XAtlasProperties</summary>
	public UParameterizeMeshToolXAtlasProperties XAtlasProperties;
	///<summary>PatchBuilderProperties</summary>
	public UParameterizeMeshToolPatchBuilderProperties PatchBuilderProperties;
	///<summary>PolygroupLayerProperties</summary>
	public UPolygroupLayersProperties PolygroupLayerProperties;
	///<summary>MaterialSettings</summary>
	public UExistingMeshMaterialProperties MaterialSettings;
	///<summary>bCreateUVLayoutViewOnSetup</summary>
	public bool bCreateUVLayoutViewOnSetup;
	///<summary>UVLayoutView</summary>
	public UUVLayoutPreview UVLayoutView;
	///<summary>Preview</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
	///<summary>Factory</summary>
	public UParameterizeMeshOperatorFactory Factory;
}
