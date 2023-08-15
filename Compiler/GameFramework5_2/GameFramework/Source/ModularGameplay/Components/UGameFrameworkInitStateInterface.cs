namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/GameFrameworkInitStateInterface.h")]
public partial class UGameFrameworkInitStateInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the feature this object implements, this interface is only meant for simple objects with a single feature like Actor</summary>
	public virtual FName GetFeatureName() { return default; }
	///<summary>Returns the current feature state of this object, the default behavior is to query the manager</summary>
	public virtual FGameplayTag GetInitState() { return default; }
	///<summary>Checks the component manager to see if we have already reached the desired state or a later one</summary>
	public virtual bool HasReachedInitState(FGameplayTag DesiredState) { return default; }
	///<summary>Binds a BP delegate to get called on a state change for this feature</summary>
	public virtual bool RegisterAndCallForInitStateChange(FGameplayTag RequiredState,FActorInitStateChangedBPDelegate Delegate,bool bCallImmediately/*=true*/) { return default; }
	///<summary>Unbinds a BP delegate from changes to this feature</summary>
	public virtual bool UnregisterInitStateDelegate(FActorInitStateChangedBPDelegate Delegate) { return default; }
}
