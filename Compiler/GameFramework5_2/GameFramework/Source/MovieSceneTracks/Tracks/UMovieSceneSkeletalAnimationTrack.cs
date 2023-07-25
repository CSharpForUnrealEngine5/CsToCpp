#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tracks/MovieSceneSkeletalAnimationTrack.h")]
///<summary>Handles animation of skeletal mesh actors</summary>
public partial class UMovieSceneSkeletalAnimationTrack : UMovieSceneNameableTrack {
// MovieSceneSkeletalAnimationTrack
	public TArray<UMovieSceneSection> AnimationSections;
	public bool bUseLegacySectionIndexBlend;
	public FMovieSceneSkeletalAnimRootMotionTrackParams RootMotionParams;
	public bool bBlendFirstChildOfRoot;
	public bool bShowRootMotionTrail;
}
