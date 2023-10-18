namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Mesh Simplifying Tool</summary>
[CppInclude("GenerateLODMeshesTool.h")]
public partial class UGenerateLODMeshesTool : USingleSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>SimplifyProperties</summary>
	public UGenerateLODMeshesToolProperties SimplifyProperties;
	///<summary>Previews</summary>
	public TArray<UMeshOpPreviewWithBackgroundCompute> Previews;
}
