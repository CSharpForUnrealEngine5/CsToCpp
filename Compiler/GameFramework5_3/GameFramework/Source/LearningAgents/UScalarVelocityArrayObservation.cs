namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of an array of velocities along a single axis.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UScalarVelocityArrayObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new scalar velocity observation to the given agent interactor.</summary>
	public static UScalarVelocityArrayObservation AddScalarVelocityArrayObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,int VelocityNum/*=1*/,float Scale/*=200.0f*/) { return default; }
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetScalarVelocityArrayObservation(int AgentId,TArray<float> Velocities) {}
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetScalarVelocityArrayObservationWithAxis(int AgentId,TArray<FVector> Velocities,FVector Axis/*=FVector.UpVector*/) {}
}
