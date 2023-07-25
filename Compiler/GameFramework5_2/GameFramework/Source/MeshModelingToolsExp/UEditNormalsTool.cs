#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditNormalsTool.h")]
///<summary>Simple Mesh Normal Updating Tool</summary>
public partial class UEditNormalsTool : UMultiSelectionMeshEditingTool {
// EditNormalsTool
	public UEditNormalsToolProperties BasicProperties;
	public UEditNormalsAdvancedProperties AdvancedProperties;
	public UPolygroupLayersProperties PolygroupLayerProperties;
	public TArray<UMeshOpPreviewWithBackgroundCompute> Previews;
}
