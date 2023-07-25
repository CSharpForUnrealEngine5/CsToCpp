#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Prediction.h")]
public partial class UAISense_Prediction : UAISense {
// AISense_Prediction
	public TArray<FAIPredictionEvent> RegisteredEvents;
	public void RequestControllerPredictionEvent(UObject Requestor,UObject PredictedActor,float PredictionTime) {}
	public void RequestPawnPredictionEvent(UObject Requestor,UObject PredictedActor,float PredictionTime) {}
}
