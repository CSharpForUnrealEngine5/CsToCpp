#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneSkeletalAnimationSection.h")]
public partial struct FMovieSceneSkeletalAnimationParams {
	public UAnimSequenceBase Animation;
	public FFrameNumber FirstLoopStartFrameOffset;
	public FFrameNumber StartFrameOffset;
	public FFrameNumber EndFrameOffset;
	public float PlayRate;
	public bool bReverse;
	public string SlotName;
	public UMirrorDataTable MirrorDataTable;
	public FMovieSceneFloatChannel Weight;
	public bool bSkipAnimNotifiers;
	public bool bForceCustomMode;
	public ESwapRootBone SwapRootBone;
	public float StartOffset_DEPRECATED;
	public float EndOffset_DEPRECATED;
}
