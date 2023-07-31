#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Import data and options used when importing any mesh from FBX</summary>
[CppInclude("Factories/FbxMeshImportData.h")]
public partial class UFbxMeshImportData : UFbxAssetImportData {
	///<summary>If this option is true the node absolute transform (transform, offset and pivot) will be apply to the mesh vertices.</summary>
	public bool bTransformVertexToAbsolute;
	///<summary>- Experimental - If this option is true the inverse node rotation pivot will be apply to the mesh vertices. The pivot from the DCC will then be the origin of the mesh. Note: &quot;TransformVertexToAbsolute&quot; must be false.</summary>
	public bool bBakePivotInVertex;
	///<summary>If enabled, creates LOD models for Unreal meshes from LODs in the import file; If not enabled, only the base mesh from the LOD group is imported</summary>
	public bool bImportMeshLODs;
	///<summary>Enabling this option will read the tangents(tangent,binormal,normal) from FBX file instead of generating them automatically.</summary>
	public EFBXNormalImportMethod NormalImportMethod;
	///<summary>Use the MikkTSpace tangent space generator for generating normals and tangents on the mesh</summary>
	public EFBXNormalGenerationMethod NormalGenerationMethod;
	///<summary>Enabling this option will use weighted normals algorithm (area and angle) when computing normals or tangents</summary>
	public bool bComputeWeightedNormals;
	///<summary>If checked, The material list will be reorder to the same order has the FBX file.</summary>
	public bool bReorderMaterialToFbxOrder;
	///<summary>Original import section/material data</summary>
	public TArray<string> ImportMaterialOriginalNameData;
	///<summary>ImportMeshLodData</summary>
	public TArray<FImportMeshLodSectionsData> ImportMeshLodData;
}
