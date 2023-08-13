namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UNiagaraComponent is the primitive component for a Niagara System.</summary>
[CppInclude("NiagaraComponent.h")]
public partial class UNiagaraComponent : UFXSystemComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Asset</summary>
	public UNiagaraSystem Asset;
	///<summary>Allows you to control how Niagara selects the tick group, changing this while an instance is active will result in not change as it is cached.</summary>
	public ENiagaraTickBehavior TickBehavior;
	///<summary>Offsets the deterministic random seed of all emitters. Used to achieve variety between components, while still achieving determinism.</summary>
	public int RandomSeedOffset;
	///<summary>OverrideParameters</summary>
	public FNiagaraUserRedirectionParameterStore OverrideParameters;
	///<summary>EditorOverridesValue_DEPRECATED</summary>
	public TMap<string,bool> EditorOverridesValue_DEPRECATED;
	///<summary>TemplateParameterOverrides</summary>
	public TMap<FNiagaraVariableBase,FNiagaraVariant> TemplateParameterOverrides;
	///<summary>InstanceParameterOverrides</summary>
	public TMap<FNiagaraVariableBase,FNiagaraVariant> InstanceParameterOverrides;
	///<summary>When true, this component&#39;s system will be force to update via a slower &quot;solo&quot; path rather than the more optimal batched path with other instances of the same system.</summary>
	public bool bForceSolo;
	///<summary>When true the GPU simulation debug display will enabled, allowing information used during simulation to be visualized.</summary>
	public bool bEnableGpuComputeDebug;
	///<summary>When true then this instance will override the system&#39;s warmup settings.</summary>
	public bool bOverrideWarmupSettings;
	///<summary>Number of ticks to process for warmup of the system. Total warmup time is WarmupTickCount * WarmupTickDelta.</summary>
	public int WarmupTickCount;
	///<summary>Delta time used when ticking the system in warmup mode.</summary>
	public float WarmupTickDelta;
	///<summary>bAutoDestroy</summary>
	public bool bAutoDestroy;
	///<summary>bRenderingEnabled</summary>
	public bool bRenderingEnabled;
	///<summary>True if we should automatically attach to AutoAttachParent when activated, and detach from our parent when completed.</summary>
	public bool bAutoManageAttachment;
	///<summary>Option for how we handle bWeldSimulatedBodies when we attach to the AutoAttachParent, if bAutoManageAttachment is true.</summary>
	public bool bAutoAttachWeldSimulatedBodies;
	///<summary>Time between forced UpdateTransforms for systems that use dynamically calculated bounds,</summary>
	public float MaxTimeBeforeForceUpdateTransform;
	///<summary>Switch which asset the component is using.</summary>
	public void SetAsset(UNiagaraSystem InAsset,bool bResetExistingOverrideParameters/*=true*/) {}
	///<summary>GetAsset</summary>
	public UNiagaraSystem GetAsset() { return default; }
	///<summary>SetForceSolo</summary>
	public void SetForceSolo(bool bInForceSolo) {}
	///<summary>GetForceSolo</summary>
	public bool GetForceSolo() { return default; }
	///<summary>SetGpuComputeDebug</summary>
	public void SetGpuComputeDebug(bool bEnableDebug) {}
	///<summary>Sets the custom time dilation value for the component.</summary>
	public void SetCustomTimeDilation(float Dilation/*=1.0f*/) {}
	///<summary>GetCustomTimeDilation</summary>
	public float GetCustomTimeDilation() { return default; }
	///<summary>GetAgeUpdateMode</summary>
	public ENiagaraAgeUpdateMode GetAgeUpdateMode() { return default; }
	///<summary>Sets the age update mode for the System instance.</summary>
	public void SetAgeUpdateMode(ENiagaraAgeUpdateMode InAgeUpdateMode) {}
	///<summary>Gets the desired age of the System instance.  This is only relevant when using the DesiredAge age update mode.</summary>
	public float GetDesiredAge() { return default; }
	///<summary>Sets the desired age of the System instance.  This is only relevant when using the DesiredAge age update mode.</summary>
	public void SetDesiredAge(float InDesiredAge) {}
	///<summary>Sets the desired age of the System instance and designates that this change is a seek.  When seeking to a desired age the</summary>
	public void SeekToDesiredAge(float InDesiredAge) {}
	///<summary>Sets whether or not the system can render while seeking.</summary>
	public void SetCanRenderWhileSeeking(bool bInCanRenderWhileSeeking) {}
	///<summary>Gets the delta value which is used when seeking from the current age, to the desired age.  This is only relevant</summary>
	public float GetSeekDelta() { return default; }
	///<summary>Sets the delta value which is used when seeking from the current age, to the desired age.  This is only relevant</summary>
	public void SetSeekDelta(float InSeekDelta) {}
	///<summary>Gets whether or not the delta time used to tick the system instance when using desired age is locked to the seek delta.  When true, the system instance</summary>
	public bool GetLockDesiredAgeDeltaTimeToSeekDelta() { return default; }
	///<summary>Sets whether or not the delta time used to tick the system instance when using desired age is locked to the seek delta.  When true, the system instance</summary>
	public void SetLockDesiredAgeDeltaTimeToSeekDelta(bool bLock) {}
	///<summary>Get the maximum CPU time in seconds we will simulate to the desired age, when we go beyond this limit ticks will be processed in the next frame.</summary>
	public float GetMaxSimTime() { return default; }
	///<summary>Sets the maximum CPU time in seconds we will simulate to the desired age, when we go beyond this limit ticks will be processed in the next frame.</summary>
	public void SetMaxSimTime(float InMaxTime) {}
	///<summary>SetAutoDestroy</summary>
	public void SetAutoDestroy(bool bInAutoDestroy) {}
	///<summary>SetTickBehavior</summary>
	public void SetTickBehavior(ENiagaraTickBehavior NewTickBehavior) {}
	///<summary>GetTickBehavior</summary>
	public ENiagaraTickBehavior GetTickBehavior() { return default; }
	///<summary>Sets the fixed bounds for the system instance, this overrides all other bounds.</summary>
	public void SetSystemFixedBounds(FBox LocalBounds) {}
	///<summary>Gets the fixed bounds for the system instance.</summary>
	public FBox GetSystemFixedBounds() { return default; }
	///<summary>Clear any previously set fixed bounds for the system instance.</summary>
	public void ClearSystemFixedBounds() {}
	///<summary>Sets the fixed bounds for an emitter instance, this overrides all other bounds.</summary>
	public void SetEmitterFixedBounds(string EmitterName,FBox LocalBounds) {}
	///<summary>Gets the fixed bounds for an emitter instance.</summary>
	public FBox GetEmitterFixedBounds(string EmitterName) { return default; }
	///<summary>Clear any previously set fixed bounds for the emitter instance.</summary>
	public void ClearEmitterFixedBounds(string EmitterName) {}
	///<summary>SetRandomSeedOffset</summary>
	public void SetRandomSeedOffset(int NewRandomSeedOffset) {}
	///<summary>GetRandomSeedOffset</summary>
	public int GetRandomSeedOffset() { return default; }
	///<summary>Sets a Niagara FLinearColor parameter by name, overriding locally if necessary.</summary>
	public void SetNiagaraVariableLinearColor(string InVariableName,FLinearColor InValue) {}
	///<summary>Sets a Niagara FLinearColor parameter by name, overriding locally if necessary.</summary>
	public void SetVariableLinearColor(string InVariableName,FLinearColor InValue) {}
	///<summary>Sets a Niagara Vector4 parameter by name, overriding locally if necessary.</summary>
	public void SetNiagaraVariableVec4(string InVariableName,FVector4 InValue) {}
	///<summary>Sets a Niagara Vector4 parameter by name, overriding locally if necessary.</summary>
	public void SetVariableVec4(string InVariableName,FVector4 InValue) {}
	///<summary>Sets a Niagara quaternion parameter by name, overriding locally if necessary.</summary>
	public void SetNiagaraVariableQuat(string InVariableName,FQuat InValue) {}
	///<summary>Sets a Niagara quaternion parameter by name, overriding locally if necessary.</summary>
	public void SetVariableQuat(string InVariableName,FQuat InValue) {}
	///<summary>Sets a Niagara matrix parameter by name, overriding locally if necessary.</summary>
	public void SetNiagaraVariableMatrix(string InVariableName,FMatrix InValue) {}
	///<summary>Sets a Niagara matrix parameter by name, overriding locally if necessary.</summary>
	public void SetVariableMatrix(string InVariableName,FMatrix InValue) {}
	///<summary>Sets a Niagara Vector3 parameter by name, overriding locally if necessary.</summary>
	public void SetNiagaraVariableVec3(string InVariableName,FVector InValue) {}
	///<summary>Sets a Niagara Vector3 parameter by name, overriding locally if necessary.</summary>
	public void SetVariableVec3(string InVariableName,FVector InValue) {}
	///<summary>Sets a Niagara Position parameter by name, overriding locally if necessary.</summary>
	public void SetNiagaraVariablePosition(string InVariableName,FVector InValue) {}
	///<summary>Sets a Niagara Position parameter by name, overriding locally if necessary.</summary>
	public void SetVariablePosition(string InVariableName,FVector InValue) {}
	///<summary>Sets a Niagara Vector2 parameter by name, overriding locally if necessary.</summary>
	public void SetNiagaraVariableVec2(string InVariableName,FVector2D InValue) {}
	///<summary>Sets a Niagara Vector2 parameter by name, overriding locally if necessary.</summary>
	public void SetVariableVec2(string InVariableName,FVector2D InValue) {}
	///<summary>Sets a Niagara float parameter by name, overriding locally if necessary.</summary>
	public void SetNiagaraVariableFloat(string InVariableName,float InValue) {}
	///<summary>Sets a Niagara float parameter by name, overriding locally if necessary.</summary>
	public void SetVariableFloat(string InVariableName,float InValue) {}
	///<summary>Sets a Niagara int parameter by name, overriding locally if necessary.</summary>
	public void SetNiagaraVariableInt(string InVariableName,int InValue) {}
	///<summary>Sets a Niagara int parameter by name, overriding locally if necessary.</summary>
	public void SetVariableInt(string InVariableName,int InValue) {}
	///<summary>Sets a Niagara bool parameter by name, overriding locally if necessary.</summary>
	public void SetNiagaraVariableBool(string InVariableName,bool InValue) {}
	///<summary>Sets a Niagara bool parameter by name, overriding locally if necessary.</summary>
	public void SetVariableBool(string InVariableName,bool InValue) {}
	///<summary>SetNiagaraVariableActor</summary>
	public void SetNiagaraVariableActor(string InVariableName,AActor Actor) {}
	///<summary>SetVariableActor</summary>
	public void SetVariableActor(string InVariableName,AActor Actor) {}
	///<summary>SetNiagaraVariableObject</summary>
	public void SetNiagaraVariableObject(string InVariableName,UObject Object) {}
	///<summary>SetVariableObject</summary>
	public void SetVariableObject(string InVariableName,UObject Object) {}
	///<summary>SetVariableMaterial</summary>
	public void SetVariableMaterial(string InVariableName,UMaterialInterface Object) {}
	///<summary>SetVariableStaticMesh</summary>
	public void SetVariableStaticMesh(string InVariableName,UStaticMesh InValue) {}
	///<summary>SetVariableTexture</summary>
	public void SetVariableTexture(string InVariableName,UTexture Texture) {}
	///<summary>SetVariableTextureRenderTarget</summary>
	public void SetVariableTextureRenderTarget(string InVariableName,UTextureRenderTarget TextureRenderTarget) {}
	///<summary>Debug accessors for getting positions in blueprints.</summary>
	public TArray<FVector> GetNiagaraParticlePositions_DebugOnly(string InEmitterName) { return default; }
	///<summary>Debug accessors for getting a float attribute array in blueprints.  The attribute name should be without namespaces. For example for &quot;Particles.Position&quot;, send &quot;Position&quot;.</summary>
	public TArray<float> GetNiagaraParticleValues_DebugOnly(string InEmitterName,string InValueName) { return default; }
	///<summary>Debug accessors for getting a FVector attribute array in blueprints. The attribute name should be without namespaces. For example for &quot;Particles.Position&quot;, send &quot;Position&quot;.</summary>
	public TArray<FVector> GetNiagaraParticleValueVec3_DebugOnly(string InEmitterName,string InValueName) { return default; }
	///<summary>Resets the System to it&#39;s initial pre-simulated state.</summary>
	public void ResetSystem() {}
	///<summary>Called on when an external object wishes to force this System to reinitialize itself from the System data.</summary>
	public void ReinitializeSystem() {}
	///<summary>Sets whether or not rendering is enabled for this component.</summary>
	public void SetRenderingEnabled(bool bInRenderingEnabled) {}
	///<summary>Advances this system&#39;s simulation by the specified number of ticks and delta time.</summary>
	public void AdvanceSimulation(int TickCount,float TickDeltaSeconds) {}
	///<summary>Advances this system&#39;s simulation by the specified time in seconds and delta time. Advancement is done in whole ticks of TickDeltaSeconds so actual simulated time will be the nearest lower multiple of TickDeltaSeconds.</summary>
	public void AdvanceSimulationByTime(float SimulateTime,float TickDeltaSeconds) {}
	///<summary>SetPaused</summary>
	public void SetPaused(bool bInPaused) {}
	///<summary>IsPaused</summary>
	public bool IsPaused() { return default; }
	///<summary>GetDataInterface</summary>
	public UNiagaraDataInterface GetDataInterface(string Name) { return default; }
	///<summary>SetPreviewLODDistance</summary>
	public void SetPreviewLODDistance(bool bEnablePreviewLODDistance,float PreviewLODDistance,float PreviewMaxDistance) {}
	///<summary>GetPreviewLODDistanceEnabled</summary>
	public bool GetPreviewLODDistanceEnabled() { return default; }
	///<summary>GetPreviewLODDistance</summary>
	public float GetPreviewLODDistance() { return default; }
	///<summary>Initializes this component for capturing a performance baseline.</summary>
	public void InitForPerformanceBaseline() {}
	///<summary>Called when the particle system is done</summary>
	public FOnNiagaraSystemFinished OnSystemFinished;
	///<summary>Component we automatically attach to when activated, if bAutoManageAttachment is true.</summary>
	public TWeakObjectPtr<USceneComponent> AutoAttachParent;
	///<summary>Socket we automatically attach to on the AutoAttachParent, if bAutoManageAttachment is true.</summary>
	public string AutoAttachSocketName;
	///<summary>Options for how we handle our location when we attach to the AutoAttachParent, if bAutoManageAttachment is true.</summary>
	public EAttachmentRule AutoAttachLocationRule;
	///<summary>Options for how we handle our rotation when we attach to the AutoAttachParent, if bAutoManageAttachment is true.</summary>
	public EAttachmentRule AutoAttachRotationRule;
	///<summary>Options for how we handle our scale when we attach to the AutoAttachParent, if bAutoManageAttachment is true.</summary>
	public EAttachmentRule AutoAttachScaleRule;
	///<summary>bWaitForCompilationOnActivate</summary>
	public bool bWaitForCompilationOnActivate;
	///<summary>Sets the simulation cache to use for the component.</summary>
	public void SetSimCache(UNiagaraSimCache SimCache,bool bResetSystem/*=false*/) {}
	///<summary>Get the active simulation cache, will return null if we do not have an active one.</summary>
	public UNiagaraSimCache GetSimCache() { return default; }
	///<summary>Clear any active simulation cache.</summary>
	public void ClearSimCache(bool bResetSystem/*=false*/) {}
	///<summary>Set whether this component is allowed to perform scalability checks and potentially be culled etc. Occasionally it is useful to disable this for specific components. E.g. Effects on the local player.</summary>
	public void SetAllowScalability(bool bAllow) {}
	///<summary>GetAllowScalability</summary>
	public bool GetAllowScalability() { return default; }
	///<summary>SetForceLocalPlayerEffect</summary>
	public void SetForceLocalPlayerEffect(bool bIsPlayerEffect) {}
	///<summary>GetForceLocalPlayerEffect</summary>
	public bool GetForceLocalPlayerEffect() { return default; }
	///<summary>Controls whether we allow scalability culling for this component. If enabled, this component&#39;s FX may be culled due to things such as distance, visibility, instance counts and performance.</summary>
	public bool bAllowScalability;
	///<summary>SimCache</summary>
	public UNiagaraSimCache SimCache;
	///<summary>CullProxy</summary>
	public UNiagaraCullProxyComponent CullProxy;
}
