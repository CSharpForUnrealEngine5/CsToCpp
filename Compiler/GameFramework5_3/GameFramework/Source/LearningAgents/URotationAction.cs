namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A rotation action.</summary>
[CppInclude("LearningAgentsActions.h")]
public partial class URotationAction : ULearningAgentsAction {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new rotation action to the given agent interactor. Call during ULearningAgentsInteractor::SetupActions event.</summary>
	public static URotationAction AddRotationAction(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,float Scale/*=180.0f*/) { return default; }
	///<summary>Gets the data for this action as a rotator. Call during ULearningAgentsInteractor::GetActions event.</summary>
	public FRotator GetRotationAction(int AgentId) { return default; }
	///<summary>Gets the data for this action as a rotation vector. Call during ULearningAgentsInteractor::GetActions event.</summary>
	public FVector GetRotationActionAsRotationVector(int AgentId) { return default; }
	///<summary>Gets the data for this action as a quaternion. Call during ULearningAgentsInteractor::GetActions event.</summary>
	public FQuat GetRotationActionAsQuat(int AgentId) { return default; }
}
