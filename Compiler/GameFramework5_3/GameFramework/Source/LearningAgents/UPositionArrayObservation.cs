namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of an array of positions.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UPositionArrayObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new position array observation to the given agent interactor. Call during ULearningAgentsInteractor::SetupObservations event.</summary>
	public static UPositionArrayObservation AddPositionArrayObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,int PositionNum/*=1*/,float Scale/*=100.0f*/) { return default; }
	///<summary>Sets the data for this observation. The relative position &amp; rotation can be used to make this observation</summary>
	public void SetPositionArrayObservation(int AgentId,TArray<FVector> Positions,FVector RelativePosition/*=FVector.ZeroVector*/,FRotator RelativeRotation/*=FRotator.ZeroRotator*/) {}
}
