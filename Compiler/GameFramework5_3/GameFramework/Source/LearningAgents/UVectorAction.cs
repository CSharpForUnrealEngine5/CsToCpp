namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple FVector action.</summary>
[CppInclude("LearningAgentsActions.h")]
public partial class UVectorAction : ULearningAgentsAction {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new vector action to the given agent interactor. Call during ULearningAgentsInteractor::SetupActions event.</summary>
	public static UVectorAction AddVectorAction(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,float Scale/*=1.0f*/) { return default; }
	///<summary>Gets the data for this action. Call during ULearningAgentsInteractor::GetActions event.</summary>
	public FVector GetVectorAction(int AgentId) { return default; }
	///<summary>Sets the data for this action. Call during ULearningAgentsController::SetActions event.</summary>
	public void SetVectorAction(int AgentId,FVector Value) {}
}
