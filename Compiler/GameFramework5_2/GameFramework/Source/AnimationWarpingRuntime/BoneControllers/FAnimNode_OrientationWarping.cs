#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_OrientationWarping.h")]
public partial struct FAnimNode_OrientationWarping {
	public EWarpingEvaluationMode Mode;
	public float OrientationAngle;
	public float LocomotionAngle;
	public float MinRootMotionSpeedThreshold;
	public float LocomotionAngleDeltaThreshold;
	public TArray<FBoneReference> SpineBones;
	public FBoneReference IKFootRootBone;
	public TArray<FBoneReference> IKFootBones;
	public EAxis RotationAxis;
	public float DistributedBoneOrientationAlpha;
	public float RotationInterpSpeed;
	public float WarpingAlpha;
	public float OffsetAlpha;
	public float MaxOffsetAngle;
	public float DebugDrawScale;
	public bool bEnableDebugDraw;
}
