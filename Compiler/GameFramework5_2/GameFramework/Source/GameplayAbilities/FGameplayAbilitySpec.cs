namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An activatable ability spec, hosted on the ability system component. This defines both what the ability is (what class, what level, input binding etc)</summary>
[CppInclude("GameplayAbilitySpec.h")]
public partial struct FGameplayAbilitySpec {
	public FGameplayAbilitySpecHandle Handle;
	public UGameplayAbility Ability;
	public int Level;
	public int InputID;
	public TWeakObjectPtr<UObject> SourceObject;
	public byte ActiveCount;
	public bool InputPressed;
	public bool RemoveAfterActivation;
	public bool PendingRemove;
	public bool bActivateOnce;
	public FGameplayAbilityActivationInfo ActivationInfo;
	public FGameplayTagContainer DynamicAbilityTags;
	public TArray<UGameplayAbility> NonReplicatedInstances;
	public TArray<UGameplayAbility> ReplicatedInstances;
	public FActiveGameplayEffectHandle GameplayEffectHandle;
}
