namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A movie scene section for all live link recorded data</summary>
[CppInclude("MovieScene/MovieSceneLiveLinkSection.h")]
public partial class UMovieSceneLiveLinkSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>SubjectPreset</summary>
	public FLiveLinkSubjectPreset SubjectPreset;
	///<summary>Channels that we may not send to live link or they are sent but not priority (MattH to do).</summary>
	public TArray<bool> ChannelMask;
	///<summary>SubSections</summary>
	public TArray<UMovieSceneLiveLinkSubSection> SubSections;
	///<summary>SubjectName_DEPRECATED</summary>
	public FName SubjectName_DEPRECATED;
	///<summary>TemplateToPush_DEPRECATED</summary>
	public FLiveLinkFrameData TemplateToPush_DEPRECATED;
	///<summary>RefSkeleton_DEPRECATED</summary>
	public FLiveLinkRefSkeleton RefSkeleton_DEPRECATED;
	///<summary>CurveNames_DEPRECATED</summary>
	public TArray<FName> CurveNames_DEPRECATED;
	///<summary>PropertyFloatChannels_DEPRECATED</summary>
	public TArray<FMovieSceneFloatChannel> PropertyFloatChannels_DEPRECATED;
}
