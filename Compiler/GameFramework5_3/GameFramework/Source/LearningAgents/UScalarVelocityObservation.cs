namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of a velocity along a single axis.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UScalarVelocityObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new scalar velocity observation to the given agent interactor.</summary>
	public static UScalarVelocityObservation AddScalarVelocityObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,float Scale/*=200.0f*/) { return default; }
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetScalarVelocityObservation(int AgentId,float Velocity) {}
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetScalarVelocityObservationWithAxis(int AgentId,FVector Velocity,FVector Axis/*=FVector.UpVector*/) {}
}
