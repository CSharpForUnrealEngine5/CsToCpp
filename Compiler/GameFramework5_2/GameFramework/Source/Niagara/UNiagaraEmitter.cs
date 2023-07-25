#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEmitter.h")]
///<summary>Niagara Emitters are particle spawners that can be reused for different effects by putting them into Niagara Systems.</summary>
public partial class UNiagaraEmitter : UObject {
// NiagaraEmitter
	public FGuid ExposedVersion;
	public bool bVersioningEnabled;
	public TArray<FVersionedNiagaraEmitterData> VersionData;
	public ENiagaraScriptTemplateSpecification TemplateSpecification;
	public string TemplateAssetDescription;
	public string Category;
	public UTexture2D ThumbnailImage;
	public ENiagaraScriptLibraryVisibility LibraryVisibility;
	public FGuid VersionToOpenInEditor;
	public bool bLocalSpace_DEPRECATED;
	public bool bDeterminism_DEPRECATED;
	public int RandomSeed_DEPRECATED;
	public EParticleAllocationMode AllocationMode_DEPRECATED;
	public int PreAllocationCount_DEPRECATED;
	public FNiagaraEmitterScriptProperties UpdateScriptProps_DEPRECATED;
	public FNiagaraEmitterScriptProperties SpawnScriptProps_DEPRECATED;
	public FNiagaraEmitterScriptProperties EmitterSpawnScriptProps_DEPRECATED;
	public FNiagaraEmitterScriptProperties EmitterUpdateScriptProps_DEPRECATED;
	public TArray<string> AttributesToPreserve_DEPRECATED;
	public TArray<UNiagaraScript> ParentScratchPadScripts_DEPRECATED;
	public ENiagaraSimTarget SimTarget_DEPRECATED;
	public FBox FixedBounds_DEPRECATED;
	public int MinDetailLevel_DEPRECATED;
	public int MaxDetailLevel_DEPRECATED;
	public FNiagaraDetailsLevelScaleOverrides GlobalSpawnCountScaleOverrides_DEPRECATED;
	public FNiagaraPlatformSet Platforms_DEPRECATED;
	public FNiagaraEmitterScalabilityOverrides ScalabilityOverrides_DEPRECATED;
	public bool bInterpolatedSpawning_DEPRECATED;
	public FNiagaraParameterStore RendererBindings_DEPRECATED;
	public bool bFixedBounds_DEPRECATED;
	public bool bUseMinDetailLevel_DEPRECATED;
	public bool bUseMaxDetailLevel_DEPRECATED;
	public bool bOverrideGlobalSpawnCountScale_DEPRECATED;
	public bool bRequiresPersistentIDs_DEPRECATED;
	public bool bCombineEventSpawn_DEPRECATED;
	public float MaxDeltaTimePerTick_DEPRECATED;
	public bool bLimitDeltaTime_DEPRECATED;
	public uint MaxGPUParticlesSpawnPerFrame_DEPRECATED;
	public UNiagaraScriptSourceBase GraphSource_DEPRECATED;
	public bool bExposeToLibrary_DEPRECATED;
	public bool bIsTemplateAsset_DEPRECATED;
	public TArray<UNiagaraScript> ScratchPadScripts_DEPRECATED;
	public FGuid ChangeId;
	public UNiagaraEditorDataBase EditorData_DEPRECATED;
	public UNiagaraEditorParametersAdapterBase EditorParameters_DEPRECATED;
	public string UniqueEmitterName;
	public TArray<UNiagaraRendererProperties> RendererProperties_DEPRECATED;
	public TArray<FNiagaraEventScriptProperties> EventHandlerScriptProps_DEPRECATED;
	public TArray<UNiagaraSimulationStageBase> SimulationStages_DEPRECATED;
	public UNiagaraScript GPUComputeScript_DEPRECATED;
	public TArray<string> SharedEventGeneratorIds_DEPRECATED;
	public UNiagaraEmitter Parent_DEPRECATED;
	public UNiagaraEmitter ParentAtLastMerge_DEPRECATED;
	public TArray<FParameterDefinitionsSubscription> ParameterDefinitionsSubscriptions;
	public TMap<FGuid,UNiagaraMessageDataBase> MessageKeyToMessageMap;
}
