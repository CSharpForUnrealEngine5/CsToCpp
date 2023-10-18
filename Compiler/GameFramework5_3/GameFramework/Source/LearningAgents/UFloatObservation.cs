namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple float observation. Used as a catch-all for situations where a more type-specific observation does not exist yet.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UFloatObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new float observation to the given agent interactor. Call during ULearningAgentsInteractor::SetupObservations event.</summary>
	public static UFloatObservation AddFloatObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,float Scale/*=1.0f*/) { return default; }
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetFloatObservation(int AgentId,float Observation) {}
}
