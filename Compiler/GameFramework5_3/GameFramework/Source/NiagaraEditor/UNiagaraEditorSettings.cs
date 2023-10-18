namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEditorSettings.h")]
public partial class UNiagaraEditorSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Niagara script to duplicate as the base of all new script assets created.</summary>
	public FSoftObjectPath DefaultScript;
	///<summary>Niagara script to duplicate as the base of all new script assets created.</summary>
	public FSoftObjectPath DefaultDynamicInputScript;
	///<summary>Niagara script to duplicate as the base of all new script assets created.</summary>
	public FSoftObjectPath DefaultFunctionScript;
	///<summary>Niagara script to duplicate as the base of all new script assets created.</summary>
	public FSoftObjectPath DefaultModuleScript;
	///<summary>Niagara script which is required in the system update script to control system state.</summary>
	public FSoftObjectPath RequiredSystemUpdateScript;
	///<summary>Validation rules applied to all Niagara systems.</summary>
	public TArray<TSoftObjectPtr<UNiagaraValidationRuleSet>> DefaultValidationRuleSets;
	///<summary>Shortcut key bindings that if held down while doing a mouse click, will spawn the specified type of Niagara node.</summary>
	public TArray<FNiagaraSpawnShortcut> GraphCreationShortcuts;
	///<summary>If true then emitter and system nodes will show a simplified representation on low zoom levels. This improves performance and readablity when zoomed out of the system overview graph.</summary>
	public bool bSimplifyStackNodesAtLowResolution;
	///<summary>The max number of chars before names on the low resolution nodes are truncated.</summary>
	public int LowResolutionNodeMaxNameChars;
	///<summary>If true then the system editor will zoom to fit all emitters when opening an asset.</summary>
	public bool bAlwaysZoomToFitSystemGraph;
	///<summary>RendererCategoryExpandState</summary>
	public ENiagaraCategoryExpandState RendererCategoryExpandState;
	///<summary>DefaultsSequencerSubtracks</summary>
	public ENiagaraAddDefaultsTrackMode DefaultsSequencerSubtracks;
	///<summary>Whether or not auto-compile is enabled in the editors.</summary>
	public bool bAutoCompile;
	///<summary>Whether or not simulations should start playing automatically when the emitter or system editor is opened, or when the data is changed in the editor.</summary>
	public bool bAutoPlay;
	///<summary>Whether or not the simulation should reset when a value on the emitter or system is changed.</summary>
	public bool bResetSimulationOnChange;
	///<summary>Whether or not to rerun the simulation to the current time when making modifications while paused.</summary>
	public bool bResimulateOnChangeWhilePaused;
	///<summary>Whether or not to reset all components that include the system currently being reset.</summary>
	public bool bResetDependentSystemsWhenEditingEmitters;
	///<summary>Whether or not to display advanced categories for the parameter panel.</summary>
	public bool bDisplayAdvancedParameterPanelCategories;
	///<summary>If true, then the emitter and script editors will show an info message how many downstream asset are affected by a change. Gathering this information for large asset graphs can delay the opening of the asset editors a bit.</summary>
	public bool bDisplayAffectedAssetStats;
	///<summary>The maximum amount of asset references that are searched before stopping. Setting this too high can lead to long load times when opening default assets (basically the same as disabling the breadth limit in the reference viewer).</summary>
	public int AffectedAssetSearchLimit;
	///<summary>This affects numeric inputs for modules. When set to false, the inputs update the simulation while typing. When set to true, the simulation is only updated after submitting the change by pressing Enter.</summary>
	public bool bUpdateStackValuesOnCommitOnly;
	///<summary>Speeds used for slowing down and speeding up the playback speeds</summary>
	public TArray<float> PlaybackSpeeds;
	///<summary>ActionColors</summary>
	public FNiagaraActionColors ActionColors;
	///<summary>NewAssetDialogConfigMap</summary>
	public TMap<FName,FNiagaraNewAssetDialogConfig> NewAssetDialogConfigMap;
	///<summary>HLSLKeywordReplacements</summary>
	public TMap<string,string> HLSLKeywordReplacements;
	///<summary>NamespaceMetadata</summary>
	public TArray<FNiagaraNamespaceMetadata> NamespaceMetadata;
	///<summary>NamespaceModifierMetadata</summary>
	public TArray<FNiagaraNamespaceMetadata> NamespaceModifierMetadata;
	///<summary>DefaultNamespaceMetadata</summary>
	public FNiagaraNamespaceMetadata DefaultNamespaceMetadata;
	///<summary>DefaultNamespaceModifierMetadata</summary>
	public FNiagaraNamespaceMetadata DefaultNamespaceModifierMetadata;
	///<summary>CurveTemplates</summary>
	public TArray<FNiagaraCurveTemplate> CurveTemplates;
	///<summary>ViewportSettings</summary>
	public FNiagaraViewportSharedSettings ViewportSettings;
	///<summary>SystemParameterPanelSectionData</summary>
	public TArray<FNiagaraParameterPanelSectionStorage> SystemParameterPanelSectionData;
}
