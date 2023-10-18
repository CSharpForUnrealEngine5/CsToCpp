namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An array of rotation actions.</summary>
[CppInclude("LearningAgentsActions.h")]
public partial class URotationArrayAction : ULearningAgentsAction {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new rotation array action to the given agent interactor. Call during ULearningAgentsInteractor::SetupActions event.</summary>
	public static URotationArrayAction AddRotationArrayAction(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,int RotationNum/*=1*/,float Scale/*=180.0f*/) { return default; }
	///<summary>Gets the data for this action as rotators. Call during ULearningAgentsInteractor::GetActions event.</summary>
	public void GetRotationArrayAction(int AgentId,TArray<FRotator> OutRotations) {}
	///<summary>Gets the data for this action as rotation vectors. Call during ULearningAgentsInteractor::GetActions event.</summary>
	public void GetRotationArrayActionAsRotationVectors(int AgentId,TArray<FVector> OutRotationVectors) {}
	///<summary>Gets the data for this action as quaternions. Call during ULearningAgentsInteractor::GetActions event.</summary>
	public void GetRotationArrayActionAsQuats(int AgentId,TArray<FQuat> OutRotations) {}
}
