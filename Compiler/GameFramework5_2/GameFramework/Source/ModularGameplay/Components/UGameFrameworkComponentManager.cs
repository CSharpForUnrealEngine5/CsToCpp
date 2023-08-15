namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GameFrameworkComponentManager</summary>
[CppInclude("Components/GameFrameworkComponentManager.h")]
public partial class UGameFrameworkComponentManager : UGameInstanceSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Adds an actor as a receiver for components. If it passes the actorclass filter on requests it will get the components.</summary>
	public void AddReceiver(AActor Receiver,bool bAddOnlyInGameWorlds/*=true*/) {}
	///<summary>Removes an actor as a receiver for components.</summary>
	public void RemoveReceiver(AActor Receiver) {}
	///<summary>Sends an arbitrary extension event that can be listened for by other systems</summary>
	public void SendExtensionEvent(AActor Receiver,FName EventName,bool bOnlyInGameWorlds/*=true*/) {}
	///<summary>Registers blueprint delegate for feature state change notifications on a specific actor and may call it immediately</summary>
	public bool RegisterAndCallForActorInitState(AActor Actor,FName FeatureName,FGameplayTag RequiredState,FActorInitStateChangedBPDelegate Delegate,bool bCallImmediately/*=true*/) { return default; }
	///<summary>Removes a registered delegate bound to a specific actor</summary>
	public bool UnregisterActorInitStateDelegate(AActor Actor,FActorInitStateChangedBPDelegate DelegateToRemove) { return default; }
	///<summary>Registers blueprint delegate for feature state change notifications on a class of actors and may call it immediately</summary>
	public bool RegisterAndCallForClassInitState(TSoftObjectPtr<UClass> ActorClass,FName FeatureName,FGameplayTag RequiredState,FActorInitStateChangedBPDelegate Delegate,bool bCallImmediately/*=true*/) { return default; }
	///<summary>Removes a registered delegate bound to a class</summary>
	public bool UnregisterClassInitStateDelegate(TSoftObjectPtr<UClass> ActorClass,FActorInitStateChangedBPDelegate DelegateToRemove) { return default; }
}
