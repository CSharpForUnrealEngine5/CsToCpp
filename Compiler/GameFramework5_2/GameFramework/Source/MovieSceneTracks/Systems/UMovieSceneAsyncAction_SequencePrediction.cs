#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Async BP action that represents a pending prediction that is dispatched on a playing sequence.</summary>
[CppInclude("Systems/MovieScenePredictionSystem.h")]
public partial class UMovieSceneAsyncAction_SequencePrediction : UBlueprintAsyncActionBase {
	///<summary>Initiate an asynchronous prediction for the specified component&#39;s world transform at a specific time in a sequence</summary>
	public static UMovieSceneAsyncAction_SequencePrediction PredictWorldTransformAtTime(UMovieSceneSequencePlayer Player,USceneComponent TargetComponent,float TimeInSeconds) { return default; }
	///<summary>Initiate an asynchronous prediction for the specified component&#39;s world transform at a specific time in a sequence</summary>
	public static UMovieSceneAsyncAction_SequencePrediction PredictWorldTransformAtFrame(UMovieSceneSequencePlayer Player,USceneComponent TargetComponent,FFrameTime FrameTime) { return default; }
	///<summary>Initiate an asynchronous prediction for the specified component&#39;s local transform at a specific time in a sequence</summary>
	public static UMovieSceneAsyncAction_SequencePrediction PredictLocalTransformAtTime(UMovieSceneSequencePlayer Player,USceneComponent TargetComponent,float TimeInSeconds) { return default; }
	///<summary>Initiate an asynchronous prediction for the specified component&#39;s local transform at a specific time in a sequence</summary>
	public static UMovieSceneAsyncAction_SequencePrediction PredictLocalTransformAtFrame(UMovieSceneSequencePlayer Player,USceneComponent TargetComponent,FFrameTime FrameTime) { return default; }
	///<summary>Called when a message is broadcast on the specified channel. Use GetPayload() to request the message payload.</summary>
	public FMovieSceneActorPredictionResult Result;
	///<summary>Called when a message is broadcast on the specified channel. Use GetPayload() to request the message payload.</summary>
	public FMovieSceneActorPredictionFailure Failure;
	///<summary>The sequence player we&#39;re interrogating</summary>
	public UMovieSceneSequencePlayer SequencePlayer;
	///<summary>The target scene component we&#39;re interrogating</summary>
	public USceneComponent SceneComponent;
}
