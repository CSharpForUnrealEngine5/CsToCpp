namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of a rotation relative to another rotation.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class URotationObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new rotation observation to the given agent interactor. Call during ULearningAgentsInteractor::SetupObservations event.</summary>
	public static URotationObservation AddRotationObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,float Scale/*=1.0f*/) { return default; }
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetRotationObservation(int AgentId,FRotator Rotation,FRotator RelativeRotation/*=FRotator.ZeroRotator*/) {}
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetRotationObservationFromQuat(int AgentId,FQuat Rotation,FQuat RelativeRotation) {}
}
