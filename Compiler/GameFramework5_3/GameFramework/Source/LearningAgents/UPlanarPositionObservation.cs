namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of a position projected onto a plane.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UPlanarPositionObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new planar position observation to the given agent interactor. The axis parameters define the plane. Call</summary>
	public static UPlanarPositionObservation AddPlanarPositionObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,float Scale/*=100.0f*/,FVector Axis0/*=FVector.ForwardVector*/,FVector Axis1/*=FVector.RightVector*/) { return default; }
	///<summary>Sets the data for this observation. The relative position &amp; rotation can be used to make this observation</summary>
	public void SetPlanarPositionObservation(int AgentId,FVector Position,FVector RelativePosition/*=FVector.ZeroVector*/,FRotator RelativeRotation/*=FRotator.ZeroRotator*/) {}
}
