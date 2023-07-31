#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Prediction.h")]
public partial class UAISense_Prediction : UAISense {
	///<summary>RegisteredEvents</summary>
	public TArray<FAIPredictionEvent> RegisteredEvents;
	///<summary>Asks perception system to supply Requestor with PredictedActor&#39;s predicted location in PredictionTime seconds</summary>
	public static void RequestControllerPredictionEvent(AAIController Requestor,AActor PredictedActor,float PredictionTime) {}
	///<summary>Asks perception system to supply Requestor with PredictedActor&#39;s predicted location in PredictionTime seconds</summary>
	public static void RequestPawnPredictionEvent(APawn Requestor,AActor PredictedActor,float PredictionTime) {}
}
