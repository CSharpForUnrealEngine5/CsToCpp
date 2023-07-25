#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneEvaluationTemplateInstance.h")]
///<summary>Root evaluation template instance used to play back any sequence</summary>
public partial struct FMovieSceneRootEvaluationTemplateInstance {
// MovieSceneRootEvaluationTemplateInstance
	public TWeakObjectPtr<UMovieSceneSequence> WeakRootSequence;
	public UMovieSceneCompiledDataManager CompiledDataManager;
	public UMovieSceneEntitySystemLinker EntitySystemLinker;
	public TMap<FMovieSceneSequenceID,UObject> DirectorInstances;
}
