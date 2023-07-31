#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Layered blend (per bone); has dynamic number of blendposes that can blend per different bone sets</summary>
[CppInclude("AnimNodes/AnimNode_LayeredBoneBlend.h")]
public partial struct FAnimNode_LayeredBoneBlend {
	public FPoseLink BasePose;
	public TArray<FPoseLink> BlendPoses;
	public ELayeredBoneBlendMode BlendMode;
	public TArray<UBlendProfile> BlendMasks;
	public TArray<FInputBlendPose> LayerSetup;
	public TArray<float> BlendWeights;
	public bool bMeshSpaceRotationBlend;
	public bool bMeshSpaceScaleBlend;
	public ECurveBlendOption CurveBlendOption;
	public bool bBlendRootMotionBasedOnRootBone;
	public int LODThreshold;
	public TArray<FPerBoneBlendWeight> PerBoneBlendWeights;
	public FGuid SkeletonGuid;
	public FGuid VirtualBoneGuid;
}
