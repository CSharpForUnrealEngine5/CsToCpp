namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConvertToPolygonsTool.h")]
public partial class UConvertToPolygonsTool : USingleTargetWithSelectionTool {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public UConvertToPolygonsToolProperties Settings;
	///<summary>CopyFromLayerProperties</summary>
	public UPolygroupLayersProperties CopyFromLayerProperties;
	///<summary>OutputProperties</summary>
	public UOutputPolygroupLayerProperties OutputProperties;
	///<summary>PreviewCompute</summary>
	public UMeshOpPreviewWithBackgroundCompute PreviewCompute;
	///<summary>PreviewGeometry</summary>
	public UPreviewGeometry PreviewGeometry;
	///<summary>If a selection was provided (bUsingSelection = true), UnmodifiedAreaPreviewMesh is used to render the unmodified (non-selected) part of the input mesh,</summary>
	public UPreviewMesh UnmodifiedAreaPreviewMesh;
}
