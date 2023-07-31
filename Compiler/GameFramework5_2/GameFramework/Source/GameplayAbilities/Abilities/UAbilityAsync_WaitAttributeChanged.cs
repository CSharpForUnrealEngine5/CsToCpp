#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Async/AbilityAsync_WaitAttributeChanged.h")]
public partial class UAbilityAsync_WaitAttributeChanged : UAbilityAsync {
	///<summary>Wait until the specified gameplay attribute is changed on a target ability system component</summary>
	public static UAbilityAsync_WaitAttributeChanged WaitForAttributeChanged(AActor TargetActor,FGameplayAttribute Attribute,bool OnlyTriggerOnce/*=false*/) { return default; }
	///<summary>FAsyncWaitAttributeChangedDelegate</summary>
	public  void FAsyncWaitAttributeChangedDelegate(FGameplayAttribute Attribute,float NewValue,float OldValue) {}
	///<summary>Changed</summary>
	public FAsyncWaitAttributeChangedDelegate Changed;
}
