namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of a direction vector.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UDirectionObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new direction observation to the given agent interactor. Call during ULearningAgentsInteractor::SetupObservations event.</summary>
	public static UDirectionObservation AddDirectionObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,float Scale/*=1.0f*/) { return default; }
	///<summary>Sets the data for this observation. The relative rotation can be used to make this observation relative to the</summary>
	public void SetDirectionObservation(int AgentId,FVector Direction,FRotator RelativeRotation/*=FRotator.ZeroRotator*/) {}
}
