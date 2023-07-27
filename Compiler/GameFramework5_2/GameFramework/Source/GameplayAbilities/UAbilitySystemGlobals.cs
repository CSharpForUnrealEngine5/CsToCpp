#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AbilitySystemGlobals.h")]
///<summary>Holds global data for the ability system. Can be configured per project via config file</summary>
public partial class UAbilitySystemGlobals : UObject {
// AbilitySystemGlobals
	public FSoftClassPath AbilitySystemGlobalsClassName;
	public  void ToggleIgnoreAbilitySystemCooldowns() {}
	public  void ToggleIgnoreAbilitySystemCosts() {}
	public  void ListPlayerAbilities() {}
	public  void ServerActivatePlayerAbility(string AbilityNameMatch) {}
	public  void ServerEndPlayerAbility(string AbilityNameMatch) {}
	public  void ServerCancelPlayerAbility(string AbilityNameMatch) {}
	public bool bUseDebugTargetFromHud;
	public FGameplayTag ActivateFailIsDeadTag;
	public string ActivateFailIsDeadName;
	public FGameplayTag ActivateFailCooldownTag;
	public string ActivateFailCooldownName;
	public FGameplayTag ActivateFailCostTag;
	public string ActivateFailCostName;
	public FGameplayTag ActivateFailTagsBlockedTag;
	public string ActivateFailTagsBlockedName;
	public FGameplayTag ActivateFailTagsMissingTag;
	public string ActivateFailTagsMissingName;
	public FGameplayTag ActivateFailNetworkingTag;
	public string ActivateFailNetworkingName;
	public int MinimalReplicationTagCountBits;
	public FNetSerializeScriptStructCache TargetDataStructCache;
	public bool bAllowGameplayModEvaluationChannels;
	public EGameplayModEvaluationChannel DefaultGameplayModEvaluationChannel;
	public string GameplayModEvaluationChannelAliases;
	public FSoftObjectPath GlobalCurveTableName;
	public UCurveTable GlobalCurveTable;
	public FSoftObjectPath GlobalAttributeMetaDataTableName;
	public UDataTable GlobalAttributeMetaDataTable;
	public FSoftObjectPath GlobalAttributeSetDefaultsTableName;
	public TArray<FSoftObjectPath> GlobalAttributeSetDefaultsTableNames;
	public TArray<UCurveTable> GlobalAttributeDefaultsTables;
	public FSoftObjectPath GlobalGameplayCueManagerClass;
	public FSoftObjectPath GlobalGameplayCueManagerName;
	public TArray<string> GameplayCueNotifyPaths;
	public FSoftObjectPath GameplayTagResponseTableName;
	public UGameplayTagReponseTable GameplayTagResponseTable;
	public bool PredictTargetGameplayEffects;
	public bool ReplicateActivationOwnedTags;
	public UGameplayCueManager GlobalGameplayCueManager;
}
