#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VoxelCSGMeshesTool.h")]
public partial class UVoxelCSGMeshesTool : UMultiSelectionMeshEditingTool {
	///<summary>CSGProps</summary>
	public UVoxelCSGMeshesToolProperties CSGProps;
	///<summary>MeshStatisticsProperties</summary>
	public UMeshStatisticsProperties MeshStatisticsProperties;
	///<summary>HandleSourcesProperties</summary>
	public UOnAcceptHandleSourcesProperties HandleSourcesProperties;
	///<summary>Preview</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
}
