namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple float array action. Used as a catch-all for situations where a more type-specific action does not exist yet.</summary>
[CppInclude("LearningAgentsActions.h")]
public partial class UFloatArrayAction : ULearningAgentsAction {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new float array action to the given agent interactor. Call during ULearningAgentsInteractor::SetupActions event.</summary>
	public static UFloatArrayAction AddFloatArrayAction(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,int Num/*=1*/,float Scale/*=1.0f*/) { return default; }
	///<summary>Gets the data for this action. Call during ULearningAgentsInteractor::GetActions event.</summary>
	public void GetFloatArrayAction(int AgentId,TArray<float> OutValues) {}
	///<summary>Sets the data for this action. Call during ULearningAgentsController::SetActions event.</summary>
	public void SetFloatArrayAction(int AgentId,TArray<float> Values) {}
}
