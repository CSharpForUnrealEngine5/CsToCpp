namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of an array of angular velocities.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UAngularVelocityArrayObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new angular velocity array observation to the given agent interactor. Call during ULearningAgentsInteractor::SetupObservations event.</summary>
	public static UAngularVelocityArrayObservation AddAngularVelocityArrayObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,int AngularVelocityNum/*=1*/,float Scale/*=180.0f*/) { return default; }
	///<summary>Sets the data for this observation. The relative rotation can be used to make this observation relative to the</summary>
	public void SetAngularVelocityArrayObservation(int AgentId,TArray<FVector> AngularVelocities,FRotator RelativeRotation/*=FRotator.ZeroRotator*/) {}
}
