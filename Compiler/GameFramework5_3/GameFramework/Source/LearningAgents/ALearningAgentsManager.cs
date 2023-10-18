namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The agent manager is responsible for tracking which game objects are agents. It&#39;s the central class around which</summary>
[CppInclude("LearningAgentsManager.h")]
public partial class ALearningAgentsManager : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the maximum number of agents that this manager is configured to handle.</summary>
	public int GetMaxAgentNum() { return default; }
	///<summary>Adds the given object as an agent to the manager.</summary>
	public int AddAgent(UObject Agent) { return default; }
	///<summary>Adds the given objects as an agents to the manager.</summary>
	public void AddAgents(TArray<int> OutAgentIds,TArray<UObject> InAgents) {}
	///<summary>Removes the agent with the given id from the manager.</summary>
	public void RemoveAgent(int AgentId) {}
	///<summary>Removes the agents with the given ids from the manager.</summary>
	public void RemoveAgents(TArray<int> AgentIds) {}
	///<summary>Removes all agents from the manager.</summary>
	public void RemoveAllAgents() {}
	///<summary>Resets the agent with the given id on the manager. Used to tell components to reset any state associated with this agent.</summary>
	public void ResetAgent(int AgentId) {}
	///<summary>Resets the agents with the given ids on the manager. Used to tell components to reset any state associated with this agent.</summary>
	public void ResetAgents(TArray<int> AgentIds) {}
	///<summary>Resets all the agents on the manager.</summary>
	public void ResetAllAgents() {}
	///<summary>Gets the agent with the given id. Calling this from blueprint with the appropriate AgentClass will automatically</summary>
	public UObject GetAgent(int AgentId,UClass AgentClass) { return default; }
	///<summary>Gets the agents associated with a set of ids. Calling this from blueprint with the appropriate AgentClass will</summary>
	public void GetAgents(TArray<UObject> OutAgents,TArray<int> AgentIds,UClass AgentClass) {}
	///<summary>Gets all added agents. Calling this from blueprint with the appropriate AgentClass will automatically</summary>
	public void GetAllAgents(TArray<UObject> OutAgents,TArray<int> OutAgentIds,UClass AgentClass) {}
	///<summary>Gets the agent id associated with a given agent.</summary>
	public int GetAgentId(UObject Agent) { return default; }
	///<summary>Gets the agent ids associated with a set of agents.</summary>
	public void GetAgentIds(TArray<int> OutAgentIds,TArray<UObject> InAgents) {}
	///<summary>Gets the number of agents added</summary>
	public int GetAgentNum() { return default; }
	///<summary>Returns true if the given object is an agent used by the manager; Otherwise, false.</summary>
	public bool HasAgentObject(UObject Agent) { return default; }
	///<summary>Returns true if the given id is an agent used by the manager; Otherwise, false.</summary>
	public bool HasAgent(int AgentId) { return default; }
	///<summary>Adds this manager as a tick prerequisite of the given actor objects.</summary>
	public void AddManagerAsTickPrerequisiteOfAgents(TArray<AActor> InAgents) {}
	///<summary>Adds the given actor objects as tick prerequisite of this manager.</summary>
	public void AddAgentsAsTickPrerequisiteOfManager(TArray<AActor> InAgents) {}
	///<summary>Maximum number of agents. Used to preallocate internal buffers. Setting this higher will allow more agents but use up more memory.</summary>
	public int MaxAgentNum;
	///<summary>The list of current agents.</summary>
	public TArray<UObject> Agents;
}
