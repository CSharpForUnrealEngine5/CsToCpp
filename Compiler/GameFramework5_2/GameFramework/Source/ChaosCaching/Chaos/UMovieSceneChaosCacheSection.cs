namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie scene section that control ChaosCache playback</summary>
[CppInclude("Chaos/Sequencer/MovieSceneChaosCacheSection.h")]
public partial class UMovieSceneChaosCacheSection : UMovieSceneBaseCacheSection {
	public static UClass StaticClass() {return default;}
	///<summary>Params</summary>
	public FMovieSceneChaosCacheParams Params;
}
