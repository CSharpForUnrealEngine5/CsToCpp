namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct containing all of the data that can be different between different emitter versions.</summary>
[CppInclude("NiagaraEmitter.h")]
public partial struct FVersionedNiagaraEmitterData {
	public FNiagaraAssetVersion Version;
	public FText VersionChangeDescription;
	public ENiagaraPythonUpdateScriptReference UpdateScriptExecution;
	public string PythonUpdateScript;
	public FFilePath ScriptAsset;
	public bool bDeprecated;
	public FText DeprecationMessage;
	public bool bLocalSpace;
	public bool bDeterminism;
	public int RandomSeed;
	public bool bInterpolatedSpawning;
	public bool bGpuAlwaysRunParticleUpdateScript;
	public ENiagaraSimTarget SimTarget;
	public ENiagaraEmitterCalculateBoundMode CalculateBoundsMode;
	public FBox FixedBounds;
	public bool bRequiresPersistentIDs;
	public bool bCombineEventSpawn;
	public TArray<FNiagaraEventScriptProperties> EventHandlerScriptProps;
	public FNiagaraPlatformSet Platforms;
	public FNiagaraEmitterScalabilityOverrides ScalabilityOverrides;
	public bool bLimitDeltaTime;
	public int MaxGPUParticlesSpawnPerFrame;
	public float MaxDeltaTimePerTick;
	public EParticleAllocationMode AllocationMode;
	public int PreAllocationCount;
	public FNiagaraEmitterScriptProperties UpdateScriptProps;
	public FNiagaraEmitterScriptProperties SpawnScriptProps;
	public FNiagaraParameterStore RendererBindings;
	public TArray<string> AttributesToPreserve;
	public FNiagaraEmitterScriptProperties EmitterSpawnScriptProps;
	public FNiagaraEmitterScriptProperties EmitterUpdateScriptProps;
	public UNiagaraScriptSourceBase GraphSource;
	public UNiagaraScratchPadContainer ScratchPads;
	public UNiagaraScratchPadContainer ParentScratchPads;
	public FVersionedNiagaraEmitter VersionedParent;
	public FVersionedNiagaraEmitter VersionedParentAtLastMerge;
	public TArray<UNiagaraRendererProperties> RendererProperties;
	public TArray<UNiagaraSimulationStageBase> SimulationStages;
	public UNiagaraScript GPUComputeScript;
	public TArray<string> SharedEventGeneratorIds;
	public FNiagaraEmitterScalabilitySettings CurrentScalabilitySettings;
	public UNiagaraEditorDataBase EditorData;
	public UNiagaraEditorParametersAdapterBase EditorParameters;
}
