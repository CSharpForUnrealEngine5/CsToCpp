namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of an angle relative to another angle.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UAngleObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new angle observation to the given agent interactor. Call during ULearningAgentsInteractor::SetupObservations event.</summary>
	public static UAngleObservation AddAngleObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,float Scale/*=1.0f*/) { return default; }
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetAngleObservation(int AgentId,float Angle,float RelativeAngle/*=0.0f*/) {}
}
