#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/ChaosGameplayEventDispatcher.h")]
public partial class UChaosGameplayEventDispatcher : UChaosEventListenerComponent {
// ChaosGameplayEventDispatcher
	public TMap<UPrimitiveComponent,FChaosHandlerSet> CollisionEventRegistrations;
	public TMap<UPrimitiveComponent,FBreakEventCallbackWrapper> BreakEventRegistrations;
	public TMap<UPrimitiveComponent,FRemovalEventCallbackWrapper> RemovalEventRegistrations;
	public TMap<UPrimitiveComponent,FCrumblingEventCallbackWrapper> CrumblingEventRegistrations;
}
