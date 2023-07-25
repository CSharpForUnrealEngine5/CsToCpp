#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxSceneImportOptionsSkeletalMesh.h")]
public partial class UFbxSceneImportOptionsSkeletalMesh : UObject {
// FbxSceneImportOptionsSkeletalMesh
	public bool bUpdateSkeletonReferencePose;
	public bool bCreatePhysicsAsset;
	public bool bUseT0AsRefPose;
	public bool bPreserveSmoothingGroups;
	public bool bImportMeshesInBoneHierarchy;
	public bool bImportMorphTargets;
	public float ThresholdPosition;
	public float ThresholdTangentNormal;
	public float ThresholdUV;
	public float MorphThresholdPosition;
	public bool bImportAnimations;
	public byte AnimationLength;
	public FInt32Interval FrameImportRange;
	public bool bUseDefaultSampleRate;
	public int CustomSampleRate;
	public bool bSnapToClosestFrameBoundary;
	public bool bImportCustomAttribute;
	public bool bDeleteExistingCustomAttributeCurves;
	public bool bDeleteExistingNonCurveCustomAttributes;
	public bool bPreserveLocalTransform;
	public bool bDeleteExistingMorphTargetCurves;
}
