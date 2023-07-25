#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/DebugSkelMeshComponent.h")]
public partial class UDebugSkelMeshComponent : USkeletalMeshComponent {
// DebugSkelMeshComponent
	public ESkeletonDrawMode SkeletonDrawMode;
	public bool bDrawMesh;
	public bool bShowBoneNames;
	public bool bDrawBoneInfluences;
	public bool bDrawMorphTargetVerts;
	public bool bDrawNormals;
	public bool bDrawTangents;
	public bool bDrawBinormals;
	public bool bDrawSockets;
	public bool bDrawAttributes;
	public bool bSkeletonSocketsVisible;
	public bool bMeshSocketsVisible;
	public bool bDisplayRawAnimation;
	public bool bDisplayNonRetargetedPose;
	public bool bDisplayAdditiveBasePose;
	public bool bDisplayBakedAnimation;
	public bool bDisplaySourceAnimation;
	public bool bDisplayBound;
	public bool bDisplayVertexColors;
	public FLinearColor WireframeMeshOverlayColor;
	public bool bPreviewRootMotion_DEPRECATED;
	public EProcessRootMotionMode ProcessRootMotionMode;
	public float ConsumeRootMotionPreviousPlaybackTime;
	public bool bShowClothData;
	public float MinClothPropertyView;
	public float MaxClothPropertyView;
	public float ClothMeshOpacity;
	public bool bClothFlipNormal;
	public bool bClothCullBackface;
	public bool bRequiredBonesUpToDateDuringTick;
	public float BoneRadiusMultiplier;
	public TArray<int> BonesOfInterest;
	public TArray<UMorphTarget> MorphTargetOfInterests;
	public TArray<UMaterialInterface> SkelMaterials;
	public UAnimPreviewInstance PreviewInstance;
	public UAnimInstance SavedAnimScriptInstance;
	public bool bIsUsingInGameBounds;
	public bool bIsUsingPreSkinnedBounds;
	public bool bPerformSingleClothingTick;
	public bool bPauseClothingSimulationWithAnim;
	public bool bTrackAttachedInstanceLOD;
}
