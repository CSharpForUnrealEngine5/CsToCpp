#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/PrimitiveComponent.h")]
///<summary>PrimitiveComponents are SceneComponents that contain or generate some sort of geometry, generally to be rendered or used as collision data.</summary>
public partial class UPrimitiveComponent : USceneComponent {
// PrimitiveComponent
	public float MinDrawDistance;
	public float LDMaxDrawDistance;
	public float CachedMaxDrawDistance;
	public ESceneDepthPriorityGroup DepthPriorityGroup;
	public ESceneDepthPriorityGroup ViewOwnerDepthPriorityGroup;
	public EIndirectLightingCacheQuality IndirectLightingCacheQuality;
	public ELightmapType LightmapType;
	public EHLODBatchingPolicy HLODBatchingPolicy;
	public bool bEnableAutoLODGeneration;
	public bool bIsActorTextureStreamingBuiltData;
	public bool bIsValidTextureStreamingBuiltData;
	public bool bNeverDistanceCull;
	public bool bAlwaysCreatePhysicsState;
	public  bool GetGenerateOverlapEvents() { return default; }
	public  void SetGenerateOverlapEvents(bool bInGenerateOverlapEvents) {}
	public  void SetLightingChannels(bool bChannel0,bool bChannel1,bool bChannel2) {}
	public  void InvalidateLumenSurfaceCache() {}
	public bool bGenerateOverlapEvents;
	public bool bMultiBodyOverlap;
	public bool bTraceComplexOnMove;
	public bool bReturnMaterialOnMove;
	public bool bUseViewOwnerDepthPriorityGroup;
	public bool bAllowCullDistanceVolume;
	public bool bVisibleInReflectionCaptures;
	public bool bVisibleInRealTimeSkyCaptures;
	public bool bVisibleInRayTracing;
	public bool bRenderInMainPass;
	public bool bRenderInDepthPass;
	public bool bReceivesDecals;
	public bool bHoldout;
	public bool bOwnerNoSee;
	public bool bOnlyOwnerSee;
	public bool bTreatAsBackgroundForOcclusion;
	public bool bUseAsOccluder;
	public bool bSelectable;
	public bool bConsiderForActorPlacementWhenHidden;
	public bool bForceMipStreaming;
	public bool bHasPerInstanceHitProxies;
	public bool CastShadow;
	public bool bEmissiveLightSource;
	public bool bAffectDynamicIndirectLighting;
	public bool bAffectIndirectLightingWhileHidden;
	public bool bAffectDistanceFieldLighting;
	public bool bCastDynamicShadow;
	public bool bCastStaticShadow;
	public bool bCastVolumetricTranslucentShadow;
	public bool bCastContactShadow;
	public bool bSelfShadowOnly;
	public bool bCastFarShadow;
	public bool bCastInsetShadow;
	public bool bCastCinematicShadow;
	public bool bCastHiddenShadow;
	public bool bCastShadowAsTwoSided;
	public bool bLightAsIfStatic_DEPRECATED;
	public bool bLightAttachmentsAsGroup;
	public bool bExcludeFromLightAttachmentGroup;
	public bool bReceiveMobileCSMShadows;
	public bool bSingleSampleShadowFromStationaryLights;
	public bool bIgnoreRadialImpulse;
	public bool bIgnoreRadialForce;
	public bool bApplyImpulseOnDamage;
	public bool bReplicatePhysicsToAutonomousProxy;
	public bool bFillCollisionUnderneathForNavmesh;
	public bool AlwaysLoadOnClient;
	public bool AlwaysLoadOnServer;
	public bool bUseEditorCompositing;
	public bool bIsBeingMovedByEditor;
	public bool bRenderCustomDepth;
	public bool bVisibleInSceneCaptureOnly;
	public bool bHiddenInSceneCapture;
	public bool bRayTracingFarField;
	public bool bHasNoStreamableTextures;
	public bool bStaticWhenNotMoveable;
	public EHasCustomNavigableGeometry bHasCustomNavigableGeometry;
	public EHitProxyPriority HitProxyPriority;
	public TArray<int> ExcludeForSpecificHLODLevels_DEPRECATED;
	public  bool IsExcludedFromHLODLevel(EHLODLevelExclusion HLODLevel) { return default; }
	public  void SetExcludedFromHLODLevel(EHLODLevelExclusion HLODLevel,bool bExcluded) {}
	public  void SetExcludeForSpecificHLODLevels(TArray<int> InExcludeForSpecificHLODLevels) {}
	public  TArray<int> GetExcludeForSpecificHLODLevels() { return default; }
	public ECanBeCharacterBase CanBeCharacterBase_DEPRECATED;
	public bool bUseMaxLODAsImposter_DEPRECATED;
	public bool bBatchImpostersAsInstances_DEPRECATED;
	public ECanBeCharacterBase CanCharacterStepUpOn;
	public FLightingChannels LightingChannels;
	public int RayTracingGroupId;
	public int VisibilityId;
	public int CustomDepthStencilValue;
	public FCustomPrimitiveData CustomPrimitiveData;
	public FCustomPrimitiveData CustomPrimitiveDataInternal;
	public int TranslucencySortPriority;
	public float TranslucencySortDistanceOffset;
	public TArray<URuntimeVirtualTexture> RuntimeVirtualTextures;
	public short VirtualTextureLodBias;
	public short VirtualTextureCullMips;
	public short VirtualTextureMinCoverage;
	public ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType;
	public float BoundsScale;
	public  bool WasRecentlyRendered(float Tolerance/*=0.2f*/) { return default; }
	public TArray<AActor> MoveIgnoreActors;
	public  void IgnoreActorWhenMoving(AActor Actor,bool bShouldIgnore) {}
	public  TArray<AActor> CopyArrayOfMoveIgnoreActors() { return default; }
	public  void ClearMoveIgnoreActors() {}
	public TArray<UPrimitiveComponent> MoveIgnoreComponents;
	public  void IgnoreComponentWhenMoving(UPrimitiveComponent Component,bool bShouldIgnore) {}
	public  TArray<UPrimitiveComponent> CopyArrayOfMoveIgnoreComponents() { return default; }
	public  void ClearMoveIgnoreComponents() {}
	public  int GetCustomPrimitiveDataIndexForScalarParameter(string ParameterName) { return default; }
	public  int GetCustomPrimitiveDataIndexForVectorParameter(string ParameterName) { return default; }
	public  void SetScalarParameterForCustomPrimitiveData(string ParameterName,float Value) {}
	public  void SetVectorParameterForCustomPrimitiveData(string ParameterName,FVector4 Value) {}
	public  void SetCustomPrimitiveDataFloat(int DataIndex,float Value) {}
	public  void SetCustomPrimitiveDataVector2(int DataIndex,FVector2D Value) {}
	public  void SetCustomPrimitiveDataVector3(int DataIndex,FVector Value) {}
	public  void SetCustomPrimitiveDataVector4(int DataIndex,FVector4 Value) {}
	public  void SetScalarParameterForDefaultCustomPrimitiveData(string ParameterName,float Value) {}
	public  void SetVectorParameterForDefaultCustomPrimitiveData(string ParameterName,FVector4 Value) {}
	public  void SetDefaultCustomPrimitiveDataFloat(int DataIndex,float Value) {}
	public  void SetDefaultCustomPrimitiveDataVector2(int DataIndex,FVector2D Value) {}
	public  void SetDefaultCustomPrimitiveDataVector3(int DataIndex,FVector Value) {}
	public  void SetDefaultCustomPrimitiveDataVector4(int DataIndex,FVector4 Value) {}
	public  bool IsOverlappingComponent(UPrimitiveComponent OtherComp) { return default; }
	public  bool IsOverlappingActor(AActor Other) { return default; }
	public  void GetOverlappingActors(TArray<AActor> OverlappingActors,UClass ClassFilter/*=nullptr*/) {}
	public  void GetOverlappingComponents(TArray<UPrimitiveComponent> OutOverlappingComponents) {}
	public FBodyInstance BodyInstance;
	public FComponentHitSignature OnComponentHit;
	public FComponentBeginOverlapSignature OnComponentBeginOverlap;
	public FComponentEndOverlapSignature OnComponentEndOverlap;
	public FComponentWakeSignature OnComponentWake;
	public FComponentSleepSignature OnComponentSleep;
	public FComponentPhysicsStateChanged OnComponentPhysicsStateChanged;
	public FComponentBeginCursorOverSignature OnBeginCursorOver;
	public FComponentEndCursorOverSignature OnEndCursorOver;
	public FComponentOnClickedSignature OnClicked;
	public FComponentOnReleasedSignature OnReleased;
	public FComponentOnInputTouchBeginSignature OnInputTouchBegin;
	public FComponentOnInputTouchEndSignature OnInputTouchEnd;
	public FComponentBeginTouchOverSignature OnInputTouchEnter;
	public FComponentEndTouchOverSignature OnInputTouchLeave;
	public ERayTracingGroupCullingPriority RayTracingGroupCullingPriority;
	public ERendererStencilMask CustomDepthStencilWriteMask;
	public  void SetBoundsScale(float NewBoundsScale/*=1.0f*/) {}
	public  UMaterialInterface GetMaterial(int ElementIndex) { return default; }
	public  void SetMaterial(int ElementIndex,UMaterialInterface Material) {}
	public  void SetMaterialByName(string MaterialSlotName,UMaterialInterface Material) {}
	public  UMaterialInstanceDynamic CreateAndSetMaterialInstanceDynamic(int ElementIndex) { return default; }
	public  UMaterialInstanceDynamic CreateAndSetMaterialInstanceDynamicFromMaterial(int ElementIndex,UMaterialInterface Parent) { return default; }
	public  UMaterialInstanceDynamic CreateDynamicMaterialInstance(int ElementIndex,UMaterialInterface SourceMaterial/*=NULL*/,string OptionalName/*=NAME_None*/) { return default; }
	public  UMaterialInterface GetMaterialFromCollisionFaceIndex(int FaceIndex,int SectionIndex) { return default; }
	public  FWalkableSlopeOverride GetWalkableSlopeOverride() { return default; }
	public  void SetWalkableSlopeOverride(FWalkableSlopeOverride NewOverride) {}
	public  void SetSimulatePhysics(bool bSimulate) {}
	public  void SetStaticWhenNotMoveable(bool bInStaticWhenNotMoveable) {}
	public  bool GetStaticWhenNotMoveable() { return default; }
	public  void SetConstraintMode(EDOFMode ConstraintMode) {}
	public  void AddImpulse(FVector Impulse,string BoneName/*=NAME_None*/,bool bVelChange/*=false*/) {}
	public  void AddAngularImpulseInRadians(FVector Impulse,string BoneName/*=NAME_None*/,bool bVelChange/*=false*/) {}
	public  void AddAngularImpulseInDegrees(FVector Impulse,string BoneName/*=NAME_None*/,bool bVelChange/*=false*/) {}
	public  void AddImpulseAtLocation(FVector Impulse,FVector Location,string BoneName/*=NAME_None*/) {}
	public  void AddVelocityChangeImpulseAtLocation(FVector Impulse,FVector Location,string BoneName/*=NAME_None*/) {}
	public  void AddRadialImpulse(FVector Origin,float Radius,float Strength,ERadialImpulseFalloff Falloff,bool bVelChange/*=false*/) {}
	public  void AddForce(FVector Force,string BoneName/*=NAME_None*/,bool bAccelChange/*=false*/) {}
	public  void AddForceAtLocation(FVector Force,FVector Location,string BoneName/*=NAME_None*/) {}
	public  void AddForceAtLocationLocal(FVector Force,FVector Location,string BoneName/*=NAME_None*/) {}
	public  void AddRadialForce(FVector Origin,float Radius,float Strength,ERadialImpulseFalloff Falloff,bool bAccelChange/*=false*/) {}
	public  void AddTorqueInRadians(FVector Torque,string BoneName/*=NAME_None*/,bool bAccelChange/*=false*/) {}
	public  void AddTorqueInDegrees(FVector Torque,string BoneName/*=NAME_None*/,bool bAccelChange/*=false*/) {}
	public  void SetPhysicsLinearVelocity(FVector NewVel,bool bAddToCurrent/*=false*/,string BoneName/*=NAME_None*/) {}
	public  FVector GetPhysicsLinearVelocity(string BoneName/*=NAME_None*/) { return default; }
	public  FVector GetPhysicsLinearVelocityAtPoint(FVector Point,string BoneName/*=NAME_None*/) { return default; }
	public  void SetAllPhysicsLinearVelocity(FVector NewVel,bool bAddToCurrent/*=false*/) {}
	public  void SetPhysicsAngularVelocityInRadians(FVector NewAngVel,bool bAddToCurrent/*=false*/,string BoneName/*=NAME_None*/) {}
	public  void SetPhysicsAngularVelocityInDegrees(FVector NewAngVel,bool bAddToCurrent/*=false*/,string BoneName/*=NAME_None*/) {}
	public  void SetPhysicsMaxAngularVelocityInDegrees(float NewMaxAngVel,bool bAddToCurrent/*=false*/,string BoneName/*=NAME_None*/) {}
	public  void SetPhysicsMaxAngularVelocityInRadians(float NewMaxAngVel,bool bAddToCurrent/*=false*/,string BoneName/*=NAME_None*/) {}
	public  FVector GetPhysicsAngularVelocityInDegrees(string BoneName/*=NAME_None*/) { return default; }
	public  FVector GetPhysicsAngularVelocityInRadians(string BoneName/*=NAME_None*/) { return default; }
	public  FVector GetCenterOfMass(string BoneName/*=NAME_None*/) { return default; }
	public  void SetCenterOfMass(FVector CenterOfMassOffset,string BoneName/*=NAME_None*/) {}
	public  void WakeRigidBody(string BoneName/*=NAME_None*/) {}
	public  void PutRigidBodyToSleep(string BoneName/*=NAME_None*/) {}
	public  void SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision) {}
	public  void SetOwnerNoSee(bool bNewOwnerNoSee) {}
	public  void SetOnlyOwnerSee(bool bNewOnlyOwnerSee) {}
	public  void SetVisibleInRayTracing(bool bNewVisibleInRayTracing) {}
	public  void SetCastShadow(bool NewCastShadow) {}
	public  void SetEmissiveLightSource(bool NewEmissiveLightSource) {}
	public  void SetCastHiddenShadow(bool NewCastHiddenShadow) {}
	public  void SetCastInsetShadow(bool bInCastInsetShadow) {}
	public  void SetCastContactShadow(bool bInCastContactShadow) {}
	public  void SetLightAttachmentsAsGroup(bool bInLightAttachmentsAsGroup) {}
	public  void SetExcludeFromLightAttachmentGroup(bool bInExcludeFromLightAttachmentGroup) {}
	public  void SetSingleSampleShadowFromStationaryLights(bool bNewSingleSampleShadowFromStationaryLights) {}
	public  void SetTranslucentSortPriority(int NewTranslucentSortPriority) {}
	public  void SetTranslucencySortDistanceOffset(float NewTranslucencySortDistanceOffset) {}
	public  void SetAffectDistanceFieldLighting(bool NewAffectDistanceFieldLighting) {}
	public  void SetReceivesDecals(bool bNewReceivesDecals) {}
	public  void SetHoldout(bool bNewHoldout) {}
	public  void SetAffectDynamicIndirectLighting(bool bNewAffectDynamicIndirectLighting) {}
	public  void SetAffectIndirectLightingWhileHidden(bool bNewAffectIndirectLightingWhileHidden) {}
	public  void SetCollisionEnabled(ECollisionEnabled NewType) {}
	public  void SetCollisionProfileName(string InCollisionProfileName,bool bUpdateOverlaps/*=true*/) {}
	public  string GetCollisionProfileName() { return default; }
	public  void SetCollisionObjectType(ECollisionChannel Channel) {}
	public  bool K2_LineTraceComponent(FVector TraceStart,FVector TraceEnd,bool bTraceComplex,bool bShowTrace,bool bPersistentShowTrace,FVector HitLocation,FVector HitNormal,string BoneName,FHitResult OutHit) { return default; }
	public  bool K2_SphereTraceComponent(FVector TraceStart,FVector TraceEnd,float SphereRadius,bool bTraceComplex,bool bShowTrace,bool bPersistentShowTrace,FVector HitLocation,FVector HitNormal,string BoneName,FHitResult OutHit) { return default; }
	public  bool K2_BoxOverlapComponent(FVector InBoxCentre,FBox InBox,bool bTraceComplex,bool bShowTrace,bool bPersistentShowTrace,FVector HitLocation,FVector HitNormal,string BoneName,FHitResult OutHit) { return default; }
	public  bool K2_SphereOverlapComponent(FVector InSphereCentre,float InSphereRadius,bool bTraceComplex,bool bShowTrace,bool bPersistentShowTrace,FVector HitLocation,FVector HitNormal,string BoneName,FHitResult OutHit) { return default; }
	public  void SetRenderCustomDepth(bool bValue) {}
	public  void SetCustomDepthStencilValue(int Value) {}
	public  void SetCustomDepthStencilWriteMask(ERendererStencilMask WriteMaskBit) {}
	public  void SetRenderInMainPass(bool bValue) {}
	public  void SetRenderInDepthPass(bool bValue) {}
	public  void SetVisibleInSceneCaptureOnly(bool bValue) {}
	public  void SetHiddenInSceneCapture(bool bValue) {}
	public byte ExcludeFromHLODLevels;
	public UPrimitiveComponent LODParentPrimitive;
	public  int GetNumMaterials() { return default; }
	public  FBodyInstanceAsyncPhysicsTickHandle GetBodyInstanceAsyncPhysicsTickHandle(string BoneName/*=NAME_None*/,bool bGetWelded/*=true*/,int Index/*=-1*/) { return default; }
	public  float GetClosestPointOnCollision(FVector Point,FVector OutPointOnBody,string BoneName/*=NAME_None*/) { return default; }
	public  ECollisionEnabled GetCollisionEnabled() { return default; }
	public  bool K2_IsCollisionEnabled() { return default; }
	public  bool K2_IsQueryCollisionEnabled() { return default; }
	public  bool K2_IsPhysicsCollisionEnabled() { return default; }
	public  ECollisionResponse GetCollisionResponseToChannel(ECollisionChannel Channel) { return default; }
	public  ECollisionChannel GetCollisionObjectType() { return default; }
	public  void SetAllPhysicsAngularVelocityInDegrees(FVector NewAngVel,bool bAddToCurrent/*=false*/) {}
	public  void SetAllPhysicsAngularVelocityInRadians(FVector NewAngVel,bool bAddToCurrent/*=false*/) {}
	public  void WakeAllRigidBodies() {}
	public  void SetEnableGravity(bool bGravityEnabled) {}
	public  bool IsGravityEnabled() { return default; }
	public  void SetLinearDamping(float InDamping) {}
	public  float GetLinearDamping() { return default; }
	public  void SetAngularDamping(float InDamping) {}
	public  float GetAngularDamping() { return default; }
	public  void SetMassScale(string BoneName/*=NAME_None*/,float InMassScale/*=1.0f*/) {}
	public  float GetMassScale(string BoneName/*=NAME_None*/) { return default; }
	public  void SetAllMassScale(float InMassScale/*=1.0f*/) {}
	public  void SetMassOverrideInKg(string BoneName/*=NAME_None*/,float MassInKg/*=1.0f*/,bool bOverrideMass/*=true*/) {}
	public  float GetMass() { return default; }
	public  FVector GetInertiaTensor(string BoneName/*=NAME_None*/) { return default; }
	public  FVector ScaleByMomentOfInertia(FVector InputVector,string BoneName/*=NAME_None*/) { return default; }
	public  void SetUseCCD(bool InUseCCD,string BoneName/*=NAME_None*/) {}
	public  void SetAllUseCCD(bool InUseCCD) {}
	public  bool IsAnyRigidBodyAwake() { return default; }
	public  void SetCollisionResponseToChannel(ECollisionChannel Channel,ECollisionResponse NewResponse) {}
	public  void SetCollisionResponseToAllChannels(ECollisionResponse NewResponse) {}
	public  void SetPhysMaterialOverride(UPhysicalMaterial NewPhysMaterial) {}
	public  void SetCullDistance(float NewCullDistance) {}
	public  bool CanCharacterStepUp(APawn Pawn) { return default; }
}
