#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneNameableTrack.h")]
///<summary>Base class for movie scene tracks that can be renamed by the user.</summary>
public partial class UMovieSceneNameableTrack : UMovieSceneTrack {
// MovieSceneNameableTrack
	public string DisplayName;
	public TArray<string> TrackRowDisplayNames;
}
