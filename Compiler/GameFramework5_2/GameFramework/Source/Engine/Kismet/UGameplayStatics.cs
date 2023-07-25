#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/GameplayStatics.h")]
///<summary>Static class with useful gameplay utility functions that can be called from both Blueprint and C++</summary>
public partial class UGameplayStatics : UBlueprintFunctionLibrary {
// GameplayStatics
	public UObject SpawnObject(UClass ObjectClass,UObject Outer) { return default; }
	public UObject BeginSpawningActorFromBlueprint(UObject WorldContextObject,UObject Blueprint,FTransform SpawnTransform,bool bNoCollisionFail) { return default; }
	public UObject BeginDeferredActorSpawnFromClass(UObject WorldContextObject,UClass ActorClass,FTransform SpawnTransform,ESpawnActorCollisionHandlingMethod CollisionHandlingOverride/*=ESpawnActorCollisionHandlingMethod.Undefined*/,UObject Owner/*=nullptr*/,ESpawnActorScaleMethod TransformScaleMethod/*=ESpawnActorScaleMethod.MultiplyWithRoot*/) { return default; }
	public UObject FinishSpawningActor(UObject Actor,FTransform SpawnTransform,ESpawnActorScaleMethod TransformScaleMethod/*=ESpawnActorScaleMethod.MultiplyWithRoot*/) { return default; }
	public FVector GetActorArrayAverageLocation(TArray<UObject> Actors) { return default; }
	public void GetActorArrayBounds(TArray<UObject> Actors,bool bOnlyCollidingComponents,FVector Center,FVector BoxExtent) {}
	public UObject GetActorOfClass(UObject WorldContextObject,UClass ActorClass) { return default; }
	public void GetAllActorsOfClass(UObject WorldContextObject,UClass ActorClass,TArray<UObject> OutActors) {}
	public void GetAllActorsWithInterface(UObject WorldContextObject,UClass Interface,TArray<UObject> OutActors) {}
	public void GetAllActorsWithTag(UObject WorldContextObject,string Tag,TArray<UObject> OutActors) {}
	public void GetAllActorsOfClassWithTag(UObject WorldContextObject,UClass ActorClass,string Tag,TArray<UObject> OutActors) {}
	public UObject FindNearestActor(FVector Origin,TArray<UObject> ActorsToCheck,float Distance) { return default; }
	public UObject GetGameInstance(UObject WorldContextObject) { return default; }
	public int GetNumPlayerStates(UObject WorldContextObject) { return default; }
	public UObject GetPlayerState(UObject WorldContextObject,int PlayerStateIndex) { return default; }
	public UObject GetPlayerStateFromUniqueNetId(UObject WorldContextObject,FUniqueNetIdRepl UniqueId) { return default; }
	public int GetNumPlayerControllers(UObject WorldContextObject) { return default; }
	public int GetNumLocalPlayerControllers(UObject WorldContextObject) { return default; }
	public UObject GetPlayerController(UObject WorldContextObject,int PlayerIndex) { return default; }
	public UObject GetPlayerPawn(UObject WorldContextObject,int PlayerIndex) { return default; }
	public UObject GetPlayerCharacter(UObject WorldContextObject,int PlayerIndex) { return default; }
	public UObject GetPlayerCameraManager(UObject WorldContextObject,int PlayerIndex) { return default; }
	public UObject GetPlayerControllerFromID(UObject WorldContextObject,int ControllerID) { return default; }
	public UObject GetPlayerControllerFromPlatformUser(UObject WorldContextObject,FPlatformUserId UserId) { return default; }
	public UObject CreatePlayer(UObject WorldContextObject,int ControllerId/*=-1*/,bool bSpawnPlayerController/*=true*/) { return default; }
	public UObject CreatePlayerFromPlatformUser(UObject WorldContextObject,FPlatformUserId UserId,bool bSpawnPlayerController/*=true*/) { return default; }
	public void RemovePlayer(UObject Player,bool bDestroyPawn) {}
	public int GetPlayerControllerID(UObject Player) { return default; }
	public void SetPlayerControllerID(UObject Player,int ControllerId) {}
	public void SetPlayerPlatformUserId(UObject PlayerController,FPlatformUserId UserId) {}
	public void LoadStreamLevel(UObject WorldContextObject,string LevelName,bool bMakeVisibleAfterLoad,bool bShouldBlockOnLoad,FLatentActionInfo LatentInfo) {}
	public void LoadStreamLevelBySoftObjectPtr(UObject WorldContextObject,TSoftObjectPtr<UWorld> Level,bool bMakeVisibleAfterLoad,bool bShouldBlockOnLoad,FLatentActionInfo LatentInfo) {}
	public void UnloadStreamLevel(UObject WorldContextObject,string LevelName,FLatentActionInfo LatentInfo,bool bShouldBlockOnUnload) {}
	public void UnloadStreamLevelBySoftObjectPtr(UObject WorldContextObject,TSoftObjectPtr<UWorld> Level,FLatentActionInfo LatentInfo,bool bShouldBlockOnUnload) {}
	public UObject GetStreamingLevel(UObject WorldContextObject,string PackageName) { return default; }
	public void FlushLevelStreaming(UObject WorldContextObject) {}
	public void CancelAsyncLoading() {}
	public void OpenLevel(UObject WorldContextObject,string LevelName,bool bAbsolute/*=true*/,string Options/*=new FString(TEXT(""))*/) {}
	public void OpenLevelBySoftObjectPtr(UObject WorldContextObject,TSoftObjectPtr<UWorld> Level,bool bAbsolute/*=true*/,string Options/*=new FString(TEXT(""))*/) {}
	public string GetCurrentLevelName(UObject WorldContextObject,bool bRemovePrefixString/*=true*/) { return default; }
	public UObject GetGameMode(UObject WorldContextObject) { return default; }
	public UObject GetGameState(UObject WorldContextObject) { return default; }
	public UClass GetObjectClass(UObject Object) { return default; }
	public bool ObjectIsA(UObject Object,UClass ObjectClass) { return default; }
	public float GetGlobalTimeDilation(UObject WorldContextObject) { return default; }
	public void SetGlobalTimeDilation(UObject WorldContextObject,float TimeDilation) {}
	public bool SetGamePaused(UObject WorldContextObject,bool bPaused) { return default; }
	public bool IsGamePaused(UObject WorldContextObject) { return default; }
	public void SetForceDisableSplitscreen(UObject WorldContextObject,bool bDisable) {}
	public bool IsSplitscreenForceDisabled(UObject WorldContextObject) { return default; }
	public void SetEnableWorldRendering(UObject WorldContextObject,bool bEnable) {}
	public bool GetEnableWorldRendering(UObject WorldContextObject) { return default; }
	public EMouseCaptureMode GetViewportMouseCaptureMode(UObject WorldContextObject) { return default; }
	public void SetViewportMouseCaptureMode(UObject WorldContextObject,EMouseCaptureMode MouseCaptureMode) {}
	public bool ApplyRadialDamage(UObject WorldContextObject,float BaseDamage,FVector Origin,float DamageRadius,UClass DamageTypeClass,TArray<UObject> IgnoreActors,UObject DamageCauser/*=NULL*/,UObject InstigatedByController/*=NULL*/,bool bDoFullDamage/*=false*/,ECollisionChannel DamagePreventionChannel/*=ECC_Visibility*/) { return default; }
	public bool ApplyRadialDamageWithFalloff(UObject WorldContextObject,float BaseDamage,float MinimumDamage,FVector Origin,float DamageInnerRadius,float DamageOuterRadius,float DamageFalloff,UClass DamageTypeClass,TArray<UObject> IgnoreActors,UObject DamageCauser/*=NULL*/,UObject InstigatedByController/*=NULL*/,ECollisionChannel DamagePreventionChannel/*=ECC_Visibility*/) { return default; }
	public float ApplyPointDamage(UObject DamagedActor,float BaseDamage,FVector HitFromDirection,FHitResult HitInfo,UObject EventInstigator,UObject DamageCauser,UClass DamageTypeClass) { return default; }
	public float ApplyDamage(UObject DamagedActor,float BaseDamage,UObject EventInstigator,UObject DamageCauser,UClass DamageTypeClass) { return default; }
	public void PlayWorldCameraShake(UObject WorldContextObject,UClass Shake,FVector Epicenter,float InnerRadius,float OuterRadius,float Falloff/*=1.0f*/,bool bOrientShakeTowardsEpicenter/*=false*/) {}
	public UObject SpawnEmitterAtLocation(UObject WorldContextObject,UObject EmitterTemplate,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,FVector Scale/*=new FVector(1.0f)*/,bool bAutoDestroy/*=true*/,EPSCPoolMethod PoolingMethod/*=EPSCPoolMethod.None*/,bool bAutoActivateSystem/*=true*/) { return default; }
	public UObject SpawnEmitterAttached(UObject EmitterTemplate,UObject AttachToComponent,string AttachPointName/*=NAME_None*/,FVector Location/*=new FVector(ForceInit)*/,FRotator Rotation/*=FRotator.ZeroRotator*/,FVector Scale/*=new FVector(1.0f)*/,EAttachLocation LocationType/*=EAttachLocation.KeepRelativeOffset*/,bool bAutoDestroy/*=true*/,EPSCPoolMethod PoolingMethod/*=EPSCPoolMethod.None*/,bool bAutoActivate/*=true*/) { return default; }
	public bool AreAnyListenersWithinRange(UObject WorldContextObject,FVector Location,float MaximumRange) { return default; }
	public bool GetClosestListenerLocation(UObject WorldContextObject,FVector Location,float MaximumRange,bool bAllowAttenuationOverride,FVector ListenerPosition) { return default; }
	public void SetGlobalPitchModulation(UObject WorldContextObject,float PitchModulation,float TimeSec) {}
	public void SetSoundClassDistanceScale(UObject WorldContextObject,UObject SoundClass,float DistanceAttenuationScale,float TimeSec/*=0.0f*/) {}
	public void SetGlobalListenerFocusParameters(UObject WorldContextObject,float FocusAzimuthScale/*=1.0f*/,float NonFocusAzimuthScale/*=1.0f*/,float FocusDistanceScale/*=1.0f*/,float NonFocusDistanceScale/*=1.0f*/,float FocusVolumeScale/*=1.0f*/,float NonFocusVolumeScale/*=1.0f*/,float FocusPriorityScale/*=1.0f*/,float NonFocusPriorityScale/*=1.0f*/) {}
	public void PlaySound2D(UObject WorldContextObject,UObject Sound,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,UObject ConcurrencySettings/*=nullptr*/,UObject OwningActor/*=nullptr*/,bool bIsUISound/*=true*/) {}
	public UObject SpawnSound2D(UObject WorldContextObject,UObject Sound,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,UObject ConcurrencySettings/*=nullptr*/,bool bPersistAcrossLevelTransition/*=false*/,bool bAutoDestroy/*=true*/) { return default; }
	public UObject CreateSound2D(UObject WorldContextObject,UObject Sound,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,UObject ConcurrencySettings/*=nullptr*/,bool bPersistAcrossLevelTransition/*=false*/,bool bAutoDestroy/*=true*/) { return default; }
	public void PlaySoundAtLocation(UObject WorldContextObject,UObject Sound,FVector Location,FRotator Rotation,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,UObject AttenuationSettings/*=nullptr*/,UObject ConcurrencySettings/*=nullptr*/,UObject OwningActor/*=nullptr*/,UObject InitialParams/*=nullptr*/) {}
	public UObject SpawnSoundAtLocation(UObject WorldContextObject,UObject Sound,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,UObject AttenuationSettings/*=nullptr*/,UObject ConcurrencySettings/*=nullptr*/,bool bAutoDestroy/*=true*/) { return default; }
	public UObject SpawnSoundAttached(UObject Sound,UObject AttachToComponent,string AttachPointName/*=NAME_None*/,FVector Location/*=new FVector(ForceInit)*/,FRotator Rotation/*=FRotator.ZeroRotator*/,EAttachLocation LocationType/*=EAttachLocation.KeepRelativeOffset*/,bool bStopWhenAttachedToDestroyed/*=false*/,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,UObject AttenuationSettings/*=nullptr*/,UObject ConcurrencySettings/*=nullptr*/,bool bAutoDestroy/*=true*/) { return default; }
	public void PlayDialogue2D(UObject WorldContextObject,UObject Dialogue,FDialogueContext Context,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/) {}
	public UObject SpawnDialogue2D(UObject WorldContextObject,UObject Dialogue,FDialogueContext Context,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,bool bAutoDestroy/*=true*/) { return default; }
	public void PlayDialogueAtLocation(UObject WorldContextObject,UObject Dialogue,FDialogueContext Context,FVector Location,FRotator Rotation,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,UObject AttenuationSettings/*=nullptr*/) {}
	public UObject SpawnDialogueAtLocation(UObject WorldContextObject,UObject Dialogue,FDialogueContext Context,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,UObject AttenuationSettings/*=nullptr*/,bool bAutoDestroy/*=true*/) { return default; }
	public UObject SpawnDialogueAttached(UObject Dialogue,FDialogueContext Context,UObject AttachToComponent,string AttachPointName/*=NAME_None*/,FVector Location/*=new FVector(ForceInit)*/,FRotator Rotation/*=FRotator.ZeroRotator*/,EAttachLocation LocationType/*=EAttachLocation.KeepRelativeOffset*/,bool bStopWhenAttachedToDestroyed/*=false*/,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,UObject AttenuationSettings/*=nullptr*/,bool bAutoDestroy/*=true*/) { return default; }
	public UObject SpawnForceFeedbackAtLocation(UObject WorldContextObject,UObject ForceFeedbackEffect,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,bool bLooping/*=false*/,float IntensityMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,UObject AttenuationSettings/*=nullptr*/,bool bAutoDestroy/*=true*/) { return default; }
	public UObject SpawnForceFeedbackAttached(UObject ForceFeedbackEffect,UObject AttachToComponent,string AttachPointName/*=NAME_None*/,FVector Location/*=new FVector(ForceInit)*/,FRotator Rotation/*=FRotator.ZeroRotator*/,EAttachLocation LocationType/*=EAttachLocation.KeepRelativeOffset*/,bool bStopWhenAttachedToDestroyed/*=false*/,bool bLooping/*=false*/,float IntensityMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,UObject AttenuationSettings/*=nullptr*/,bool bAutoDestroy/*=true*/) { return default; }
	public void SetSubtitlesEnabled(bool bEnabled) {}
	public bool AreSubtitlesEnabled() { return default; }
	public void SetBaseSoundMix(UObject WorldContextObject,UObject InSoundMix) {}
	public void PrimeSound(UObject InSound) {}
	public TArray<string> GetAvailableSpatialPluginNames(UObject WorldContextObject) { return default; }
	public string GetActiveSpatialPluginName(UObject WorldContextObject) { return default; }
	public bool SetActiveSpatialPluginByName(UObject WorldContextObject,string InPluginName) { return default; }
	public void PrimeAllSoundsInSoundClass(UObject InSoundClass) {}
	public void UnRetainAllSoundsInSoundClass(UObject InSoundClass) {}
	public void SetSoundMixClassOverride(UObject WorldContextObject,UObject InSoundMixModifier,UObject InSoundClass,float Volume/*=1.0f*/,float Pitch/*=1.0f*/,float FadeInTime/*=1.0f*/,bool bApplyToChildren/*=true*/) {}
	public void ClearSoundMixClassOverride(UObject WorldContextObject,UObject InSoundMixModifier,UObject InSoundClass,float FadeOutTime/*=1.0f*/) {}
	public void PushSoundMixModifier(UObject WorldContextObject,UObject InSoundMixModifier) {}
	public void PopSoundMixModifier(UObject WorldContextObject,UObject InSoundMixModifier) {}
	public void ClearSoundMixModifiers(UObject WorldContextObject) {}
	public void ActivateReverbEffect(UObject WorldContextObject,UObject ReverbEffect,string TagName,float Priority/*=0.0f*/,float Volume/*=0.5f*/,float FadeTime/*=2.0f*/) {}
	public void DeactivateReverbEffect(UObject WorldContextObject,string TagName) {}
	public UObject GetCurrentReverbEffect(UObject WorldContextObject) { return default; }
	public void SetMaxAudioChannelsScaled(UObject WorldContextObject,float MaxChannelCountScale) {}
	public int GetMaxAudioChannelCount(UObject WorldContextObject) { return default; }
	public UObject SpawnDecalAtLocation(UObject WorldContextObject,UObject DecalMaterial,FVector DecalSize,FVector Location,FRotator Rotation/*=new FRotator(-90,0,0)*/,float LifeSpan/*=0f*/) { return default; }
	public UObject SpawnDecalAttached(UObject DecalMaterial,FVector DecalSize,UObject AttachToComponent,string AttachPointName/*=NAME_None*/,FVector Location/*=new FVector(ForceInit)*/,FRotator Rotation/*=FRotator.ZeroRotator*/,EAttachLocation LocationType/*=EAttachLocation.KeepRelativeOffset*/,float LifeSpan/*=0f*/) { return default; }
	public void BreakHitResult(FHitResult Hit,bool bBlockingHit,bool bInitialOverlap,float Time,float Distance,FVector Location,FVector ImpactPoint,FVector Normal,FVector ImpactNormal,UObject PhysMat,UObject HitActor,UObject HitComponent,string HitBoneName,string BoneName,int HitItem,int ElementIndex,int FaceIndex,FVector TraceStart,FVector TraceEnd) {}
	public FHitResult MakeHitResult(bool bBlockingHit,bool bInitialOverlap,float Time,float Distance,FVector Location,FVector ImpactPoint,FVector Normal,FVector ImpactNormal,UObject PhysMat,UObject HitActor,UObject HitComponent,string HitBoneName,string BoneName,int HitItem,int ElementIndex,int FaceIndex,FVector TraceStart,FVector TraceEnd) { return default; }
	public EPhysicalSurface GetSurfaceType(FHitResult Hit) { return default; }
	public bool FindCollisionUV(FHitResult Hit,int UVChannel,FVector2D UV) { return default; }
	public UObject CreateSaveGameObject(UClass SaveGameClass) { return default; }
	public bool SaveGameToSlot(UObject SaveGameObject,string SlotName,int UserIndex) { return default; }
	public bool DoesSaveGameExist(string SlotName,int UserIndex) { return default; }
	public UObject LoadGameFromSlot(string SlotName,int UserIndex) { return default; }
	public bool DeleteGameInSlot(string SlotName,int UserIndex) { return default; }
	public double GetWorldDeltaSeconds(UObject WorldContextObject) { return default; }
	public double GetTimeSeconds(UObject WorldContextObject) { return default; }
	public double GetUnpausedTimeSeconds(UObject WorldContextObject) { return default; }
	public double GetRealTimeSeconds(UObject WorldContextObject) { return default; }
	public double GetAudioTimeSeconds(UObject WorldContextObject) { return default; }
	public void GetAccurateRealTime(int Seconds,double PartialSeconds) {}
	public void EnableLiveStreaming(bool Enable) {}
	public string GetPlatformName() { return default; }
	public bool BlueprintSuggestProjectileVelocity(UObject WorldContextObject,FVector TossVelocity,FVector StartLocation,FVector EndLocation,float LaunchSpeed,float OverrideGravityZ,ESuggestProjVelocityTraceOption TraceOption,float CollisionRadius,bool bFavorHighArc,bool bDrawDebug) { return default; }
	public bool Blueprint_PredictProjectilePath_ByObjectType(UObject WorldContextObject,FHitResult OutHit,TArray<FVector> OutPathPositions,FVector OutLastTraceDestination,FVector StartPos,FVector LaunchVelocity,bool bTracePath,float ProjectileRadius,TArray<byte> ObjectTypes,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,float DrawDebugTime,float SimFrequency/*=15.0f*/,float MaxSimTime/*=2.0f*/,float OverrideGravityZ/*=0f*/) { return default; }
	public bool Blueprint_PredictProjectilePath_ByTraceChannel(UObject WorldContextObject,FHitResult OutHit,TArray<FVector> OutPathPositions,FVector OutLastTraceDestination,FVector StartPos,FVector LaunchVelocity,bool bTracePath,float ProjectileRadius,byte TraceChannel,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,float DrawDebugTime,float SimFrequency/*=15.0f*/,float MaxSimTime/*=2.0f*/,float OverrideGravityZ/*=0f*/) { return default; }
	public bool Blueprint_PredictProjectilePath_Advanced(UObject WorldContextObject,FPredictProjectilePathParams PredictParams,FPredictProjectilePathResult PredictResult) { return default; }
	public bool SuggestProjectileVelocity_CustomArc(UObject WorldContextObject,FVector OutLaunchVelocity,FVector StartPos,FVector EndPos,float OverrideGravityZ/*=0f*/,float ArcParam/*=0.5f*/) { return default; }
	public FIntVector GetWorldOriginLocation(UObject WorldContextObject) { return default; }
	public void SetWorldOriginLocation(UObject WorldContextObject,FIntVector NewLocation) {}
	public FVector RebaseLocalOriginOntoZero(UObject WorldContextObject,FVector WorldLocation) { return default; }
	public FVector RebaseZeroOriginOntoLocal(UObject WorldContextObject,FVector WorldLocation) { return default; }
	public int GrassOverlappingSphereCount(UObject WorldContextObject,UObject StaticMesh,FVector CenterPosition,float Radius) { return default; }
	public bool DeprojectScreenToWorld(UObject Player,FVector2D ScreenPosition,FVector WorldPosition,FVector WorldDirection) { return default; }
	public bool DeprojectSceneCaptureToWorld(UObject SceneCapture2D,FVector2D TargetUV,FVector WorldPosition,FVector WorldDirection) { return default; }
	public bool ProjectWorldToScreen(UObject Player,FVector WorldPosition,FVector2D ScreenPosition,bool bPlayerViewportRelative/*=false*/) { return default; }
	public void GetViewProjectionMatrix(FMinimalViewInfo DesiredView,FMatrix ViewMatrix,FMatrix ProjectionMatrix,FMatrix ViewProjectionMatrix) {}
	public void GetKeyValue(string Pair,string Key,string Value) {}
	public string ParseOption(string Options,string Key) { return default; }
	public bool HasOption(string Options,string InKey) { return default; }
	public int GetIntOption(string Options,string Key,int DefaultValue) { return default; }
	public bool HasLaunchOption(string OptionToCheck) { return default; }
	public void AnnounceAccessibleString(string AnnouncementString) {}
}
