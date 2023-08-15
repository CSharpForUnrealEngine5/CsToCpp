namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Niagara System contains multiple Niagara Emitters to create various effects.</summary>
[CppInclude("NiagaraSystem.h")]
public partial class UNiagaraSystem : UFXSystemAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Internal: The thumbnail image.</summary>
	public UTexture2D ThumbnailImage;
	///<summary>Deprecated library exposure bool. Use the LibraryVisibility enum instead. FNiagaraEditorUtilities has accessor functions that takes deprecation into account</summary>
	public bool bExposeToLibrary_DEPRECATED;
	///<summary>If this system is exposed to the library, or should be explicitly hidden.</summary>
	public ENiagaraScriptLibraryVisibility LibraryVisibility;
	///<summary>Deprecated template asset bool. Use the TemplateSpecification enum instead.</summary>
	public bool bIsTemplateAsset_DEPRECATED;
	///<summary>If this system is a regular system, a template or a behavior example.</summary>
	public ENiagaraScriptTemplateSpecification TemplateSpecification;
	///<summary>TemplateAssetDescription</summary>
	public FText TemplateAssetDescription;
	///<summary>Category of this system.</summary>
	public FText Category;
	///<summary>ScratchPadScripts</summary>
	public TArray<UNiagaraScript> ScratchPadScripts;
	///<summary>EditorOnlyAddedParameters</summary>
	public FNiagaraParameterStore EditorOnlyAddedParameters;
	///<summary>UpdateContext</summary>
	public FNiagaraSystemUpdateContext UpdateContext;
	///<summary>When enabled we compile for the edit path, which can result in slower system performance but faster editor responsiveness.</summary>
	public bool bCompileForEdit;
	///<summary>When enable constant values are baked into the scripts while editing the system, this will increase iteration times but improve performance.</summary>
	public bool bBakeOutRapidIteration;
	///<summary>When enabled constant values are baked into scripts to improve performance.</summary>
	public bool bBakeOutRapidIterationOnCook;
	///<summary>Toggles whether or not emitters within this system will try and compress their particle attributes.</summary>
	public bool bCompressAttributes;
	///<summary>When enabled we trim particle attributes while editing the system.</summary>
	public bool bTrimAttributes;
	///<summary>If true Particle attributes will be removed from the DataSet if they are unnecessary (are never read by ParameterMap)</summary>
	public bool bTrimAttributesOnCook;
	///<summary>If true ParticleReads will not absolutely prevent attribute trimming - User must ensure that the appropriate attributes are preserved on the source emitter!</summary>
	public bool bIgnoreParticleReadsForAttributeTrim;
	///<summary>When enable debug switches are disabled while editing the system.</summary>
	public bool bDisableDebugSwitches;
	///<summary>When enabled debug switches are disabled when compiling the system.</summary>
	public bool bDisableDebugSwitchesOnCook;
	///<summary>Subscriptions to definitions of parameters.</summary>
	public TArray<FParameterDefinitionsSubscription> ParameterDefinitionsSubscriptions;
	///<summary>If true then position type values will be rebased on system activation to fit into a float precision vector. This needs to be turned off when using a custom data interface or renderer that does not support the rebasing.</summary>
	public bool bSupportLargeWorldCoordinates;
	///<summary>Various optional overrides for component properties when spawning a system</summary>
	public bool bOverrideCastShadow;
	///<summary>bOverrideReceivesDecals</summary>
	public bool bOverrideReceivesDecals;
	///<summary>bOverrideRenderCustomDepth</summary>
	public bool bOverrideRenderCustomDepth;
	///<summary>bOverrideCustomDepthStencilValue</summary>
	public bool bOverrideCustomDepthStencilValue;
	///<summary>bOverrideCustomDepthStencilWriteMask</summary>
	public bool bOverrideCustomDepthStencilWriteMask;
	///<summary>bOverrideTranslucencySortPriority</summary>
	public bool bOverrideTranslucencySortPriority;
	///<summary>bOverrideTranslucencySortDistanceOffset</summary>
	public bool bOverrideTranslucencySortDistanceOffset;
	///<summary>When enabled this is the default value set on the component.</summary>
	public bool bCastShadow;
	///<summary>When enabled this is the default value set on the component.</summary>
	public bool bReceivesDecals;
	///<summary>When enabled this is the default value set on the component.</summary>
	public bool bRenderCustomDepth;
	///<summary>If true, disables experimental VM, if available</summary>
	public bool bDisableExperimentalVM;
	///<summary>When enabled this is the default value set on the component.</summary>
	public ERendererStencilMask CustomDepthStencilWriteMask;
	///<summary>When enabled this is the default value set on the component.</summary>
	public int CustomDepthStencilValue;
	///<summary>When enabled this is the default value set on the component.</summary>
	public int TranslucencySortPriority;
	///<summary>When enabled this is the default value set on the component.</summary>
	public float TranslucencySortDistanceOffset;
	///<summary>bDumpDebugSystemInfo</summary>
	public bool bDumpDebugSystemInfo;
	///<summary>bDumpDebugEmitterInfo</summary>
	public bool bDumpDebugEmitterInfo;
	///<summary>When enabled, we follow the settings on the UNiagaraComponent for tick order. When this option is disabled, we ignore any dependencies from data interfaces or other variables and instead fire off the simulation as early in the frame as possible. This greatly</summary>
	public bool bRequireCurrentFrameData;
	///<summary>Whether or not fixed bounds are enabled.</summary>
	public bool bFixedBounds;
	///<summary>EffectType</summary>
	public UNiagaraEffectType EffectType;
	///<summary>bOverrideScalabilitySettings</summary>
	public bool bOverrideScalabilitySettings;
	///<summary>Controls whether we should override the Effect Type value for bAllowCullingForLocalPlayers.</summary>
	public bool bOverrideAllowCullingForLocalPlayers;
	///<summary>The override value for bAllowCullingForLocalPlayers from the Effect Type.</summary>
	public bool bAllowCullingForLocalPlayersOverride;
	///<summary>ScalabilityOverrides_DEPRECATED</summary>
	public TArray<FNiagaraSystemScalabilityOverride> ScalabilityOverrides_DEPRECATED;
	///<summary>SystemScalabilityOverrides</summary>
	public FNiagaraSystemScalabilityOverrides SystemScalabilityOverrides;
	///<summary>Handles to the emitter this System will simulate.</summary>
	public TArray<FNiagaraEmitterHandle> EmitterHandles;
	///<summary>ParameterCollectionOverrides</summary>
	public TArray<UNiagaraParameterCollectionInstance> ParameterCollectionOverrides;
	///<summary>ActiveCompilations</summary>
	public TArray<FNiagaraSystemCompileRequest> ActiveCompilations;
	///<summary>The script which defines the System parameters, and which generates the bindings from System</summary>
	public UNiagaraScript SystemSpawnScript;
	///<summary>The script which defines the System parameters, and which generates the bindings from System</summary>
	public UNiagaraScript SystemUpdateScript;
	///<summary>/ Post compile generated data used for initializing System Instances during runtime.</summary>
	public FNiagaraSystemCompiledData SystemCompiledData;
	///<summary>Variables exposed to the outside work for tweaking</summary>
	public FNiagaraUserRedirectionParameterStore ExposedParameters;
	///<summary>Data used by the editor to maintain UI state etc..</summary>
	public UNiagaraEditorDataBase EditorData;
	///<summary>Wrapper for editor only parameters.</summary>
	public UNiagaraEditorParametersAdapterBase EditorParameters;
	///<summary>The fixed bounding box value. bFixedBounds is the condition whether the fixed bounds can be edited.</summary>
	public FBox FixedBounds;
	///<summary>Auto-deactivate system if all emitters are determined to not spawn particles again, regardless of lifetime.</summary>
	public bool bAutoDeactivate;
	///<summary>When disabled we will generate a RandomSeed per instance on reset which is not deterministic.</summary>
	public bool bDeterminism;
	///<summary>Seed used for system script random number generator.</summary>
	public int RandomSeed;
	///<summary>Warm up time in seconds. Used to calculate WarmupTickCount. Rounds down to the nearest multiple of WarmupTickDelta.</summary>
	public float WarmupTime;
	///<summary>Number of ticks to process for warmup. You can set by this or by time via WarmupTime.</summary>
	public int WarmupTickCount;
	///<summary>Delta time to use for warmup ticks.</summary>
	public float WarmupTickDelta;
	///<summary>bFixedTickDelta</summary>
	public bool bFixedTickDelta;
	///<summary>If activated, the system ticks with a fixed delta time instead of the varying game thread delta time. This leads to much more stable simulations.</summary>
	public float FixedTickDeltaTime;
	///<summary>Settings used inside the baker</summary>
	public UNiagaraBakerSettings BakerSettings;
	///<summary>Generated data baker settings, will be null until we have generated at least once.</summary>
	public UNiagaraBakerSettings BakerGeneratedSettings;
	///<summary>bHasSystemScriptDIsWithPerInstanceData</summary>
	public bool bHasSystemScriptDIsWithPerInstanceData;
	///<summary>bNeedsGPUContextInitForDataInterfaces</summary>
	public bool bNeedsGPUContextInitForDataInterfaces;
	///<summary>UserDINamesReadInSystemScripts</summary>
	public TArray<FName> UserDINamesReadInSystemScripts;
	///<summary>ReferencedDataChannelDefinitions</summary>
	public TArray<UNiagaraDataChannelDefinitions> ReferencedDataChannelDefinitions;
	///<summary>Messages associated with the System asset.</summary>
	public TMap<FGuid,UNiagaraMessageDataBase> MessageKeyToMessageMap;
}
