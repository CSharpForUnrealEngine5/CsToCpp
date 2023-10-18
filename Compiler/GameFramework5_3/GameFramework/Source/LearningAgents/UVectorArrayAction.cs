namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple array of FVector action.</summary>
[CppInclude("LearningAgentsActions.h")]
public partial class UVectorArrayAction : ULearningAgentsAction {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new vector action to the given agent interactor. Call during ULearningAgentsInteractor::SetupActions event.</summary>
	public static UVectorArrayAction AddVectorArrayAction(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,int Num/*=1*/,float Scale/*=1.0f*/) { return default; }
	///<summary>Gets the data for this action. Call during ULearningAgentsInteractor::GetActions event.</summary>
	public void GetVectorArrayAction(int AgentId,TArray<FVector> OutVectors) {}
	///<summary>Sets the data for this action. Call during ULearningAgentsController::SetActions event.</summary>
	public void SetVectorArrayAction(int AgentId,TArray<FVector> Vectors) {}
}
