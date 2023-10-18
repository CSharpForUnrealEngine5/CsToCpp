namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of an array of direction vectors.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UDirectionArrayObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new direction array observation to the given agent interactor. Call during ULearningAgentsInteractor::SetupObservations event.</summary>
	public static UDirectionArrayObservation AddDirectionArrayObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,int DirectionNum/*=1*/,float Scale/*=1.0f*/) { return default; }
	///<summary>Sets the data for this observation. The relative rotation can be used to make this observation relative to the</summary>
	public void SetDirectionArrayObservation(int AgentId,TArray<FVector> Directions,FRotator RelativeRotation/*=FRotator.ZeroRotator*/) {}
}
