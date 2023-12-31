namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles animation of GroomCache</summary>
[CppInclude("MovieSceneGroomCacheTrack.h")]
public partial class UMovieSceneGroomCacheTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>List of all animation sections</summary>
	public TArray<UMovieSceneSection> AnimationSections;
}
