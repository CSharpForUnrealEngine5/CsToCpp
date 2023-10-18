namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of an array of velocities.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UVelocityArrayObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new velocity observation to the given agent interactor. Call during ULearningAgentsInteractor::SetupObservations event.</summary>
	public static UVelocityArrayObservation AddVelocityArrayObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,int VelocityNum/*=1*/,float Scale/*=200.0f*/) { return default; }
	///<summary>Sets the data for this observation. The relative rotation can be used to make this observation relative to the</summary>
	public void SetVelocityArrayObservation(int AgentId,TArray<FVector> Velocities,FRotator RelativeRotation/*=FRotator.ZeroRotator*/) {}
}
