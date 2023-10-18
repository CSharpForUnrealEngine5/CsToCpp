namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple observation for an FVector.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UVectorObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new vector observation to the given agent interactor. Call during ULearningAgentsInteractor::SetupObservations event.</summary>
	public static UVectorObservation AddVectorObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,float Scale/*=1.0f*/) { return default; }
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetVectorObservation(int AgentId,FVector Observation) {}
}
