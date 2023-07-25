#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieScene/MovieSceneNiagaraSystemSpawnSection.h")]
public partial class UMovieSceneNiagaraSystemSpawnSection : UMovieSceneSection {
// MovieSceneNiagaraSystemSpawnSection
	public ENiagaraSystemSpawnSectionStartBehavior SectionStartBehavior;
	public ENiagaraSystemSpawnSectionEvaluateBehavior SectionEvaluateBehavior;
	public ENiagaraSystemSpawnSectionEndBehavior SectionEndBehavior;
	public ENiagaraAgeUpdateMode AgeUpdateMode;
	public bool bAllowScalability;
}
