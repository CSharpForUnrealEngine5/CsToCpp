#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for movie scene tracks that can be renamed by the user.</summary>
[CppInclude("MovieSceneNameableTrack.h")]
public partial class UMovieSceneNameableTrack : UMovieSceneTrack {
	///<summary>The track&#39;s human readable display name.</summary>
	public string DisplayName;
	///<summary>The track display name per row.</summary>
	public TArray<string> TrackRowDisplayNames;
}
