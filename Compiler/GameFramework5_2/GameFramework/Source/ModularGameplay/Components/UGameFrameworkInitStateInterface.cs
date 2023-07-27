#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/GameFrameworkInitStateInterface.h")]
public partial class UGameFrameworkInitStateInterface : UInterface {
// GameFrameworkInitStateInterface
	public  string GetFeatureName() { return default; }
	public  FGameplayTag GetInitState() { return default; }
	public  bool HasReachedInitState(FGameplayTag DesiredState) { return default; }
	public  bool RegisterAndCallForInitStateChange(FGameplayTag RequiredState,FActorInitStateChangedBPDelegate Delegate,bool bCallImmediately/*=true*/) { return default; }
	public  bool UnregisterInitStateDelegate(FActorInitStateChangedBPDelegate Delegate) { return default; }
}
