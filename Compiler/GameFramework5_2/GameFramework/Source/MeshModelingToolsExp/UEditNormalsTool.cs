#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Mesh Normal Updating Tool</summary>
[CppInclude("EditNormalsTool.h")]
public partial class UEditNormalsTool : UMultiSelectionMeshEditingTool {
	///<summary>BasicProperties</summary>
	public UEditNormalsToolProperties BasicProperties;
	///<summary>AdvancedProperties</summary>
	public UEditNormalsAdvancedProperties AdvancedProperties;
	///<summary>PolygroupLayerProperties</summary>
	public UPolygroupLayersProperties PolygroupLayerProperties;
	///<summary>Previews</summary>
	public TArray<UMeshOpPreviewWithBackgroundCompute> Previews;
}
