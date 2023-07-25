#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieScene/MovieSceneComposureExportTrack.h")]
///<summary>Movie scene track that exports a single pass (either the element's output, or an internal transform pass) during burnouts</summary>
public partial class UMovieSceneComposureExportTrack : UMovieSceneTrack {
// MovieSceneComposureExportTrack
	public FMovieSceneComposureExportPass Pass;
	public TArray<UMovieSceneSection> Sections;
}
