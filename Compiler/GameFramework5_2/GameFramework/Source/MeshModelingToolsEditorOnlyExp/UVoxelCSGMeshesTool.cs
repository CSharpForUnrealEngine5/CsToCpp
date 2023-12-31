namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VoxelCSGMeshesTool.h")]
public partial class UVoxelCSGMeshesTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>CSGProps</summary>
	public UVoxelCSGMeshesToolProperties CSGProps;
	///<summary>MeshStatisticsProperties</summary>
	public UMeshStatisticsProperties MeshStatisticsProperties;
	///<summary>HandleSourcesProperties</summary>
	public UOnAcceptHandleSourcesProperties HandleSourcesProperties;
	///<summary>Preview</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
}
