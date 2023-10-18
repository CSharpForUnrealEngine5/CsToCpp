namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>System responsible for managing and reporting on pending UMovieSceneAsyncAction_SequencePrediction tasks</summary>
[CppInclude("Systems/MovieScenePredictionSystem.h")]
public partial class UMovieScenePredictionSystem : UMovieSceneEntitySystem {
	public static UClass StaticClass() {return default;}
	///<summary>PendingPredictions</summary>
	public TArray<UMovieSceneAsyncAction_SequencePrediction> PendingPredictions;
	///<summary>ProcessingPredictions</summary>
	public TArray<UMovieSceneAsyncAction_SequencePrediction> ProcessingPredictions;
}
