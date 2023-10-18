namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple array of floats observation. Used as a catch-all for situations where a more type-specific observation does not exist yet.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UFloatArrayObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new float array observation to the given agent interactor. Call during ULearningAgentsInteractor::SetupObservations event.</summary>
	public static UFloatArrayObservation AddFloatArrayObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,int Num/*=1*/,float Scale/*=1.0f*/) { return default; }
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetFloatArrayObservation(int AgentId,TArray<float> Observation) {}
}
