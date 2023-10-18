namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of a scalar angular velocity.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UScalarAngularVelocityObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new scalar angular velocity observation to the given agent interactor.</summary>
	public static UScalarAngularVelocityObservation AddScalarAngularVelocityObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,float Scale/*=180.0f*/) { return default; }
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetScalarAngularVelocityObservation(int AgentId,float AngularVelocity) {}
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetScalarAngularVelocityObservationWithAxis(int AgentId,FVector AngularVelocity,FVector Axis/*=FVector.UpVector*/) {}
}
