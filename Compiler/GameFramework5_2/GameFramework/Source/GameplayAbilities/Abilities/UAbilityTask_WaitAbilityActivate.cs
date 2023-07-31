#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Waits for the actor to activate another ability</summary>
[CppInclude("Abilities/Tasks/AbilityTask_WaitAbilityActivate.h")]
public partial class UAbilityTask_WaitAbilityActivate : UAbilityTask {
	///<summary>OnActivate</summary>
	public FWaitAbilityActivateDelegate OnActivate;
	///<summary>OnAbilityActivate</summary>
	public  void OnAbilityActivate(UGameplayAbility ActivatedAbility) {}
	///<summary>Wait until a new ability (of the same or different type) is activated. Only input based abilities will be counted unless IncludeTriggeredAbilities is true.</summary>
	public static UAbilityTask_WaitAbilityActivate WaitForAbilityActivate(UGameplayAbility OwningAbility,FGameplayTag WithTag,FGameplayTag WithoutTag,bool IncludeTriggeredAbilities/*=false*/,bool TriggerOnce/*=true*/) { return default; }
	///<summary>Wait until a new ability (of the same or different type) is activated. Only input based abilities will be counted unless IncludeTriggeredAbilities is true. Uses a tag requirements structure to filter abilities.</summary>
	public static UAbilityTask_WaitAbilityActivate WaitForAbilityActivateWithTagRequirements(UGameplayAbility OwningAbility,FGameplayTagRequirements TagRequirements,bool IncludeTriggeredAbilities/*=false*/,bool TriggerOnce/*=true*/) { return default; }
	///<summary>Wait until a new ability (of the same or different type) is activated. Only input based abilities will be counted unless IncludeTriggeredAbilities is true.</summary>
	public static UAbilityTask_WaitAbilityActivate WaitForAbilityActivate_Query(UGameplayAbility OwningAbility,FGameplayTagQuery Query,bool IncludeTriggeredAbilities/*=false*/,bool TriggerOnce/*=true*/) { return default; }
}
