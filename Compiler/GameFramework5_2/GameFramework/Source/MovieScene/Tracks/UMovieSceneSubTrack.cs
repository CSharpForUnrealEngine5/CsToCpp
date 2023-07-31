#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A track that holds sub-sequences within a larger sequence.</summary>
[CppInclude("Tracks/MovieSceneSubTrack.h")]
public partial class UMovieSceneSubTrack : UMovieSceneNameableTrack {
	///<summary>All movie scene sections.</summary>
	public TArray<UMovieSceneSection> Sections;
}
