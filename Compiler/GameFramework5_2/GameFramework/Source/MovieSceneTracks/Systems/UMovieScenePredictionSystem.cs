#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Systems/MovieScenePredictionSystem.h")]
///<summary>System responsible for managing and reporting on pending UMovieSceneAsyncAction_SequencePrediction tasks</summary>
public partial class UMovieScenePredictionSystem : UMovieSceneEntitySystem {
// MovieScenePredictionSystem
	public TArray<UMovieSceneAsyncAction_SequencePrediction> PendingPredictions;
	public TArray<UMovieSceneAsyncAction_SequencePrediction> ProcessingPredictions;
}
