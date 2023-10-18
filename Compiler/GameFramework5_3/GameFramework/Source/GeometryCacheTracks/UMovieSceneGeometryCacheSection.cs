namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie scene section that control geometry cache playback</summary>
[CppInclude("MovieSceneGeometryCacheSection.h")]
public partial class UMovieSceneGeometryCacheSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Params</summary>
	public FMovieSceneGeometryCacheParams Params;
}
