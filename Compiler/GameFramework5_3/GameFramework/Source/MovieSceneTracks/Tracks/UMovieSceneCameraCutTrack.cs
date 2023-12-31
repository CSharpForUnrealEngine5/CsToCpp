namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles manipulation of CameraCut properties in a movie scene.</summary>
[CppInclude("Tracks/MovieSceneCameraCutTrack.h")]
public partial class UMovieSceneCameraCutTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>bCanBlend</summary>
	public bool bCanBlend;
	///<summary>All movie scene sections.</summary>
	public TArray<UMovieSceneSection> Sections;
}
