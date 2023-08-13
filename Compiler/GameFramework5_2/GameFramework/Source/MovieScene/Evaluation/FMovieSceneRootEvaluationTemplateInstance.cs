namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Root evaluation template instance used to play back any sequence</summary>
[CppInclude("Evaluation/MovieSceneEvaluationTemplateInstance.h")]
public partial struct FMovieSceneRootEvaluationTemplateInstance {
	public TWeakObjectPtr<UMovieSceneSequence> WeakRootSequence;
	public UMovieSceneCompiledDataManager CompiledDataManager;
	public UMovieSceneEntitySystemLinker EntitySystemLinker;
	public TMap<FMovieSceneSequenceID,UObject> DirectorInstances;
}
