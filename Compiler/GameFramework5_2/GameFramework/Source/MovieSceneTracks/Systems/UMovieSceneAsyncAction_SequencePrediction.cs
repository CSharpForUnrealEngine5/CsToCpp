#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Systems/MovieScenePredictionSystem.h")]
///<summary>Async BP action that represents a pending prediction that is dispatched on a playing sequence.</summary>
public partial class UMovieSceneAsyncAction_SequencePrediction : UBlueprintAsyncActionBase {
// MovieSceneAsyncAction_SequencePrediction
	public static UMovieSceneAsyncAction_SequencePrediction PredictWorldTransformAtTime(UMovieSceneSequencePlayer Player,USceneComponent TargetComponent,float TimeInSeconds) { return default; }
	public static UMovieSceneAsyncAction_SequencePrediction PredictWorldTransformAtFrame(UMovieSceneSequencePlayer Player,USceneComponent TargetComponent,FFrameTime FrameTime) { return default; }
	public static UMovieSceneAsyncAction_SequencePrediction PredictLocalTransformAtTime(UMovieSceneSequencePlayer Player,USceneComponent TargetComponent,float TimeInSeconds) { return default; }
	public static UMovieSceneAsyncAction_SequencePrediction PredictLocalTransformAtFrame(UMovieSceneSequencePlayer Player,USceneComponent TargetComponent,FFrameTime FrameTime) { return default; }
	public FMovieSceneActorPredictionResult Result;
	public FMovieSceneActorPredictionFailure Failure;
	public UMovieSceneSequencePlayer SequencePlayer;
	public USceneComponent SceneComponent;
}
