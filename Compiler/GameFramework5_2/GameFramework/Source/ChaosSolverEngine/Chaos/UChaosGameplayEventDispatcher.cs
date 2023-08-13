namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/ChaosGameplayEventDispatcher.h")]
public partial class UChaosGameplayEventDispatcher : UChaosEventListenerComponent {
	public static UClass StaticClass() {return default;}
	///<summary>CollisionEventRegistrations</summary>
	public TMap<UPrimitiveComponent,FChaosHandlerSet> CollisionEventRegistrations;
	///<summary>BreakEventRegistrations</summary>
	public TMap<UPrimitiveComponent,FBreakEventCallbackWrapper> BreakEventRegistrations;
	///<summary>RemovalEventRegistrations</summary>
	public TMap<UPrimitiveComponent,FRemovalEventCallbackWrapper> RemovalEventRegistrations;
	///<summary>CrumblingEventRegistrations</summary>
	public TMap<UPrimitiveComponent,FCrumblingEventCallbackWrapper> CrumblingEventRegistrations;
}
