namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of an array of velocities projected onto a plane.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UPlanarVelocityArrayObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new planar velocity observation to the given agent interactor. The axis parameters define the plane.</summary>
	public static UPlanarVelocityArrayObservation AddPlanarVelocityArrayObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,int VelocityNum/*=1*/,float Scale/*=200.0f*/,FVector Axis0/*=FVector.ForwardVector*/,FVector Axis1/*=FVector.RightVector*/) { return default; }
	///<summary>Sets the data for this observation. The relative rotation can be used to make this observation relative to the</summary>
	public void SetPlanarVelocityArrayObservation(int AgentId,TArray<FVector> Velocities,FRotator RelativeRotation/*=FRotator.ZeroRotator*/) {}
}
