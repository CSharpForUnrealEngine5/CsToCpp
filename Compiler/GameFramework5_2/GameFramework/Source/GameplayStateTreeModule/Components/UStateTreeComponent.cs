#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/StateTreeComponent.h")]
public partial class UStateTreeComponent : UBrainComponent {
	///<summary>Sets whether the State Tree is started automatically on being play.</summary>
	public  void SetStartLogicAutomatically(bool bInStartLogicAutomatically) {}
	///<summary>Sends event to the running StateTree.</summary>
	public  void SendStateTreeEvent(FStateTreeEvent Event) {}
	///<summary>Returns the current run status of the StateTree.</summary>
	public  EStateTreeRunStatus GetStateTreeRunStatus() { return default; }
	///<summary>Called when the run status of the StateTree has changed</summary>
	public FStateTreeRunStatusChanged OnStateTreeRunStatusChanged;
	///<summary>StateTree_DEPRECATED</summary>
	public UStateTree StateTree_DEPRECATED;
	///<summary>StateTreeRef</summary>
	public FStateTreeReference StateTreeRef;
	///<summary>If true, the StateTree logic is started on begin play. Otherwise StartLogic() needs to be called.</summary>
	public bool bStartLogicAutomatically;
	///<summary>InstanceData</summary>
	public FStateTreeInstanceData InstanceData;
}
