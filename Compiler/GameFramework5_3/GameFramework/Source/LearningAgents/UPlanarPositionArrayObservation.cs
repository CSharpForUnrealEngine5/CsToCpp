namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of an array of positions projected onto a plane.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UPlanarPositionArrayObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new planar position array observation to the given agent interactor. The axis parameters define the plane.</summary>
	public static UPlanarPositionArrayObservation AddPlanarPositionArrayObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,int PositionNum/*=1*/,float Scale/*=100.0f*/,FVector Axis0/*=FVector.ForwardVector*/,FVector Axis1/*=FVector.RightVector*/) { return default; }
	///<summary>Sets the data for this observation. The relative position &amp; rotation can be used to make this observation</summary>
	public void SetPlanarPositionArrayObservation(int AgentId,TArray<FVector> Positions,FVector RelativePosition/*=FVector.ZeroVector*/,FRotator RelativeRotation/*=FRotator.ZeroRotator*/) {}
}
