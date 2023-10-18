namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of an array of positions along a single axis.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UScalarPositionArrayObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new scalar position array observation to the given agent interactor. Call during</summary>
	public static UScalarPositionArrayObservation AddScalarPositionArrayObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,int PositionNum/*=1*/,float Scale/*=100.0f*/) { return default; }
	///<summary>Sets the data for this observation. The relative position can be used to make this observation</summary>
	public void SetScalarPositionArrayObservation(int AgentId,TArray<float> Positions,float RelativePosition/*=0.0f*/) {}
	///<summary>Sets the data for this observation. The relative position can be used to make this observation</summary>
	public void SetScalarPositionArrayObservationWithAxis(int AgentId,TArray<FVector> Positions,FVector RelativePosition/*=FVector.ZeroVector*/,FVector Axis/*=FVector.UpVector*/) {}
}
