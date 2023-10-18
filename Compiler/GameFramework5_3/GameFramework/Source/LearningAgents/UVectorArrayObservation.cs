namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple observation for an array of FVector.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UVectorArrayObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new vector array observation to the given agent interactor. Call during ULearningAgentsInteractor::SetupObservations event.</summary>
	public static UVectorArrayObservation AddVectorArrayObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,int Num/*=1*/,float Scale/*=1.0f*/) { return default; }
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetVectorArrayObservation(int AgentId,TArray<FVector> Observation) {}
}
