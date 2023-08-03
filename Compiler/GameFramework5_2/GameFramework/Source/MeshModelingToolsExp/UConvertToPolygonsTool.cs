#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConvertToPolygonsTool.h")]
public partial class UConvertToPolygonsTool : USingleSelectionMeshEditingTool {
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
}
