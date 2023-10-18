namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of an array of rotations.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class URotationArrayObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new rotation observation to the given agent interactor. Call during ULearningAgentsInteractor::SetupObservations event.</summary>
	public static URotationArrayObservation AddRotationArrayObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,int RotationNum/*=1*/,float Scale/*=1.0f*/) { return default; }
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetRotationArrayObservation(int AgentId,TArray<FRotator> Rotations,FRotator RelativeRotation/*=FRotator.ZeroRotator*/) {}
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetRotationArrayObservationFromQuats(int AgentId,TArray<FQuat> Rotations,FQuat RelativeRotation) {}
}
