namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Async/AbilityAsync_WaitAttributeChanged.h")]
public partial class UAbilityAsync_WaitAttributeChanged : UAbilityAsync {
	public static UClass StaticClass() {return default;}
	///<summary>Wait until the specified gameplay attribute is changed on a target ability system component</summary>
	public static UAbilityAsync_WaitAttributeChanged WaitForAttributeChanged(AActor TargetActor,FGameplayAttribute Attribute,bool OnlyTriggerOnce/*=false*/) { return default; }
	///<summary>FAsyncWaitAttributeChangedDelegate</summary>
	public void FAsyncWaitAttributeChangedDelegate(FGameplayAttribute Attribute,float NewValue,float OldValue) {}
	///<summary>Changed</summary>
	public FAsyncWaitAttributeChangedDelegate Changed;
}
