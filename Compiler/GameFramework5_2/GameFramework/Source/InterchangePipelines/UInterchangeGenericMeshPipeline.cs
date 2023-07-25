#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeGenericMeshPipeline.h")]
///<summary>Hide drop down will make sure the class is not showing in the class picker</summary>
public partial class UInterchangeGenericMeshPipeline : UInterchangePipelineBase {
// InterchangeGenericMeshPipeline
	public TWeakObjectPtr<UInterchangeGenericCommonMeshesProperties> CommonMeshesProperties;
	public TWeakObjectPtr<UInterchangeGenericCommonSkeletalMeshesAndAnimationsProperties> CommonSkeletalMeshesAndAnimationsProperties;
	public bool bImportStaticMeshes;
	public bool bCombineStaticMeshes;
	public bool bImportCollisionAccordingToMeshName;
	public bool bOneConvexHullPerUCX;
	public bool bBuildNanite;
	public bool bBuildReversedIndexBuffer;
	public bool bGenerateLightmapUVs;
	public bool bGenerateDistanceFieldAsIfTwoSided;
	public bool bSupportFaceRemap;
	public int MinLightmapResolution;
	public int SrcLightmapIndex;
	public int DstLightmapIndex;
	public FVector BuildScale3D;
	public float DistanceFieldResolutionScale;
	public TWeakObjectPtr<UStaticMesh> DistanceFieldReplacementMesh;
	public int MaxLumenMeshCards;
	public bool bImportSkeletalMeshes;
	public EInterchangeSkeletalMeshContentType SkeletalMeshImportContentType;
	public EInterchangeSkeletalMeshContentType LastSkeletalMeshImportContentType;
	public bool bCombineSkeletalMeshes;
	public bool bImportMorphTargets;
	public bool bUpdateSkeletonReferencePose;
	public bool bCreatePhysicsAsset;
	public TWeakObjectPtr<UPhysicsAsset> PhysicsAsset;
	public bool bUseHighPrecisionSkinWeights;
	public float ThresholdPosition;
	public float ThresholdTangentNormal;
	public float ThresholdUV;
	public float MorphThresholdPosition;
	public int BoneInfluenceLimit;
}
