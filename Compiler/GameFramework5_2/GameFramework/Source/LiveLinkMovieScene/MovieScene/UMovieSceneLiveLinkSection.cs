#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieScene/MovieSceneLiveLinkSection.h")]
///<summary>A movie scene section for all live link recorded data</summary>
public partial class UMovieSceneLiveLinkSection : UMovieSceneSection {
// MovieSceneLiveLinkSection
	public FLiveLinkSubjectPreset SubjectPreset;
	public TArray<bool> ChannelMask;
	public TArray<UMovieSceneLiveLinkSubSection> SubSections;
	public string SubjectName_DEPRECATED;
	public FLiveLinkFrameData TemplateToPush_DEPRECATED;
	public FLiveLinkRefSkeleton RefSkeleton_DEPRECATED;
	public TArray<string> CurveNames_DEPRECATED;
	public TArray<FMovieSceneFloatChannel> PropertyFloatChannels_DEPRECATED;
}
