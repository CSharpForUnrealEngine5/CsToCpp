namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of an array of scalar angular velocities.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UScalarAngularVelocityArrayObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new scalar angular velocity array observation to the given agent interactor.</summary>
	public static UScalarAngularVelocityArrayObservation AddScalarAngularVelocityArrayObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,int AngularVelocityNum/*=1*/,float Scale/*=180.0f*/) { return default; }
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetScalarAngularVelocityArrayObservation(int AgentId,TArray<float> AngularVelocities) {}
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetScalarAngularVelocityArrayObservationWithAxis(int AgentId,TArray<FVector> AngularVelocities,FVector Axis/*=FVector.UpVector*/) {}
}
