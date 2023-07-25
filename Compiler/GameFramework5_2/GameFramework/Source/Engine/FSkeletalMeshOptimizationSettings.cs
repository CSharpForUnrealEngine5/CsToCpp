#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SkeletalMeshReductionSettings.h")]
///<summary>FSkeletalMeshOptimizationSettings - The settings used to optimize a skeletal mesh LOD.</summary>
public partial struct FSkeletalMeshOptimizationSettings {
// SkeletalMeshOptimizationSettings
	public byte TerminationCriterion;
	public float NumOfTrianglesPercentage;
	public float NumOfVertPercentage;
	public uint MaxNumOfTriangles;
	public uint MaxNumOfVerts;
	public uint MaxNumOfTrianglesPercentage;
	public uint MaxNumOfVertsPercentage;
	public float MaxDeviationPercentage;
	public byte ReductionMethod;
	public byte SilhouetteImportance;
	public byte TextureImportance;
	public byte ShadingImportance;
	public byte SkinningImportance;
	public bool bRemapMorphTargets;
	public bool bRecalcNormals;
	public float WeldingThreshold;
	public float NormalsThreshold;
	public int MaxBonesPerVertex;
	public bool bEnforceBoneBoundaries;
	public bool bMergeCoincidentVertBones;
	public float VolumeImportance;
	public bool bLockEdges;
	public bool bLockColorBounaries;
	public int BaseLOD;
	public TArray<FBoneReference> BonesToRemove_DEPRECATED;
	public UAnimSequence BakePose_DEPRECATED;
}
