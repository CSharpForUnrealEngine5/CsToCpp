namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayTag.h")]
public partial class UAbilityTask_WaitGameplayTagRemoved : UAbilityTask_WaitGameplayTag {
	public static UClass StaticClass() {return default;}
	///<summary>Removed</summary>
	public FWaitGameplayTagDelegate Removed;
	///<summary>Wait until the specified gameplay tag is Removed. By default this will look at the owner of this ability. OptionalExternalTarget can be set to make this look at another actor&#39;s tags for changes.</summary>
	public static UAbilityTask_WaitGameplayTagRemoved WaitGameplayTagRemove(UGameplayAbility OwningAbility,FGameplayTag Tag,AActor InOptionalExternalTarget/*=nullptr*/,bool OnlyTriggerOnce/*=false*/) { return default; }
}
