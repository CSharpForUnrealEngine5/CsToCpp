namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of a position vector.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UPositionObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new position observation to the given agent interactor. Call during ULearningAgentsInteractor::SetupObservations event.</summary>
	public static UPositionObservation AddPositionObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,float Scale/*=100.0f*/) { return default; }
	///<summary>Sets the data for this observation. The relative position &amp; rotation can be used to make this observation</summary>
	public void SetPositionObservation(int AgentId,FVector Position,FVector RelativePosition/*=FVector.ZeroVector*/,FRotator RelativeRotation/*=FRotator.ZeroRotator*/) {}
}
