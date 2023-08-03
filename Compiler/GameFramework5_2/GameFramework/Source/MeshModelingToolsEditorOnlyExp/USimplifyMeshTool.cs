#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Mesh Simplifying Tool</summary>
[CppInclude("SimplifyMeshTool.h")]
public partial class USimplifyMeshTool : USingleSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>SimplifyProperties</summary>
	public USimplifyMeshToolProperties SimplifyProperties;
	///<summary>MeshStatisticsProperties</summary>
	public UMeshStatisticsProperties MeshStatisticsProperties;
	///<summary>Preview</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
	///<summary>MeshElementsDisplay</summary>
	public UMeshElementsVisualizer MeshElementsDisplay;
}
