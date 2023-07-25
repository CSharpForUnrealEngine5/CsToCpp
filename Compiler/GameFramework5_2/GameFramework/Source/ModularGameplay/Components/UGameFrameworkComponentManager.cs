#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/GameFrameworkComponentManager.h")]
///<summary>GameFrameworkComponentManager</summary>
public partial class UGameFrameworkComponentManager : UGameInstanceSubsystem {
// GameFrameworkComponentManager
	public void AddReceiver(UObject Receiver,bool bAddOnlyInGameWorlds/*=true*/) {}
	public void RemoveReceiver(UObject Receiver) {}
	public void SendExtensionEvent(UObject Receiver,string EventName,bool bOnlyInGameWorlds/*=true*/) {}
	public bool RegisterAndCallForActorInitState(UObject Actor,string FeatureName,FGameplayTag RequiredState,FActorInitStateChangedBPDelegate Delegate,bool bCallImmediately/*=true*/) { return default; }
	public bool UnregisterActorInitStateDelegate(UObject Actor,FActorInitStateChangedBPDelegate DelegateToRemove) { return default; }
	public bool RegisterAndCallForClassInitState(TSoftObjectPtr<UClass> ActorClass,string FeatureName,FGameplayTag RequiredState,FActorInitStateChangedBPDelegate Delegate,bool bCallImmediately/*=true*/) { return default; }
	public bool UnregisterClassInitStateDelegate(TSoftObjectPtr<UClass> ActorClass,FActorInitStateChangedBPDelegate DelegateToRemove) { return default; }
}
