namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/MovieSceneTestObjects.h")]
public partial class UTestMovieSceneSubTrack : UMovieSceneSubTrack {
	public static UClass StaticClass() {return default;}
	///<summary>SectionArray</summary>
	public TArray<UMovieSceneSection> SectionArray;
}
