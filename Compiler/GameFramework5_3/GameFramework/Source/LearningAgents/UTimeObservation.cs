namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of a time relative to another time.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UTimeObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new time observation to the given agent interactor. Call during ULearningAgentsInteractor::SetupObservations event.</summary>
	public static UTimeObservation AddTimeObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,float Scale/*=1.0f*/) { return default; }
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetTimeObservation(int AgentId,float Time,float RelativeTime/*=0.0f*/) {}
}
