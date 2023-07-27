#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Prediction.h")]
public partial class UAISense_Prediction : UAISense {
// AISense_Prediction
	public TArray<FAIPredictionEvent> RegisteredEvents;
	public static void RequestControllerPredictionEvent(AAIController Requestor,AActor PredictedActor,float PredictionTime) {}
	public static void RequestPawnPredictionEvent(APawn Requestor,AActor PredictedActor,float PredictionTime) {}
}
