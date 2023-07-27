#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraComponent.h")]
///<summary>UNiagaraComponent is the primitive component for a Niagara System.</summary>
public partial class UNiagaraComponent : UFXSystemComponent {
// NiagaraComponent
	public UNiagaraSystem Asset;
	public ENiagaraTickBehavior TickBehavior;
	public int RandomSeedOffset;
	public FNiagaraUserRedirectionParameterStore OverrideParameters;
	public TMap<string,bool> EditorOverridesValue_DEPRECATED;
	public TMap<FNiagaraVariableBase,FNiagaraVariant> TemplateParameterOverrides;
	public TMap<FNiagaraVariableBase,FNiagaraVariant> InstanceParameterOverrides;
	public bool bForceSolo;
	public bool bEnableGpuComputeDebug;
	public bool bOverrideWarmupSettings;
	public int WarmupTickCount;
	public float WarmupTickDelta;
	public bool bAutoDestroy;
	public bool bRenderingEnabled;
	public bool bAutoManageAttachment;
	public bool bAutoAttachWeldSimulatedBodies;
	public float MaxTimeBeforeForceUpdateTransform;
	public  void SetAsset(UNiagaraSystem InAsset,bool bResetExistingOverrideParameters/*=true*/) {}
	public  UNiagaraSystem GetAsset() { return default; }
	public  void SetForceSolo(bool bInForceSolo) {}
	public  bool GetForceSolo() { return default; }
	public  void SetGpuComputeDebug(bool bEnableDebug) {}
	public  void SetCustomTimeDilation(float Dilation/*=1.0f*/) {}
	public  float GetCustomTimeDilation() { return default; }
	public  ENiagaraAgeUpdateMode GetAgeUpdateMode() { return default; }
	public  void SetAgeUpdateMode(ENiagaraAgeUpdateMode InAgeUpdateMode) {}
	public  float GetDesiredAge() { return default; }
	public  void SetDesiredAge(float InDesiredAge) {}
	public  void SeekToDesiredAge(float InDesiredAge) {}
	public  void SetCanRenderWhileSeeking(bool bInCanRenderWhileSeeking) {}
	public  float GetSeekDelta() { return default; }
	public  void SetSeekDelta(float InSeekDelta) {}
	public  bool GetLockDesiredAgeDeltaTimeToSeekDelta() { return default; }
	public  void SetLockDesiredAgeDeltaTimeToSeekDelta(bool bLock) {}
	public  float GetMaxSimTime() { return default; }
	public  void SetMaxSimTime(float InMaxTime) {}
	public  void SetAutoDestroy(bool bInAutoDestroy) {}
	public  void SetTickBehavior(ENiagaraTickBehavior NewTickBehavior) {}
	public  ENiagaraTickBehavior GetTickBehavior() { return default; }
	public  void SetSystemFixedBounds(FBox LocalBounds) {}
	public  FBox GetSystemFixedBounds() { return default; }
	public  void ClearSystemFixedBounds() {}
	public  void SetEmitterFixedBounds(string EmitterName,FBox LocalBounds) {}
	public  FBox GetEmitterFixedBounds(string EmitterName) { return default; }
	public  void ClearEmitterFixedBounds(string EmitterName) {}
	public  void SetRandomSeedOffset(int NewRandomSeedOffset) {}
	public  int GetRandomSeedOffset() { return default; }
	public  void SetNiagaraVariableLinearColor(string InVariableName,FLinearColor InValue) {}
	public  void SetVariableLinearColor(string InVariableName,FLinearColor InValue) {}
	public  void SetNiagaraVariableVec4(string InVariableName,FVector4 InValue) {}
	public  void SetVariableVec4(string InVariableName,FVector4 InValue) {}
	public  void SetNiagaraVariableQuat(string InVariableName,FQuat InValue) {}
	public  void SetVariableQuat(string InVariableName,FQuat InValue) {}
	public  void SetNiagaraVariableMatrix(string InVariableName,FMatrix InValue) {}
	public  void SetVariableMatrix(string InVariableName,FMatrix InValue) {}
	public  void SetNiagaraVariableVec3(string InVariableName,FVector InValue) {}
	public  void SetVariableVec3(string InVariableName,FVector InValue) {}
	public  void SetNiagaraVariablePosition(string InVariableName,FVector InValue) {}
	public  void SetVariablePosition(string InVariableName,FVector InValue) {}
	public  void SetNiagaraVariableVec2(string InVariableName,FVector2D InValue) {}
	public  void SetVariableVec2(string InVariableName,FVector2D InValue) {}
	public  void SetNiagaraVariableFloat(string InVariableName,float InValue) {}
	public  void SetVariableFloat(string InVariableName,float InValue) {}
	public  void SetNiagaraVariableInt(string InVariableName,int InValue) {}
	public  void SetVariableInt(string InVariableName,int InValue) {}
	public  void SetNiagaraVariableBool(string InVariableName,bool InValue) {}
	public  void SetVariableBool(string InVariableName,bool InValue) {}
	public  void SetNiagaraVariableActor(string InVariableName,AActor Actor) {}
	public  void SetVariableActor(string InVariableName,AActor Actor) {}
	public  void SetNiagaraVariableObject(string InVariableName,UObject Object) {}
	public  void SetVariableObject(string InVariableName,UObject Object) {}
	public  void SetVariableMaterial(string InVariableName,UMaterialInterface Object) {}
	public  void SetVariableStaticMesh(string InVariableName,UStaticMesh InValue) {}
	public  void SetVariableTexture(string InVariableName,UTexture Texture) {}
	public  void SetVariableTextureRenderTarget(string InVariableName,UTextureRenderTarget TextureRenderTarget) {}
	public  TArray<FVector> GetNiagaraParticlePositions_DebugOnly(string InEmitterName) { return default; }
	public  TArray<float> GetNiagaraParticleValues_DebugOnly(string InEmitterName,string InValueName) { return default; }
	public  TArray<FVector> GetNiagaraParticleValueVec3_DebugOnly(string InEmitterName,string InValueName) { return default; }
	public  void ResetSystem() {}
	public  void ReinitializeSystem() {}
	public  void SetRenderingEnabled(bool bInRenderingEnabled) {}
	public  void AdvanceSimulation(int TickCount,float TickDeltaSeconds) {}
	public  void AdvanceSimulationByTime(float SimulateTime,float TickDeltaSeconds) {}
	public  void SetPaused(bool bInPaused) {}
	public  bool IsPaused() { return default; }
	public  UNiagaraDataInterface GetDataInterface(string Name) { return default; }
	public  void SetPreviewLODDistance(bool bEnablePreviewLODDistance,float PreviewLODDistance,float PreviewMaxDistance) {}
	public  bool GetPreviewLODDistanceEnabled() { return default; }
	public  float GetPreviewLODDistance() { return default; }
	public  void InitForPerformanceBaseline() {}
	public FOnNiagaraSystemFinished OnSystemFinished;
	public TWeakObjectPtr<USceneComponent> AutoAttachParent;
	public string AutoAttachSocketName;
	public EAttachmentRule AutoAttachLocationRule;
	public EAttachmentRule AutoAttachRotationRule;
	public EAttachmentRule AutoAttachScaleRule;
	public bool bWaitForCompilationOnActivate;
	public  void SetSimCache(UNiagaraSimCache SimCache,bool bResetSystem/*=false*/) {}
	public  UNiagaraSimCache GetSimCache() { return default; }
	public  void ClearSimCache(bool bResetSystem/*=false*/) {}
	public  void SetAllowScalability(bool bAllow) {}
	public  bool GetAllowScalability() { return default; }
	public  void SetForceLocalPlayerEffect(bool bIsPlayerEffect) {}
	public  bool GetForceLocalPlayerEffect() { return default; }
	public bool bAllowScalability;
	public UNiagaraSimCache SimCache;
	public UNiagaraCullProxyComponent CullProxy;
}
