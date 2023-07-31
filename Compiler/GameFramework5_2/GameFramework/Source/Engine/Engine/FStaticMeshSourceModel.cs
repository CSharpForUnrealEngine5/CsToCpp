#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Source model from which a renderable static mesh is built.</summary>
[CppInclude("Engine/StaticMeshSourceData.h")]
public partial struct FStaticMeshSourceModel {
	public UStaticMeshDescriptionBulkData StaticMeshDescriptionBulkData;
	public FMeshBuildSettings BuildSettings;
	public FMeshReductionSettings ReductionSettings;
	public uint CacheMeshDescriptionTrianglesCount;
	public uint CacheMeshDescriptionVerticesCount;
	public float LODDistance_DEPRECATED;
	public FPerPlatformFloat ScreenSize;
	public string SourceImportFilename;
	public bool bImportWithBaseMesh;
}
