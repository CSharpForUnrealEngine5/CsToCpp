namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EntitySystem/MovieSceneEvaluationHookSystem.h")]
public partial class UMovieSceneEvaluationHookSystem : UMovieSceneEntitySystem {
	public static UClass StaticClass() {return default;}
	///<summary>PendingEventsByRootInstance</summary>
	public TMap<FMovieSceneEvaluationInstanceKey,FMovieSceneEvaluationHookEventContainer> PendingEventsByRootInstance;
}
