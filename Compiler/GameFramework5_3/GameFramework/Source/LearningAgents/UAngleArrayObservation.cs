namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of an array of angles.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UAngleArrayObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new angle observation to the given agent interactor. Call during ULearningAgentsInteractor::SetupObservations event.</summary>
	public static UAngleArrayObservation AddAngleArrayObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,int AngleNum/*=1*/,float Scale/*=1.0f*/) { return default; }
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetAngleArrayObservation(int AgentId,TArray<float> Angles,float RelativeAngle/*=0.0f*/) {}
}
