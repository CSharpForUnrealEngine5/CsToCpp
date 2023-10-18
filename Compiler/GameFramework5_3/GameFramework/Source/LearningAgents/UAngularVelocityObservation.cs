namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of an angular velocity.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UAngularVelocityObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new angular velocity observation to the given agent interactor. Call during ULearningAgentsInteractor::SetupObservations event.</summary>
	public static UAngularVelocityObservation AddAngularVelocityObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,float Scale/*=180.0f*/) { return default; }
	///<summary>Sets the data for this observation. The relative rotation can be used to make this observation relative to the</summary>
	public void SetAngularVelocityObservation(int AgentId,FVector AngularVelocity,FRotator RelativeRotation/*=FRotator.ZeroRotator*/) {}
}
