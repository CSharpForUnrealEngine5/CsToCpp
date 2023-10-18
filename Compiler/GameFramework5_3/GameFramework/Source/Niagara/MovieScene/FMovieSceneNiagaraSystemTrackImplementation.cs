namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieScene/MovieSceneNiagaraSystemTrackTemplate.h")]
public partial struct FMovieSceneNiagaraSystemTrackImplementation {
	public FFrameNumber SpawnSectionStartFrame;
	public FFrameNumber SpawnSectionEndFrame;
	public ENiagaraSystemSpawnSectionStartBehavior SpawnSectionStartBehavior;
	public ENiagaraSystemSpawnSectionEvaluateBehavior SpawnSectionEvaluateBehavior;
	public ENiagaraSystemSpawnSectionEndBehavior SpawnSectionEndBehavior;
	public ENiagaraAgeUpdateMode AgeUpdateMode;
	public bool bAllowScalability;
}
