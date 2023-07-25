#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/StateTreeComponent.h")]
public partial class UStateTreeComponent : UBrainComponent {
// StateTreeComponent
	public void SetStartLogicAutomatically(bool bInStartLogicAutomatically) {}
	public void SendStateTreeEvent(FStateTreeEvent Event) {}
	public EStateTreeRunStatus GetStateTreeRunStatus() { return default; }
	public FStateTreeRunStatusChanged OnStateTreeRunStatusChanged;
	public UStateTree StateTree_DEPRECATED;
	public FStateTreeReference StateTreeRef;
	public bool bStartLogicAutomatically;
	public FStateTreeInstanceData InstanceData;
}
