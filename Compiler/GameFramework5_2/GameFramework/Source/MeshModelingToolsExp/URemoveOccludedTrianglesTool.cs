#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Mesh Normal Updating Tool</summary>
[CppInclude("RemoveOccludedTrianglesTool.h")]
public partial class URemoveOccludedTrianglesTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>BasicProperties</summary>
	public URemoveOccludedTrianglesToolProperties BasicProperties;
	///<summary>PolygroupLayersProperties</summary>
	public UPolygroupLayersProperties PolygroupLayersProperties;
	///<summary>AdvancedProperties</summary>
	public URemoveOccludedTrianglesAdvancedProperties AdvancedProperties;
	///<summary>Previews</summary>
	public TArray<UMeshOpPreviewWithBackgroundCompute> Previews;
	///<summary>When multiple meshes in the selection correspond to the same asset, only one needs a PreviewWithBackgroundCompute</summary>
	public TArray<UPreviewMesh> PreviewCopies;
}
