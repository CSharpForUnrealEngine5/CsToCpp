#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/StateTreeNodeBlueprintBase.h")]
public partial class UStateTreeNodeBlueprintBase : UObject {
// StateTreeNodeBlueprintBase
	public  void SendEvent(FStateTreeEvent Event) {}
	public  void RequestTransition(FStateTreeStateLink TargetState,EStateTreeTransitionPriority Priority/*=EStateTreeTransitionPriority.Normal*/) {}
	public UObject CachedOwner;
}
