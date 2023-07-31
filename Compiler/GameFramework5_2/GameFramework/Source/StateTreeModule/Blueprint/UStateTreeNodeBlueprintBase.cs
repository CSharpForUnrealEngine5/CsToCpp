#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/StateTreeNodeBlueprintBase.h")]
public partial class UStateTreeNodeBlueprintBase : UObject {
	///<summary>Sends event to the StateTree.</summary>
	public  void SendEvent(FStateTreeEvent Event) {}
	///<summary>Request state transition.</summary>
	public  void RequestTransition(FStateTreeStateLink TargetState,EStateTreeTransitionPriority Priority/*=EStateTreeTransitionPriority.Normal*/) {}
	///<summary>Cached owner while the node is active.</summary>
	public UObject CachedOwner;
}
