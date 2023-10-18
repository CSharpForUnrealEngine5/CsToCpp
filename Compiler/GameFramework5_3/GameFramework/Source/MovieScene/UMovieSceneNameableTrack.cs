namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for movie scene tracks that can be renamed by the user.</summary>
[CppInclude("MovieSceneNameableTrack.h")]
public partial class UMovieSceneNameableTrack : UMovieSceneTrack {
	public static UClass StaticClass() {return default;}
	///<summary>The track&#39;s human readable display name.</summary>
	public FText DisplayName;
	///<summary>The track display name per row.</summary>
	public TArray<FText> TrackRowDisplayNames;
}
