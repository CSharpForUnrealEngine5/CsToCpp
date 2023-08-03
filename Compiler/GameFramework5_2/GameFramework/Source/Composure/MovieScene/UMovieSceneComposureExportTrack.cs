#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie scene track that exports a single pass (either the element&#39;s output, or an internal transform pass) during burnouts</summary>
[CppInclude("MovieScene/MovieSceneComposureExportTrack.h")]
public partial class UMovieSceneComposureExportTrack : UMovieSceneTrack {
	public static UClass StaticClass() {return default;}
	///<summary>Configuration options for the pass to export</summary>
	public FMovieSceneComposureExportPass Pass;
	///<summary>Sections</summary>
	public TArray<UMovieSceneSection> Sections;
}
