#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEditorSettings.h")]
public partial class UNiagaraEditorSettings : UDeveloperSettings {
// NiagaraEditorSettings
	public FSoftObjectPath DefaultScript;
	public FSoftObjectPath DefaultDynamicInputScript;
	public FSoftObjectPath DefaultFunctionScript;
	public FSoftObjectPath DefaultModuleScript;
	public FSoftObjectPath RequiredSystemUpdateScript;
	public TArray<TSoftObjectPtr<UNiagaraValidationRuleSet>> DefaultValidationRuleSets;
	public TArray<FNiagaraSpawnShortcut> GraphCreationShortcuts;
	public bool bSimplifyStackNodesAtLowResolution;
	public int LowResolutionNodeMaxNameChars;
	public bool bAlwaysZoomToFitSystemGraph;
	public bool bAutoCompile;
	public bool bAutoPlay;
	public bool bResetSimulationOnChange;
	public bool bResimulateOnChangeWhilePaused;
	public bool bResetDependentSystemsWhenEditingEmitters;
	public bool bDisplayAdvancedParameterPanelCategories;
	public bool bDisplayAffectedAssetStats;
	public int AffectedAssetSearchLimit;
	public TArray<float> PlaybackSpeeds;
	public FNiagaraActionColors ActionColors;
	public TMap<string,FNiagaraNewAssetDialogConfig> NewAssetDialogConfigMap;
	public TMap<string,string> HLSLKeywordReplacements;
	public TArray<FNiagaraNamespaceMetadata> NamespaceMetadata;
	public TArray<FNiagaraNamespaceMetadata> NamespaceModifierMetadata;
	public FNiagaraNamespaceMetadata DefaultNamespaceMetadata;
	public FNiagaraNamespaceMetadata DefaultNamespaceModifierMetadata;
	public TArray<FNiagaraCurveTemplate> CurveTemplates;
	public bool bShowGridInViewport;
	public bool bShowInstructionsCount;
	public bool bShowParticleCountsInViewport;
	public bool bShowEmitterExecutionOrder;
	public bool bShowGpuTickInformation;
	public TArray<FNiagaraParameterPanelSectionStorage> SystemParameterPanelSectionData;
}
