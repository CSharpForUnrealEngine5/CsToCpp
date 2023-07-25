#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Settings applied when building a mesh.</summary>
public partial struct FMeshBuildSettings {
// MeshBuildSettings
	public bool bUseMikkTSpace;
	public bool bRecomputeNormals;
	public bool bRecomputeTangents;
	public bool bComputeWeightedNormals;
	public bool bRemoveDegenerates;
	public bool bBuildReversedIndexBuffer;
	public bool bUseHighPrecisionTangentBasis;
	public bool bUseFullPrecisionUVs;
	public bool bUseBackwardsCompatibleF16TruncUVs;
	public bool bGenerateLightmapUVs;
	public bool bGenerateDistanceFieldAsIfTwoSided;
	public bool bSupportFaceRemap;
	public int MinLightmapResolution;
	public int SrcLightmapIndex;
	public int DstLightmapIndex;
	public float BuildScale_DEPRECATED;
	public FVector BuildScale3D;
	public float DistanceFieldResolutionScale;
	public float DistanceFieldBias_DEPRECATED;
	public UStaticMesh DistanceFieldReplacementMesh;
	public int MaxLumenMeshCards;
}
