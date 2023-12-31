namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie scene section that control NiagaraCache playback</summary>
[CppInclude("Niagara/Sequencer/MovieSceneNiagaraCacheSection.h")]
public partial class UMovieSceneNiagaraCacheSection : UMovieSceneBaseCacheSection {
	public static UClass StaticClass() {return default;}
	///<summary>Params</summary>
	public FMovieSceneNiagaraCacheParams Params;
	///<summary>bCacheOutOfDate</summary>
	public bool bCacheOutOfDate;
}
