namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie scene section that control skeletal animation</summary>
[CppInclude("Sections/MovieSceneSkeletalAnimationSection.h")]
public partial class UMovieSceneSkeletalAnimationSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Params</summary>
	public FMovieSceneSkeletalAnimationParams Params;
	///<summary>AnimSequence_DEPRECATED</summary>
	public UAnimSequence AnimSequence_DEPRECATED;
	///<summary>Animation_DEPRECATED</summary>
	public UAnimSequenceBase Animation_DEPRECATED;
	///<summary>StartOffset_DEPRECATED</summary>
	public float StartOffset_DEPRECATED;
	///<summary>EndOffset_DEPRECATED</summary>
	public float EndOffset_DEPRECATED;
	///<summary>PlayRate_DEPRECATED</summary>
	public float PlayRate_DEPRECATED;
	///<summary>bReverse_DEPRECATED</summary>
	public bool bReverse_DEPRECATED;
	///<summary>SlotName_DEPRECATED</summary>
	public string SlotName_DEPRECATED;
	///<summary>Location offset applied before the matched offset</summary>
	public FVector StartLocationOffset;
	///<summary>Location offset applied after the matched offset</summary>
	public FRotator StartRotationOffset;
	///<summary>bMatchWithPrevious</summary>
	public bool bMatchWithPrevious;
	///<summary>MatchedBoneName</summary>
	public string MatchedBoneName;
	///<summary>Location offset determined by matching</summary>
	public FVector MatchedLocationOffset;
	///<summary>Rotation offset determined by matching</summary>
	public FRotator MatchedRotationOffset;
	///<summary>bMatchTranslation</summary>
	public bool bMatchTranslation;
	///<summary>bMatchIncludeZHeight</summary>
	public bool bMatchIncludeZHeight;
	///<summary>bMatchRotationYaw</summary>
	public bool bMatchRotationYaw;
	///<summary>bMatchRotationPitch</summary>
	public bool bMatchRotationPitch;
	///<summary>bMatchRotationRoll</summary>
	public bool bMatchRotationRoll;
	///<summary>Whether to show the underlying skeleton for this section.</summary>
	public bool bShowSkeleton;
}
