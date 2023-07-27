#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimStreamable.h")]
public partial class UAnimStreamable : UAnimSequenceBase {
// AnimStreamable
	public int NumberOfKeys;
	public EAnimInterpolationType Interpolation;
	public string RetargetSource;
	public FFrameRate SamplingFrameRate;
	public UAnimSequence SourceSequence;
	public FGuid RawDataGuid;
	public int NumFrames;
	public TArray<FRawAnimSequenceTrack> RawAnimationData;
	public TArray<FTrackToSkeletonMap> TrackToSkeletonMapTable;
	public TArray<string> AnimationTrackNames;
	public UAnimBoneCompressionSettings BoneCompressionSettings;
	public UAnimCurveCompressionSettings CurveCompressionSettings;
	public bool bEnableRootMotion;
	public ERootMotionRootLock RootMotionRootLock;
	public bool bForceRootLock;
	public bool bUseNormalizedRootMotionScale;
}
