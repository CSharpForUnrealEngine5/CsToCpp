namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A track for animating FMoveSceneLiveLinkTrack properties.</summary>
[CppInclude("MovieScene/MovieSceneLiveLinkTrack.h")]
public partial class UMovieSceneLiveLinkTrack : UMovieScenePropertyTrack {
	public static UClass StaticClass() {return default;}
	///<summary>TrackRole</summary>
	public UClass TrackRole;
}
