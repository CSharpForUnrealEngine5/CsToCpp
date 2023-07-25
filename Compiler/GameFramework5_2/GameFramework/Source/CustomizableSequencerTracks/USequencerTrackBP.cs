#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerTrackBP.h")]
public partial class USequencerTrackBP : UMovieSceneNameableTrack {
// SequencerTrackBP
	public bool bSupportsMultipleRows;
	public bool bSupportsBlending;
	public ECustomSequencerTrackType TrackType;
	public UClass SupportedObjectType;
	public UClass DefaultSectionType;
	public TArray<UClass> SupportedSections;
	public UClass TrackInstanceType;
	public FSlateBrush Icon;
	public TArray<UMovieSceneSection> Sections;
}
