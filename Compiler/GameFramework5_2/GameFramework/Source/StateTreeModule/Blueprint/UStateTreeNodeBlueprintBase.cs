namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/StateTreeNodeBlueprintBase.h")]
public partial class UStateTreeNodeBlueprintBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Sends event to the StateTree.</summary>
	public void SendEvent(FStateTreeEvent Event) {}
	///<summary>Request state transition.</summary>
	public void RequestTransition(FStateTreeStateLink TargetState,EStateTreeTransitionPriority Priority/*=EStateTreeTransitionPriority.Normal*/) {}
	///<summary>Cached owner while the node is active.</summary>
	public UObject CachedOwner;
}
