namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of a velocity.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UVelocityObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new velocity observation to the given agent interactor. Call during ULearningAgentsInteractor::SetupObservations event.</summary>
	public static UVelocityObservation AddVelocityObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,float Scale/*=200.0f*/) { return default; }
	///<summary>Sets the data for this observation. The relative rotation can be used to make this observation relative to the</summary>
	public void SetVelocityObservation(int AgentId,FVector Velocity,FRotator RelativeRotation/*=FRotator.ZeroRotator*/) {}
}
