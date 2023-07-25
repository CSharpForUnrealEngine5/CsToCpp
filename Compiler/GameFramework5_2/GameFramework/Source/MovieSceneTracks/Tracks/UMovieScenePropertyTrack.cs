#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tracks/MovieScenePropertyTrack.h")]
///<summary>Base class for tracks that animate an object property</summary>
public partial class UMovieScenePropertyTrack : UMovieSceneNameableTrack {
// MovieScenePropertyTrack
	public string UniqueTrackName;
	public string PropertyName_DEPRECATED;
	public string PropertyPath_DEPRECATED;
	public UMovieSceneSection SectionToKey;
	public FMovieScenePropertyBinding PropertyBinding;
	public TArray<UMovieSceneSection> Sections;
}
