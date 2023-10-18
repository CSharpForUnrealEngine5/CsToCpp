namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ULearningAgentsInteractor defines how agents interact with the environment through their observations and actions.</summary>
[CppInclude("LearningAgentsInteractor.h")]
public partial class ULearningAgentsInteractor : ULearningAgentsManagerComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Initializes this object and runs the setup events for observations and actions.</summary>
	public void SetupInteractor() {}
	///<summary>During this event, all observations should be added to this agent interactor.</summary>
	public void SetupObservations() {}
	///<summary>During this event, all observations should be set for each agent.</summary>
	public void SetObservations(TArray<int> AgentIds) {}
	///<summary>During this event, all actions should be added to this agent interactor.</summary>
	public void SetupActions() {}
	///<summary>During this event, you should retrieve the actions and apply them to your agents.</summary>
	public void GetActions(TArray<int> AgentIds) {}
	///<summary>Call this function when it is time to gather all the observations for your agents. This can be done each frame or</summary>
	public void EncodeObservations() {}
	///<summary>Call this function when it is time for your agents to take their actions. You most likely want to call this after</summary>
	public void DecodeActions() {}
	///<summary>Gets the observation vector used by a given agent. Should be called only after EncodeObservations.</summary>
	public void GetObservationVector(int AgentId,TArray<float> OutObservationVector) {}
	///<summary>Gets the action vector used by a given agent. Should be called only after EncodeActions or EvaluatePolicy.</summary>
	public void GetActionVector(int AgentId,TArray<float> OutActionVector) {}
	///<summary>The list of current observation objects.</summary>
	public TArray<ULearningAgentsObservation> ObservationObjects;
	///<summary>The list of current action objects.</summary>
	public TArray<ULearningAgentsAction> ActionObjects;
}
