#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVLayoutTool.h")]
///<summary>The level editor version of the UV layout tool.</summary>
public partial class UUVLayoutTool : UMultiSelectionMeshEditingTool {
// UVLayoutTool
	public UMeshUVChannelProperties UVChannelProperties;
	public UUVLayoutProperties BasicProperties;
	public UExistingMeshMaterialProperties MaterialSettings;
	public TArray<UMeshOpPreviewWithBackgroundCompute> Previews;
	public TArray<UUVLayoutOperatorFactory> Factories;
	public UUVLayoutPreview UVLayoutView;
}
