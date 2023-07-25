#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxMeshImportData.h")]
///<summary>Import data and options used when importing any mesh from FBX</summary>
public partial class UFbxMeshImportData : UFbxAssetImportData {
// FbxMeshImportData
	public bool bTransformVertexToAbsolute;
	public bool bBakePivotInVertex;
	public bool bImportMeshLODs;
	public byte NormalImportMethod;
	public byte NormalGenerationMethod;
	public bool bComputeWeightedNormals;
	public bool bReorderMaterialToFbxOrder;
	public TArray<string> ImportMaterialOriginalNameData;
	public TArray<FImportMeshLodSectionsData> ImportMeshLodData;
}
