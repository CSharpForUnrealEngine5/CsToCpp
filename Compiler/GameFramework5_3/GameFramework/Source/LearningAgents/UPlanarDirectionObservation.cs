namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of a direction vector projected onto a plane.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UPlanarDirectionObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new planar direction observation to the given agent interactor. The axis parameters define the plane. Call</summary>
	public static UPlanarDirectionObservation AddPlanarDirectionObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,float Scale/*=1.0f*/,FVector Axis0/*=FVector.ForwardVector*/,FVector Axis1/*=FVector.RightVector*/) { return default; }
	///<summary>Sets the data for this observation. The relative rotation can be used to make this observation relative to the</summary>
	public void SetPlanarDirectionObservation(int AgentId,FVector Direction,FRotator RelativeRotation/*=FRotator.ZeroRotator*/) {}
}
