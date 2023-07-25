#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EntitySystem/MovieSceneEvaluationHookSystem.h")]
public partial class UMovieSceneEvaluationHookSystem : UMovieSceneEntitySystem {
// MovieSceneEvaluationHookSystem
	public TMap<FMovieSceneEvaluationInstanceKey,FMovieSceneEvaluationHookEventContainer> PendingEventsByRootInstance;
}
