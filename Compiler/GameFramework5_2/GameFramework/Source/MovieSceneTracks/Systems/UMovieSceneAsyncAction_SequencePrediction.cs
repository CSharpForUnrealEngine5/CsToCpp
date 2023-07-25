#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Systems/MovieScenePredictionSystem.h")]
///<summary>Async BP action that represents a pending prediction that is dispatched on a playing sequence.</summary>
public partial class UMovieSceneAsyncAction_SequencePrediction : UBlueprintAsyncActionBase {
// MovieSceneAsyncAction_SequencePrediction
	public UObject PredictWorldTransformAtTime(UObject Player,UObject TargetComponent,float TimeInSeconds) { return default; }
	public UObject PredictWorldTransformAtFrame(UObject Player,UObject TargetComponent,FFrameTime FrameTime) { return default; }
	public UObject PredictLocalTransformAtTime(UObject Player,UObject TargetComponent,float TimeInSeconds) { return default; }
	public UObject PredictLocalTransformAtFrame(UObject Player,UObject TargetComponent,FFrameTime FrameTime) { return default; }
	public FMovieSceneActorPredictionResult Result;
	public FMovieSceneActorPredictionFailure Failure;
	public UMovieSceneSequencePlayer SequencePlayer;
	public USceneComponent SceneComponent;
}
