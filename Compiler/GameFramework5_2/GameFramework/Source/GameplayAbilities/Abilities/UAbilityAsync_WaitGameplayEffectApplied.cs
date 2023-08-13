namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This action listens for specific gameplay effect applications based off specified tags.</summary>
[CppInclude("Abilities/Async/AbilityAsync_WaitGameplayEffectApplied.h")]
public partial class UAbilityAsync_WaitGameplayEffectApplied : UAbilityAsync {
	public static UClass StaticClass() {return default;}
	///<summary>Wait until a GameplayEffect is applied to a target actor</summary>
	public static UAbilityAsync_WaitGameplayEffectApplied WaitGameplayEffectAppliedToActor(AActor TargetActor,FGameplayTargetDataFilterHandle SourceFilter,FGameplayTagRequirements SourceTagRequirements,FGameplayTagRequirements TargetTagRequirements,bool TriggerOnce/*=false*/,bool ListenForPeriodicEffect/*=false*/) { return default; }
	///<summary>FOnAppliedDelegate</summary>
	public void FOnAppliedDelegate(AActor Source,FGameplayEffectSpecHandle SpecHandle,FActiveGameplayEffectHandle ActiveHandle) {}
	///<summary>OnApplied</summary>
	public FOnAppliedDelegate OnApplied;
}
