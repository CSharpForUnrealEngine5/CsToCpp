namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MergeMeshesTool.h")]
public partial class UMergeMeshesTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>MergeProps</summary>
	public UMergeMeshesToolProperties MergeProps;
	///<summary>MeshStatisticsProperties</summary>
	public UMeshStatisticsProperties MeshStatisticsProperties;
	///<summary>HandleSourcesProperties</summary>
	public UOnAcceptHandleSourcesProperties HandleSourcesProperties;
	///<summary>Preview</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
}
