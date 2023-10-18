namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A controller provides a method for injecting actions into the learning agents system from some other existing</summary>
[CppInclude("LearningAgentsController.h")]
public partial class ULearningAgentsController : ULearningAgentsManagerComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Initializes this object to be used with the given agent interactor.</summary>
	public void SetupController(ULearningAgentsInteractor InInteractor) {}
	///<summary>During this event, you should set the actions of your agents.</summary>
	public void SetActions(TArray<int> AgentIds) {}
	///<summary>Call this function when it is time to gather all the actions for your agents. This should be called roughly</summary>
	public void EncodeActions() {}
	///<summary>Calls EncodeObservations, followed by EncodeActions, followed by DecodeActions</summary>
	public void RunController() {}
	///<summary>Gets the agent interactor associated with this component.</summary>
	public ULearningAgentsInteractor GetInteractor(UClass InteractorClass) { return default; }
	///<summary>The agent interactor this controller is associated with.</summary>
	public ULearningAgentsInteractor Interactor;
}
