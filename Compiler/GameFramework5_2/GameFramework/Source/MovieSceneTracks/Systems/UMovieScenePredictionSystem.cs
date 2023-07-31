#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>System responsible for managing and reporting on pending UMovieSceneAsyncAction_SequencePrediction tasks</summary>
[CppInclude("Systems/MovieScenePredictionSystem.h")]
public partial class UMovieScenePredictionSystem : UMovieSceneEntitySystem {
	///<summary>PendingPredictions</summary>
	public TArray<UMovieSceneAsyncAction_SequencePrediction> PendingPredictions;
	///<summary>ProcessingPredictions</summary>
	public TArray<UMovieSceneAsyncAction_SequencePrediction> ProcessingPredictions;
}
