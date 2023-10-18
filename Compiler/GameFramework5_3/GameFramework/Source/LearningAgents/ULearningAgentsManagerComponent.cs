namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for components which can be attached to an ALearningAgentsManager.</summary>
[CppInclude("LearningAgentsManagerComponent.h")]
public partial class ULearningAgentsManagerComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>During this event, any additional logic required for when agents are added can be executed.</summary>
	public void AgentsAdded(TArray<int> AgentIds) {}
	///<summary>During this event, any additional logic required for when agents are removed can be executed.</summary>
	public void AgentsRemoved(TArray<int> AgentIds) {}
	///<summary>During this event, any additional logic required for when agents are reset can be executed.</summary>
	public void AgentsReset(TArray<int> AgentIds) {}
	///<summary>Returns true if this component has been setup. Otherwise, false.</summary>
	public bool IsSetup() { return default; }
	///<summary>Gets the agent with the given id from the manager. Calling this from blueprint with the appropriate AgentClass</summary>
	public UObject GetAgent(int AgentId,UClass AgentClass) { return default; }
	///<summary>Gets the agents associated with a set of ids from the manager. Calling this from blueprint with the appropriate</summary>
	public void GetAgents(TArray<int> AgentIds,UClass AgentClass,TArray<UObject> OutAgents) {}
	///<summary>Gets all added agents from the manager. Calling this from blueprint with the appropriate AgentClass will</summary>
	public void GetAllAgents(TArray<UObject> OutAgents,TArray<int> OutAgentIds,UClass AgentClass) {}
	///<summary>Gets the agent manager associated with this component.</summary>
	public ALearningAgentsManager GetAgentManager(UClass AgentManagerClass) { return default; }
	///<summary>True if this component has been setup. Otherwise, false.</summary>
	public bool bIsSetup;
	///<summary>The associated manager this component is attached to.</summary>
	public ALearningAgentsManager Manager;
	///<summary>The list of current helper objects.</summary>
	public TArray<ULearningAgentsHelper> HelperObjects;
}
