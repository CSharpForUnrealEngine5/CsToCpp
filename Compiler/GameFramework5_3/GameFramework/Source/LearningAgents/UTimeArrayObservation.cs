namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of an array of times.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UTimeArrayObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new angle observation to the given agent interactor. Call during ULearningAgentsInteractor::SetupObservations event.</summary>
	public static UTimeArrayObservation AddTimeArrayObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,int TimeNum/*=1*/,float Scale/*=1.0f*/) { return default; }
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetTimeArrayObservation(int AgentId,TArray<float> Times,float RelativeTime/*=0.0f*/) {}
}
