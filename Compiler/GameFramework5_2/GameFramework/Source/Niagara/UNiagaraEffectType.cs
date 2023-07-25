#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEffectType.h")]
///<summary>Contains settings and working data shared among many NiagaraSystems that share some commonality of type. For example ImpactFX vs EnvironmentalFX.</summary>
public partial class UNiagaraEffectType : UObject {
// NiagaraEffectType
	public bool bAllowCullingForLocalPlayers;
	public ENiagaraScalabilityUpdateFrequency UpdateFrequency;
	public ENiagaraCullReaction CullReaction;
	public UNiagaraSignificanceHandler SignificanceHandler;
	public TArray<FNiagaraSystemScalabilitySettings> DetailLevelScalabilitySettings_DEPRECATED;
	public FNiagaraSystemScalabilitySettingsArray SystemScalabilitySettings;
	public FNiagaraEmitterScalabilitySettingsArray EmitterScalabilitySettings;
	public TArray<UNiagaraValidationRule> ValidationRules;
	public TArray<UNiagaraValidationRuleSet> ValidationRuleSets;
	public UNiagaraBaselineController PerformanceBaselineController;
	public FNiagaraPerfBaselineStats PerfBaselineStats;
	public FGuid PerfBaselineVersion;
}
