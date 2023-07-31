#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeGenericAssetsPipelineSharedSettings.h")]
public partial class UInterchangeGenericCommonMeshesProperties : UInterchangePipelineBase {
	///<summary>Allow to convert mesh to a particular type</summary>
	public EInterchangeForceMeshType ForceAllMeshAsType;
	///<summary>If enable, meshes LODs will be imported. Note that it required the advanced bBakeMesh property to be enabled.</summary>
	public bool bImportLods;
	///<summary>If enable, meshes will be baked with the scene instance hierarchy transform.</summary>
	public bool bBakeMeshes;
	///<summary>Specify how vertex colors should be imported</summary>
	public EInterchangeVertexColorImportOption VertexColorImportOption;
	///<summary>Specify override color in the case that VertexColorImportOption is set to Override</summary>
	public FColor VertexOverrideColor;
	///<summary>If true, normals in the imported mesh are ignored and recomputed.</summary>
	public bool bRecomputeNormals;
	///<summary>If true, tangents in the imported mesh are ignored and recomputed.</summary>
	public bool bRecomputeTangents;
	///<summary>If true, recompute tangents will use mikkt space.</summary>
	public bool bUseMikkTSpace;
	///<summary>If true, we will use the surface area and the corner angle of the triangle as a ratio when computing the normals.</summary>
	public bool bComputeWeightedNormals;
	///<summary>If true, Tangents will be stored at 16 bit vs 8 bit precision.</summary>
	public bool bUseHighPrecisionTangentBasis;
	///<summary>If true, UVs will be stored at full floating point precision.</summary>
	public bool bUseFullPrecisionUVs;
	///<summary>If true, UVs will use backwards-compatible F16 conversion with truncation for legacy meshes.</summary>
	public bool bUseBackwardsCompatibleF16TruncUVs;
	///<summary>If true, degenerate triangles will be removed.</summary>
	public bool bRemoveDegenerates;
}
