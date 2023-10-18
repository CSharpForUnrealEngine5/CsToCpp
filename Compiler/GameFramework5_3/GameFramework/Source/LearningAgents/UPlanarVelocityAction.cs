namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A planar velocity action.</summary>
[CppInclude("LearningAgentsActions.h")]
public partial class UPlanarVelocityAction : ULearningAgentsAction {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new planar velocity action to the given agent interactor. The axis parameters define the plane.</summary>
	public static UPlanarVelocityAction AddPlanarVelocityAction(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,float Scale/*=200.0f*/,FVector Axis0/*=FVector.ForwardVector*/,FVector Axis1/*=FVector.RightVector*/) { return default; }
	///<summary>Gets the data for this action. Call during ULearningAgentsInteractor::GetActions event.</summary>
	public FVector GetPlanarVelocityAction(int AgentId) { return default; }
	///<summary>Sets the data for this action. Call during ULearningAgentsController::SetActions event.</summary>
	public void SetPlanarVelocityAction(int AgentId,FVector Velocity) {}
}
