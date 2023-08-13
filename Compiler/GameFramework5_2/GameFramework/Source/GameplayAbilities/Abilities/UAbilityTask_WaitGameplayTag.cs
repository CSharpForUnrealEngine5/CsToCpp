namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitGameplayTagBase.h")]
public partial class UAbilityTask_WaitGameplayTag : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>GameplayTagCallback</summary>
	public virtual void GameplayTagCallback(FGameplayTag Tag,int NewCount) {}
	///<summary>OptionalExternalTarget</summary>
	public UAbilitySystemComponent OptionalExternalTarget;
}
