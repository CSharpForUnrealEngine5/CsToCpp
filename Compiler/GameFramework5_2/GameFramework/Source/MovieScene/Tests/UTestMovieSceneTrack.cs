namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/MovieSceneTestObjects.h")]
public partial class UTestMovieSceneTrack : UMovieSceneTrack {
	public static UClass StaticClass() {return default;}
	///<summary>bHighPassFilter</summary>
	public bool bHighPassFilter;
	///<summary>SectionArray</summary>
	public TArray<UMovieSceneSection> SectionArray;
}
