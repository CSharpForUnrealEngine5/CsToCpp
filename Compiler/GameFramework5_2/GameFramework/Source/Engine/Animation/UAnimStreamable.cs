#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimStreamable.h")]
public partial class UAnimStreamable : UAnimSequenceBase {
	///<summary>The number of keys expected within the individual animation tracks.</summary>
	public int NumberOfKeys;
	///<summary>This defines how values between keys are calculated *</summary>
	public EAnimInterpolationType Interpolation;
	///<summary>Base pose to use when retargeting</summary>
	public string RetargetSource;
	///<summary>SamplingFrameRate</summary>
	public FFrameRate SamplingFrameRate;
	///<summary>Sequence the streamable was created from (used for reflecting changes to the source in editor)</summary>
	public UAnimSequence SourceSequence;
	///<summary>RawDataGuid</summary>
	public FGuid RawDataGuid;
	///<summary>NumFrames</summary>
	public int NumFrames;
	///<summary>Raw uncompressed keyframe data.</summary>
	public TArray<FRawAnimSequenceTrack> RawAnimationData;
	///<summary>In the future, maybe keeping RawAnimSequenceTrack + TrackMap as one would be good idea to avoid inconsistent array size</summary>
	public TArray<FTrackToSkeletonMap> TrackToSkeletonMapTable;
	///<summary>This is name of RawAnimationData tracks for editoronly - if we lose skeleton, we&#39;ll need relink them</summary>
	public TArray<string> AnimationTrackNames;
	///<summary>The bone compression settings used to compress bones in this sequence.</summary>
	public UAnimBoneCompressionSettings BoneCompressionSettings;
	///<summary>The curve compression settings used to compress curves in this sequence.</summary>
	public UAnimCurveCompressionSettings CurveCompressionSettings;
	///<summary>If this is on, it will allow extracting of root motion *</summary>
	public bool bEnableRootMotion;
	///<summary>Root Bone will be locked to that position when extracting root motion.*</summary>
	public ERootMotionRootLock RootMotionRootLock;
	///<summary>Force Root Bone Lock even if Root Motion is not enabled</summary>
	public bool bForceRootLock;
	///<summary>If this is on, it will use a normalized scale value for the root motion extracted: FVector(1.0, 1.0, 1.0) *</summary>
	public bool bUseNormalizedRootMotionScale;
}
