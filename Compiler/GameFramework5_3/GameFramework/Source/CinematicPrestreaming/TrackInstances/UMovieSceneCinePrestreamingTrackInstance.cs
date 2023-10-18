namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TrackInstances/MovieSceneCinePrestreamingTrackInstance.h")]
public partial class UMovieSceneCinePrestreamingTrackInstance : UMovieSceneTrackInstance {
	public static UClass StaticClass() {return default;}
	///<summary>Map of loaded asset references.</summary>
	public TMap<FMovieSceneTrackInstanceInput,UCinePrestreamingData> PrestreamingAssetMap;
}
