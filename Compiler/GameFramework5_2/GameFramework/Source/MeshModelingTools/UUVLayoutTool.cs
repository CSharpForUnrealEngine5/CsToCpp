#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The level editor version of the UV layout tool.</summary>
[CppInclude("UVLayoutTool.h")]
public partial class UUVLayoutTool : UMultiSelectionMeshEditingTool {
	///<summary>UVChannelProperties</summary>
	public UMeshUVChannelProperties UVChannelProperties;
	///<summary>BasicProperties</summary>
	public UUVLayoutProperties BasicProperties;
	///<summary>MaterialSettings</summary>
	public UExistingMeshMaterialProperties MaterialSettings;
	///<summary>Previews</summary>
	public TArray<UMeshOpPreviewWithBackgroundCompute> Previews;
	///<summary>Factories</summary>
	public TArray<UUVLayoutOperatorFactory> Factories;
	///<summary>UVLayoutView</summary>
	public UUVLayoutPreview UVLayoutView;
}
