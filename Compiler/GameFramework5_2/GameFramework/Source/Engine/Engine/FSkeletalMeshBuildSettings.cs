#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Settings applied when building a mesh.</summary>
public partial struct FSkeletalMeshBuildSettings {
// SkeletalMeshBuildSettings
	public bool bRecomputeNormals;
	public bool bRecomputeTangents;
	public bool bUseMikkTSpace;
	public bool bComputeWeightedNormals;
	public bool bRemoveDegenerates;
	public bool bUseHighPrecisionTangentBasis;
	public bool bUseHighPrecisionSkinWeights;
	public bool bUseFullPrecisionUVs;
	public bool bUseBackwardsCompatibleF16TruncUVs;
	public float ThresholdPosition;
	public float ThresholdTangentNormal;
	public float ThresholdUV;
	public float MorphThresholdPosition;
	public int BoneInfluenceLimit;
}
