namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A movie scene evaluation template for post move settings live link sections.</summary>
[CppInclude("MovieScene/MovieSceneLiveLinkSectionTemplate.h")]
public partial struct FMovieSceneLiveLinkSectionTemplate {
	public FLiveLinkSubjectPreset SubjectPreset;
	public TArray<bool> ChannelMask;
	public TArray<FLiveLinkSubSectionData> SubSectionsData;
}
