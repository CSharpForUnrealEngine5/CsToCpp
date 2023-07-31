#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Mesh Simplifying Tool</summary>
[CppInclude("GenerateLODMeshesTool.h")]
public partial class UGenerateLODMeshesTool : USingleSelectionMeshEditingTool {
	///<summary>SimplifyProperties</summary>
	public UGenerateLODMeshesToolProperties SimplifyProperties;
	///<summary>Previews</summary>
	public TArray<UMeshOpPreviewWithBackgroundCompute> Previews;
}
