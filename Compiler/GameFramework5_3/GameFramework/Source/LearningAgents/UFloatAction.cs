namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple float action. Used as a catch-all for situations where a more type-specific action does not exist yet.</summary>
[CppInclude("LearningAgentsActions.h")]
public partial class UFloatAction : ULearningAgentsAction {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new float action to the given agent interactor. Call during ULearningAgentsInteractor::SetupActions event.</summary>
	public static UFloatAction AddFloatAction(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,float Scale/*=1.0f*/) { return default; }
	///<summary>Gets the data for this action. Call during ULearningAgentsInteractor::GetActions event.</summary>
	public float GetFloatAction(int AgentId) { return default; }
	///<summary>Sets the data for this action. Call during ULearningAgentsController::SetActions event.</summary>
	public void SetFloatAction(int AgentId,float Value) {}
}
