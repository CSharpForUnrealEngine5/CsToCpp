namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds global data for the ability system. Can be configured per project via config file</summary>
[CppInclude("AbilitySystemGlobals.h")]
public partial class UAbilitySystemGlobals : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The class to instantiate as the globals object. Defaults to this class but can be overridden</summary>
	public FSoftClassPath AbilitySystemGlobalsClassName;
	///<summary>Set to true if you want the &quot;ShowDebug AbilitySystem&quot; cheat to use the hud&#39;s debug target instead of the ability system&#39;s debug target.</summary>
	public bool bUseDebugTargetFromHud;
	///<summary>TryActivate failed due to being dead</summary>
	public FGameplayTag ActivateFailIsDeadTag;
	///<summary>ActivateFailIsDeadName</summary>
	public FName ActivateFailIsDeadName;
	///<summary>TryActivate failed due to being on cooldown</summary>
	public FGameplayTag ActivateFailCooldownTag;
	///<summary>ActivateFailCooldownName</summary>
	public FName ActivateFailCooldownName;
	///<summary>TryActivate failed due to not being able to spend costs</summary>
	public FGameplayTag ActivateFailCostTag;
	///<summary>ActivateFailCostName</summary>
	public FName ActivateFailCostName;
	///<summary>TryActivate failed due to being blocked by other abilities</summary>
	public FGameplayTag ActivateFailTagsBlockedTag;
	///<summary>ActivateFailTagsBlockedName</summary>
	public FName ActivateFailTagsBlockedName;
	///<summary>TryActivate failed due to missing required tags</summary>
	public FGameplayTag ActivateFailTagsMissingTag;
	///<summary>ActivateFailTagsMissingName</summary>
	public FName ActivateFailTagsMissingName;
	///<summary>Failed to activate due to invalid networking settings, this is designer error</summary>
	public FGameplayTag ActivateFailNetworkingTag;
	///<summary>ActivateFailNetworkingName</summary>
	public FName ActivateFailNetworkingName;
	///<summary>How many bits to use for &quot;number of tags&quot; in FMinimalReplicationTagCountMap::NetSerialize.</summary>
	public int MinimalReplicationTagCountBits;
	///<summary>TargetDataStructCache</summary>
	public FNetSerializeScriptStructCache TargetDataStructCache;
	///<summary>EffectContextStructCache</summary>
	public FNetSerializeScriptStructCache EffectContextStructCache;
	///<summary>Whether the game should allow the usage of gameplay mod evaluation channels or not</summary>
	public bool bAllowGameplayModEvaluationChannels;
	///<summary>The default mod evaluation channel for the game</summary>
	public EGameplayModEvaluationChannel DefaultGameplayModEvaluationChannel;
	///<summary>Game-specified named aliases for gameplay mod evaluation channels; Only those with valid aliases are eligible to be used in a game (except Channel0, which is always valid)</summary>
	public FName GameplayModEvaluationChannelAliases;
	///<summary>Name of global curve table to use as the default for scalable floats, etc.</summary>
	public FSoftObjectPath GlobalCurveTableName;
	///<summary>GlobalCurveTable</summary>
	public UCurveTable GlobalCurveTable;
	///<summary>Holds information about the valid attributes&#39; min and max values and stacking rules</summary>
	public FSoftObjectPath GlobalAttributeMetaDataTableName;
	///<summary>GlobalAttributeMetaDataTable</summary>
	public UDataTable GlobalAttributeMetaDataTable;
	///<summary>Holds default values for attribute sets, keyed off of Name/Levels. NOTE: Preserved for backwards compatibility, should use the array version below now</summary>
	public FSoftObjectPath GlobalAttributeSetDefaultsTableName;
	///<summary>Array of curve table names to use for default values for attribute sets, keyed off of Name/Levels</summary>
	public TArray<FSoftObjectPath> GlobalAttributeSetDefaultsTableNames;
	///<summary>Curve tables containing default values for attribute sets, keyed off of Name/Levels</summary>
	public TArray<UCurveTable> GlobalAttributeDefaultsTables;
	///<summary>Class reference to gameplay cue manager. Use this if you want to just instantiate a class for your gameplay cue manager without having to create an asset.</summary>
	public FSoftObjectPath GlobalGameplayCueManagerClass;
	///<summary>Object reference to gameplay cue manager (E.g., reference to a specific blueprint of your GameplayCueManager class. This is not necessary unless you want to have data or blueprints in your gameplay cue manager.</summary>
	public FSoftObjectPath GlobalGameplayCueManagerName;
	///<summary>Look in these paths for GameplayCueNotifies. These are your &quot;always loaded&quot; set.</summary>
	public TArray<string> GameplayCueNotifyPaths;
	///<summary>The class to instantiate as the GameplayTagResponseTable.</summary>
	public FSoftObjectPath GameplayTagResponseTableName;
	///<summary>GameplayTagResponseTable</summary>
	public UGameplayTagReponseTable GameplayTagResponseTable;
	///<summary>Set to true if you want clients to try to predict gameplay effects done to targets. If false it will only predict self effects</summary>
	public bool PredictTargetGameplayEffects;
	///<summary>Set to true if you want tags granted to owners from ability activations to be replicated. If false, ActivationOwnedTags are only applied locally.</summary>
	public bool ReplicateActivationOwnedTags;
	///<summary>Manager for all gameplay cues</summary>
	public UGameplayCueManager GlobalGameplayCueManager;
}
