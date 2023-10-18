namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains settings and working data shared among many NiagaraSystems that share some commonality of type. For example ImpactFX vs EnvironmentalFX.</summary>
[CppInclude("NiagaraEffectType.h")]
public partial class UNiagaraEffectType : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Controls whether or not culling is allowed for FX that are owned by, attached to or instigated by a locally controlled pawn.</summary>
	public bool bAllowCullingForLocalPlayers;
	///<summary>How regularly effects of this type are checked for scalability.</summary>
	public ENiagaraScalabilityUpdateFrequency UpdateFrequency;
	///<summary>How effects of this type react when they fail the cull checks.</summary>
	public ENiagaraCullReaction CullReaction;
	///<summary>Used to determine the relative significance of FX in the scene which is used in other scalability systems such as instance count culling.</summary>
	public UNiagaraSignificanceHandler SignificanceHandler;
	///<summary>Cull settings to use at each detail level.</summary>
	public TArray<FNiagaraSystemScalabilitySettings> DetailLevelScalabilitySettings_DEPRECATED;
	///<summary>SystemScalabilitySettings</summary>
	public FNiagaraSystemScalabilitySettingsArray SystemScalabilitySettings;
	///<summary>EmitterScalabilitySettings</summary>
	public FNiagaraEmitterScalabilitySettingsArray EmitterScalabilitySettings;
	///<summary>A set of rules to apply when checking content. To create your own rules, write a custom class that extends UNiagaraValidationRule.</summary>
	public TArray<UNiagaraValidationRule> ValidationRules;
	///<summary>Array of reusable rule sets to apply when checking content. To create your own rules, write a custom class that extends UNiagaraValidationRule.</summary>
	public TArray<UNiagaraValidationRuleSet> ValidationRuleSets;
	///<summary>Controls generation of performance baseline data for this effect type.</summary>
	public UNiagaraBaselineController PerformanceBaselineController;
	///<summary>Performance data gathered from the Baseline System.</summary>
	public FNiagaraPerfBaselineStats PerfBaselineStats;
	///<summary>Version guid at the time these baseline stats were generated.</summary>
	public FGuid PerfBaselineVersion;
}
