#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeGenericAssetsPipelineSharedSettings.h")]
public partial class UInterchangeGenericCommonMeshesProperties : UInterchangePipelineBase {
// InterchangeGenericCommonMeshesProperties
	public EInterchangeForceMeshType ForceAllMeshAsType;
	public bool bImportLods;
	public bool bBakeMeshes;
	public EInterchangeVertexColorImportOption VertexColorImportOption;
	public FColor VertexOverrideColor;
	public bool bRecomputeNormals;
	public bool bRecomputeTangents;
	public bool bUseMikkTSpace;
	public bool bComputeWeightedNormals;
	public bool bUseHighPrecisionTangentBasis;
	public bool bUseFullPrecisionUVs;
	public bool bUseBackwardsCompatibleF16TruncUVs;
	public bool bRemoveDegenerates;
}
