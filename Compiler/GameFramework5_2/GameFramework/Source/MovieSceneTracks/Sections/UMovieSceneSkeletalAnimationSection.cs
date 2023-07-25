#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneSkeletalAnimationSection.h")]
///<summary>Movie scene section that control skeletal animation</summary>
public partial class UMovieSceneSkeletalAnimationSection : UMovieSceneSection {
// MovieSceneSkeletalAnimationSection
	public FMovieSceneSkeletalAnimationParams Params;
	public UAnimSequence AnimSequence_DEPRECATED;
	public UAnimSequenceBase Animation_DEPRECATED;
	public float StartOffset_DEPRECATED;
	public float EndOffset_DEPRECATED;
	public float PlayRate_DEPRECATED;
	public bool bReverse_DEPRECATED;
	public string SlotName_DEPRECATED;
	public FVector StartLocationOffset;
	public FRotator StartRotationOffset;
	public bool bMatchWithPrevious;
	public string MatchedBoneName;
	public FVector MatchedLocationOffset;
	public FRotator MatchedRotationOffset;
	public bool bMatchTranslation;
	public bool bMatchIncludeZHeight;
	public bool bMatchRotationYaw;
	public bool bMatchRotationPitch;
	public bool bMatchRotationRoll;
	public bool bShowSkeleton;
}
