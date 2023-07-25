#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Async/AbilityAsync_WaitAttributeChanged.h")]
public partial class UAbilityAsync_WaitAttributeChanged : UAbilityAsync {
// AbilityAsync_WaitAttributeChanged
	public UObject WaitForAttributeChanged(UObject TargetActor,FGameplayAttribute Attribute,bool OnlyTriggerOnce/*=false*/) { return default; }
	public void FAsyncWaitAttributeChangedDelegate(FGameplayAttribute Attribute,float NewValue,float OldValue) {}
	public FAsyncWaitAttributeChangedDelegate Changed;
}
