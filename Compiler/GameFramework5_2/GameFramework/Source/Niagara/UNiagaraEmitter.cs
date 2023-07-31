#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Niagara Emitters are particle spawners that can be reused for different effects by putting them into Niagara Systems.</summary>
[CppInclude("NiagaraEmitter.h")]
public partial class UNiagaraEmitter : UObject {
	///<summary>The exposed version is the version that is used by default when a user adds this emitter somewhere. It is basically the published version and allows a user to create and test newer versions.</summary>
	public FGuid ExposedVersion;
	///<summary>If true then this emitter asset uses active version control to track changes.</summary>
	public bool bVersioningEnabled;
	///<summary>Contains all of the versioned emitter data.</summary>
	public TArray<FVersionedNiagaraEmitterData> VersionData;
	///<summary>TemplateSpecification</summary>
	public ENiagaraScriptTemplateSpecification TemplateSpecification;
	///<summary>TemplateAssetDescription</summary>
	public string TemplateAssetDescription;
	///<summary>Category to collate this emitter into for &quot;add new emitter&quot; dialogs.</summary>
	public string Category;
	///<summary>Internal: The thumbnail image.</summary>
	public UTexture2D ThumbnailImage;
	///<summary>If this emitter is exposed to the library, or should be explicitly hidden.</summary>
	public ENiagaraScriptLibraryVisibility LibraryVisibility;
	///<summary>This is used as a transient value to open a specific version in the editor</summary>
	public FGuid VersionToOpenInEditor;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public bool bLocalSpace_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public bool bDeterminism_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public int RandomSeed_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public EParticleAllocationMode AllocationMode_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public int PreAllocationCount_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public FNiagaraEmitterScriptProperties UpdateScriptProps_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public FNiagaraEmitterScriptProperties SpawnScriptProps_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public FNiagaraEmitterScriptProperties EmitterSpawnScriptProps_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public FNiagaraEmitterScriptProperties EmitterUpdateScriptProps_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public TArray<string> AttributesToPreserve_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public TArray<UNiagaraScript> ParentScratchPadScripts_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public ENiagaraSimTarget SimTarget_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public FBox FixedBounds_DEPRECATED;
	///<summary>MinDetailLevel_DEPRECATED</summary>
	public int MinDetailLevel_DEPRECATED;
	///<summary>MaxDetailLevel_DEPRECATED</summary>
	public int MaxDetailLevel_DEPRECATED;
	///<summary>GlobalSpawnCountScaleOverrides_DEPRECATED</summary>
	public FNiagaraDetailsLevelScaleOverrides GlobalSpawnCountScaleOverrides_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public FNiagaraPlatformSet Platforms_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public FNiagaraEmitterScalabilityOverrides ScalabilityOverrides_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public bool bInterpolatedSpawning_DEPRECATED;
	///<summary>RendererBindings_DEPRECATED</summary>
	public FNiagaraParameterStore RendererBindings_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public bool bFixedBounds_DEPRECATED;
	///<summary>Whether to use the min detail or not.</summary>
	public bool bUseMinDetailLevel_DEPRECATED;
	///<summary>Whether to use the min detail or not.</summary>
	public bool bUseMaxDetailLevel_DEPRECATED;
	///<summary>Legacy bool to control overriding the global spawn count scales.</summary>
	public bool bOverrideGlobalSpawnCountScale_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public bool bRequiresPersistentIDs_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public bool bCombineEventSpawn_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public float MaxDeltaTimePerTick_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public bool bLimitDeltaTime_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public uint MaxGPUParticlesSpawnPerFrame_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public UNiagaraScriptSourceBase GraphSource_DEPRECATED;
	///<summary>Deprecated library exposure bool. Use the LibraryVisibility enum instead. FNiagaraEditorUtilities has accessor functions that takes deprecation into account</summary>
	public bool bExposeToLibrary_DEPRECATED;
	///<summary>Deprecated template asset bool. Use the TemplateSpecification enum instead.</summary>
	public bool bIsTemplateAsset_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public TArray<UNiagaraScript> ScratchPadScripts_DEPRECATED;
	///<summary>Adjusted every time that we compile this emitter. Lets us know that we might differ from any cached versions.</summary>
	public FGuid ChangeId;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public UNiagaraEditorDataBase EditorData_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public UNiagaraEditorParametersAdapterBase EditorParameters_DEPRECATED;
	///<summary>UniqueEmitterName</summary>
	public string UniqueEmitterName;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public TArray<UNiagaraRendererProperties> RendererProperties_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public TArray<FNiagaraEventScriptProperties> EventHandlerScriptProps_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public TArray<UNiagaraSimulationStageBase> SimulationStages_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public UNiagaraScript GPUComputeScript_DEPRECATED;
	///<summary>Use property in struct returned from GetEmitterData() instead</summary>
	public TArray<string> SharedEventGeneratorIds_DEPRECATED;
	///<summary>Parent_DEPRECATED</summary>
	public UNiagaraEmitter Parent_DEPRECATED;
	///<summary>ParentAtLastMerge_DEPRECATED</summary>
	public UNiagaraEmitter ParentAtLastMerge_DEPRECATED;
	///<summary>Subscriptions to definitions of parameters.</summary>
	public TArray<FParameterDefinitionsSubscription> ParameterDefinitionsSubscriptions;
	///<summary>Messages associated with the Emitter asset.</summary>
	public TMap<FGuid,UNiagaraMessageDataBase> MessageKeyToMessageMap;
}
