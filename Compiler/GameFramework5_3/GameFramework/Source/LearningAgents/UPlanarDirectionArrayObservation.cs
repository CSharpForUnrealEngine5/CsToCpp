namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of an array of direction vectors projected onto a plane.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UPlanarDirectionArrayObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new planar direction observation to the given agent interactor. The axis parameters define the plane. Call</summary>
	public static UPlanarDirectionArrayObservation AddPlanarDirectionArrayObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,int DirectionNum/*=1*/,float Scale/*=1.0f*/,FVector Axis0/*=FVector.ForwardVector*/,FVector Axis1/*=FVector.RightVector*/) { return default; }
	///<summary>Sets the data for this observation. The relative rotation can be used to make this observation relative to the</summary>
	public void SetPlanarDirectionArrayObservation(int AgentId,TArray<FVector> Directions,FRotator RelativeRotation/*=FRotator.ZeroRotator*/) {}
}
