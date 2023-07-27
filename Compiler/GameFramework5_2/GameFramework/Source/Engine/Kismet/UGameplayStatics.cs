#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/GameplayStatics.h")]
///<summary>Static class with useful gameplay utility functions that can be called from both Blueprint and C++</summary>
public partial class UGameplayStatics : UBlueprintFunctionLibrary {
// GameplayStatics
	public static UObject SpawnObject(UClass ObjectClass,UObject Outer) { return default; }
	public static AActor BeginSpawningActorFromBlueprint(UObject WorldContextObject,UBlueprint Blueprint,FTransform SpawnTransform,bool bNoCollisionFail) { return default; }
	public static AActor BeginDeferredActorSpawnFromClass(UObject WorldContextObject,UClass ActorClass,FTransform SpawnTransform,ESpawnActorCollisionHandlingMethod CollisionHandlingOverride/*=ESpawnActorCollisionHandlingMethod.Undefined*/,AActor Owner/*=nullptr*/,ESpawnActorScaleMethod TransformScaleMethod/*=ESpawnActorScaleMethod.MultiplyWithRoot*/) { return default; }
	public static AActor FinishSpawningActor(AActor Actor,FTransform SpawnTransform,ESpawnActorScaleMethod TransformScaleMethod/*=ESpawnActorScaleMethod.MultiplyWithRoot*/) { return default; }
	public static FVector GetActorArrayAverageLocation(TArray<AActor> Actors) { return default; }
	public static void GetActorArrayBounds(TArray<AActor> Actors,bool bOnlyCollidingComponents,FVector Center,FVector BoxExtent) {}
	public static AActor GetActorOfClass(UObject WorldContextObject,UClass ActorClass) { return default; }
	public static void GetAllActorsOfClass(UObject WorldContextObject,UClass ActorClass,TArray<AActor> OutActors) {}
	public static void GetAllActorsWithInterface(UObject WorldContextObject,UClass Interface,TArray<AActor> OutActors) {}
	public static void GetAllActorsWithTag(UObject WorldContextObject,string Tag,TArray<AActor> OutActors) {}
	public static void GetAllActorsOfClassWithTag(UObject WorldContextObject,UClass ActorClass,string Tag,TArray<AActor> OutActors) {}
	public static AActor FindNearestActor(FVector Origin,TArray<AActor> ActorsToCheck,float Distance) { return default; }
	public static UGameInstance GetGameInstance(UObject WorldContextObject) { return default; }
	public static int GetNumPlayerStates(UObject WorldContextObject) { return default; }
	public static APlayerState GetPlayerState(UObject WorldContextObject,int PlayerStateIndex) { return default; }
	public static APlayerState GetPlayerStateFromUniqueNetId(UObject WorldContextObject,FUniqueNetIdRepl UniqueId) { return default; }
	public static int GetNumPlayerControllers(UObject WorldContextObject) { return default; }
	public static int GetNumLocalPlayerControllers(UObject WorldContextObject) { return default; }
	public static APlayerController GetPlayerController(UObject WorldContextObject,int PlayerIndex) { return default; }
	public static APawn GetPlayerPawn(UObject WorldContextObject,int PlayerIndex) { return default; }
	public static ACharacter GetPlayerCharacter(UObject WorldContextObject,int PlayerIndex) { return default; }
	public static APlayerCameraManager GetPlayerCameraManager(UObject WorldContextObject,int PlayerIndex) { return default; }
	public static APlayerController GetPlayerControllerFromID(UObject WorldContextObject,int ControllerID) { return default; }
	public static APlayerController GetPlayerControllerFromPlatformUser(UObject WorldContextObject,FPlatformUserId UserId) { return default; }
	public static APlayerController CreatePlayer(UObject WorldContextObject,int ControllerId/*=-1*/,bool bSpawnPlayerController/*=true*/) { return default; }
	public static APlayerController CreatePlayerFromPlatformUser(UObject WorldContextObject,FPlatformUserId UserId,bool bSpawnPlayerController/*=true*/) { return default; }
	public static void RemovePlayer(APlayerController Player,bool bDestroyPawn) {}
	public static int GetPlayerControllerID(APlayerController Player) { return default; }
	public static void SetPlayerControllerID(APlayerController Player,int ControllerId) {}
	public static void SetPlayerPlatformUserId(APlayerController PlayerController,FPlatformUserId UserId) {}
	public static void LoadStreamLevel(UObject WorldContextObject,string LevelName,bool bMakeVisibleAfterLoad,bool bShouldBlockOnLoad,FLatentActionInfo LatentInfo) {}
	public static void LoadStreamLevelBySoftObjectPtr(UObject WorldContextObject,TSoftObjectPtr<UWorld> Level,bool bMakeVisibleAfterLoad,bool bShouldBlockOnLoad,FLatentActionInfo LatentInfo) {}
	public static void UnloadStreamLevel(UObject WorldContextObject,string LevelName,FLatentActionInfo LatentInfo,bool bShouldBlockOnUnload) {}
	public static void UnloadStreamLevelBySoftObjectPtr(UObject WorldContextObject,TSoftObjectPtr<UWorld> Level,FLatentActionInfo LatentInfo,bool bShouldBlockOnUnload) {}
	public static ULevelStreaming GetStreamingLevel(UObject WorldContextObject,string PackageName) { return default; }
	public static void FlushLevelStreaming(UObject WorldContextObject) {}
	public static void CancelAsyncLoading() {}
	public static void OpenLevel(UObject WorldContextObject,string LevelName,bool bAbsolute/*=true*/,string Options/*=new FString(TEXT(""))*/) {}
	public static void OpenLevelBySoftObjectPtr(UObject WorldContextObject,TSoftObjectPtr<UWorld> Level,bool bAbsolute/*=true*/,string Options/*=new FString(TEXT(""))*/) {}
	public static string GetCurrentLevelName(UObject WorldContextObject,bool bRemovePrefixString/*=true*/) { return default; }
	public static AGameModeBase GetGameMode(UObject WorldContextObject) { return default; }
	public static AGameStateBase GetGameState(UObject WorldContextObject) { return default; }
	public static UClass GetObjectClass(UObject Object) { return default; }
	public static bool ObjectIsA(UObject Object,UClass ObjectClass) { return default; }
	public static float GetGlobalTimeDilation(UObject WorldContextObject) { return default; }
	public static void SetGlobalTimeDilation(UObject WorldContextObject,float TimeDilation) {}
	public static bool SetGamePaused(UObject WorldContextObject,bool bPaused) { return default; }
	public static bool IsGamePaused(UObject WorldContextObject) { return default; }
	public static void SetForceDisableSplitscreen(UObject WorldContextObject,bool bDisable) {}
	public static bool IsSplitscreenForceDisabled(UObject WorldContextObject) { return default; }
	public static void SetEnableWorldRendering(UObject WorldContextObject,bool bEnable) {}
	public static bool GetEnableWorldRendering(UObject WorldContextObject) { return default; }
	public static EMouseCaptureMode GetViewportMouseCaptureMode(UObject WorldContextObject) { return default; }
	public static void SetViewportMouseCaptureMode(UObject WorldContextObject,EMouseCaptureMode MouseCaptureMode) {}
	public static bool ApplyRadialDamage(UObject WorldContextObject,float BaseDamage,FVector Origin,float DamageRadius,UClass DamageTypeClass,TArray<AActor> IgnoreActors,AActor DamageCauser/*=NULL*/,AController InstigatedByController/*=NULL*/,bool bDoFullDamage/*=false*/,ECollisionChannel DamagePreventionChannel/*=ECC_Visibility*/) { return default; }
	public static bool ApplyRadialDamageWithFalloff(UObject WorldContextObject,float BaseDamage,float MinimumDamage,FVector Origin,float DamageInnerRadius,float DamageOuterRadius,float DamageFalloff,UClass DamageTypeClass,TArray<AActor> IgnoreActors,AActor DamageCauser/*=NULL*/,AController InstigatedByController/*=NULL*/,ECollisionChannel DamagePreventionChannel/*=ECC_Visibility*/) { return default; }
	public static float ApplyPointDamage(AActor DamagedActor,float BaseDamage,FVector HitFromDirection,FHitResult HitInfo,AController EventInstigator,AActor DamageCauser,UClass DamageTypeClass) { return default; }
	public static float ApplyDamage(AActor DamagedActor,float BaseDamage,AController EventInstigator,AActor DamageCauser,UClass DamageTypeClass) { return default; }
	public static void PlayWorldCameraShake(UObject WorldContextObject,UClass Shake,FVector Epicenter,float InnerRadius,float OuterRadius,float Falloff/*=1.0f*/,bool bOrientShakeTowardsEpicenter/*=false*/) {}
	public static UParticleSystemComponent SpawnEmitterAtLocation(UObject WorldContextObject,UParticleSystem EmitterTemplate,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,FVector Scale/*=new FVector(1.0f)*/,bool bAutoDestroy/*=true*/,EPSCPoolMethod PoolingMethod/*=EPSCPoolMethod.None*/,bool bAutoActivateSystem/*=true*/) { return default; }
	public static UParticleSystemComponent SpawnEmitterAttached(UParticleSystem EmitterTemplate,USceneComponent AttachToComponent,string AttachPointName/*=NAME_None*/,FVector Location/*=new FVector(ForceInit)*/,FRotator Rotation/*=FRotator.ZeroRotator*/,FVector Scale/*=new FVector(1.0f)*/,EAttachLocation LocationType/*=EAttachLocation.KeepRelativeOffset*/,bool bAutoDestroy/*=true*/,EPSCPoolMethod PoolingMethod/*=EPSCPoolMethod.None*/,bool bAutoActivate/*=true*/) { return default; }
	public static bool AreAnyListenersWithinRange(UObject WorldContextObject,FVector Location,float MaximumRange) { return default; }
	public static bool GetClosestListenerLocation(UObject WorldContextObject,FVector Location,float MaximumRange,bool bAllowAttenuationOverride,FVector ListenerPosition) { return default; }
	public static void SetGlobalPitchModulation(UObject WorldContextObject,float PitchModulation,float TimeSec) {}
	public static void SetSoundClassDistanceScale(UObject WorldContextObject,USoundClass SoundClass,float DistanceAttenuationScale,float TimeSec/*=0.0f*/) {}
	public static void SetGlobalListenerFocusParameters(UObject WorldContextObject,float FocusAzimuthScale/*=1.0f*/,float NonFocusAzimuthScale/*=1.0f*/,float FocusDistanceScale/*=1.0f*/,float NonFocusDistanceScale/*=1.0f*/,float FocusVolumeScale/*=1.0f*/,float NonFocusVolumeScale/*=1.0f*/,float FocusPriorityScale/*=1.0f*/,float NonFocusPriorityScale/*=1.0f*/) {}
	public static void PlaySound2D(UObject WorldContextObject,USoundBase Sound,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,USoundConcurrency ConcurrencySettings/*=nullptr*/,AActor OwningActor/*=nullptr*/,bool bIsUISound/*=true*/) {}
	public static UAudioComponent SpawnSound2D(UObject WorldContextObject,USoundBase Sound,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,USoundConcurrency ConcurrencySettings/*=nullptr*/,bool bPersistAcrossLevelTransition/*=false*/,bool bAutoDestroy/*=true*/) { return default; }
	public static UAudioComponent CreateSound2D(UObject WorldContextObject,USoundBase Sound,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,USoundConcurrency ConcurrencySettings/*=nullptr*/,bool bPersistAcrossLevelTransition/*=false*/,bool bAutoDestroy/*=true*/) { return default; }
	public static void PlaySoundAtLocation(UObject WorldContextObject,USoundBase Sound,FVector Location,FRotator Rotation,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,USoundAttenuation AttenuationSettings/*=nullptr*/,USoundConcurrency ConcurrencySettings/*=nullptr*/,AActor OwningActor/*=nullptr*/,UInitialActiveSoundParams InitialParams/*=nullptr*/) {}
	public static UAudioComponent SpawnSoundAtLocation(UObject WorldContextObject,USoundBase Sound,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,USoundAttenuation AttenuationSettings/*=nullptr*/,USoundConcurrency ConcurrencySettings/*=nullptr*/,bool bAutoDestroy/*=true*/) { return default; }
	public static UAudioComponent SpawnSoundAttached(USoundBase Sound,USceneComponent AttachToComponent,string AttachPointName/*=NAME_None*/,FVector Location/*=new FVector(ForceInit)*/,FRotator Rotation/*=FRotator.ZeroRotator*/,EAttachLocation LocationType/*=EAttachLocation.KeepRelativeOffset*/,bool bStopWhenAttachedToDestroyed/*=false*/,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,USoundAttenuation AttenuationSettings/*=nullptr*/,USoundConcurrency ConcurrencySettings/*=nullptr*/,bool bAutoDestroy/*=true*/) { return default; }
	public static void PlayDialogue2D(UObject WorldContextObject,UDialogueWave Dialogue,FDialogueContext Context,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/) {}
	public static UAudioComponent SpawnDialogue2D(UObject WorldContextObject,UDialogueWave Dialogue,FDialogueContext Context,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,bool bAutoDestroy/*=true*/) { return default; }
	public static void PlayDialogueAtLocation(UObject WorldContextObject,UDialogueWave Dialogue,FDialogueContext Context,FVector Location,FRotator Rotation,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,USoundAttenuation AttenuationSettings/*=nullptr*/) {}
	public static UAudioComponent SpawnDialogueAtLocation(UObject WorldContextObject,UDialogueWave Dialogue,FDialogueContext Context,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,USoundAttenuation AttenuationSettings/*=nullptr*/,bool bAutoDestroy/*=true*/) { return default; }
	public static UAudioComponent SpawnDialogueAttached(UDialogueWave Dialogue,FDialogueContext Context,USceneComponent AttachToComponent,string AttachPointName/*=NAME_None*/,FVector Location/*=new FVector(ForceInit)*/,FRotator Rotation/*=FRotator.ZeroRotator*/,EAttachLocation LocationType/*=EAttachLocation.KeepRelativeOffset*/,bool bStopWhenAttachedToDestroyed/*=false*/,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,USoundAttenuation AttenuationSettings/*=nullptr*/,bool bAutoDestroy/*=true*/) { return default; }
	public static UForceFeedbackComponent SpawnForceFeedbackAtLocation(UObject WorldContextObject,UForceFeedbackEffect ForceFeedbackEffect,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,bool bLooping/*=false*/,float IntensityMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,UForceFeedbackAttenuation AttenuationSettings/*=nullptr*/,bool bAutoDestroy/*=true*/) { return default; }
	public static UForceFeedbackComponent SpawnForceFeedbackAttached(UForceFeedbackEffect ForceFeedbackEffect,USceneComponent AttachToComponent,string AttachPointName/*=NAME_None*/,FVector Location/*=new FVector(ForceInit)*/,FRotator Rotation/*=FRotator.ZeroRotator*/,EAttachLocation LocationType/*=EAttachLocation.KeepRelativeOffset*/,bool bStopWhenAttachedToDestroyed/*=false*/,bool bLooping/*=false*/,float IntensityMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,UForceFeedbackAttenuation AttenuationSettings/*=nullptr*/,bool bAutoDestroy/*=true*/) { return default; }
	public static void SetSubtitlesEnabled(bool bEnabled) {}
	public static bool AreSubtitlesEnabled() { return default; }
	public static void SetBaseSoundMix(UObject WorldContextObject,USoundMix InSoundMix) {}
	public static void PrimeSound(USoundBase InSound) {}
	public static TArray<string> GetAvailableSpatialPluginNames(UObject WorldContextObject) { return default; }
	public static string GetActiveSpatialPluginName(UObject WorldContextObject) { return default; }
	public static bool SetActiveSpatialPluginByName(UObject WorldContextObject,string InPluginName) { return default; }
	public static void PrimeAllSoundsInSoundClass(USoundClass InSoundClass) {}
	public static void UnRetainAllSoundsInSoundClass(USoundClass InSoundClass) {}
	public static void SetSoundMixClassOverride(UObject WorldContextObject,USoundMix InSoundMixModifier,USoundClass InSoundClass,float Volume/*=1.0f*/,float Pitch/*=1.0f*/,float FadeInTime/*=1.0f*/,bool bApplyToChildren/*=true*/) {}
	public static void ClearSoundMixClassOverride(UObject WorldContextObject,USoundMix InSoundMixModifier,USoundClass InSoundClass,float FadeOutTime/*=1.0f*/) {}
	public static void PushSoundMixModifier(UObject WorldContextObject,USoundMix InSoundMixModifier) {}
	public static void PopSoundMixModifier(UObject WorldContextObject,USoundMix InSoundMixModifier) {}
	public static void ClearSoundMixModifiers(UObject WorldContextObject) {}
	public static void ActivateReverbEffect(UObject WorldContextObject,UReverbEffect ReverbEffect,string TagName,float Priority/*=0.0f*/,float Volume/*=0.5f*/,float FadeTime/*=2.0f*/) {}
	public static void DeactivateReverbEffect(UObject WorldContextObject,string TagName) {}
	public static UReverbEffect GetCurrentReverbEffect(UObject WorldContextObject) { return default; }
	public static void SetMaxAudioChannelsScaled(UObject WorldContextObject,float MaxChannelCountScale) {}
	public static int GetMaxAudioChannelCount(UObject WorldContextObject) { return default; }
	public static UDecalComponent SpawnDecalAtLocation(UObject WorldContextObject,UMaterialInterface DecalMaterial,FVector DecalSize,FVector Location,FRotator Rotation/*=new FRotator(-90,0,0)*/,float LifeSpan/*=0f*/) { return default; }
	public static UDecalComponent SpawnDecalAttached(UMaterialInterface DecalMaterial,FVector DecalSize,USceneComponent AttachToComponent,string AttachPointName/*=NAME_None*/,FVector Location/*=new FVector(ForceInit)*/,FRotator Rotation/*=FRotator.ZeroRotator*/,EAttachLocation LocationType/*=EAttachLocation.KeepRelativeOffset*/,float LifeSpan/*=0f*/) { return default; }
	public static void BreakHitResult(FHitResult Hit,bool bBlockingHit,bool bInitialOverlap,float Time,float Distance,FVector Location,FVector ImpactPoint,FVector Normal,FVector ImpactNormal,UPhysicalMaterial PhysMat,AActor HitActor,UPrimitiveComponent HitComponent,string HitBoneName,string BoneName,int HitItem,int ElementIndex,int FaceIndex,FVector TraceStart,FVector TraceEnd) {}
	public static FHitResult MakeHitResult(bool bBlockingHit,bool bInitialOverlap,float Time,float Distance,FVector Location,FVector ImpactPoint,FVector Normal,FVector ImpactNormal,UPhysicalMaterial PhysMat,AActor HitActor,UPrimitiveComponent HitComponent,string HitBoneName,string BoneName,int HitItem,int ElementIndex,int FaceIndex,FVector TraceStart,FVector TraceEnd) { return default; }
	public static EPhysicalSurface GetSurfaceType(FHitResult Hit) { return default; }
	public static bool FindCollisionUV(FHitResult Hit,int UVChannel,FVector2D UV) { return default; }
	public static USaveGame CreateSaveGameObject(UClass SaveGameClass) { return default; }
	public static bool SaveGameToSlot(USaveGame SaveGameObject,string SlotName,int UserIndex) { return default; }
	public static bool DoesSaveGameExist(string SlotName,int UserIndex) { return default; }
	public static USaveGame LoadGameFromSlot(string SlotName,int UserIndex) { return default; }
	public static bool DeleteGameInSlot(string SlotName,int UserIndex) { return default; }
	public static double GetWorldDeltaSeconds(UObject WorldContextObject) { return default; }
	public static double GetTimeSeconds(UObject WorldContextObject) { return default; }
	public static double GetUnpausedTimeSeconds(UObject WorldContextObject) { return default; }
	public static double GetRealTimeSeconds(UObject WorldContextObject) { return default; }
	public static double GetAudioTimeSeconds(UObject WorldContextObject) { return default; }
	public static void GetAccurateRealTime(int Seconds,double PartialSeconds) {}
	public static void EnableLiveStreaming(bool Enable) {}
	public static string GetPlatformName() { return default; }
	public static bool BlueprintSuggestProjectileVelocity(UObject WorldContextObject,FVector TossVelocity,FVector StartLocation,FVector EndLocation,float LaunchSpeed,float OverrideGravityZ,ESuggestProjVelocityTraceOption TraceOption,float CollisionRadius,bool bFavorHighArc,bool bDrawDebug) { return default; }
	public static bool Blueprint_PredictProjectilePath_ByObjectType(UObject WorldContextObject,FHitResult OutHit,TArray<FVector> OutPathPositions,FVector OutLastTraceDestination,FVector StartPos,FVector LaunchVelocity,bool bTracePath,float ProjectileRadius,TArray<byte> ObjectTypes,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,float DrawDebugTime,float SimFrequency/*=15.0f*/,float MaxSimTime/*=2.0f*/,float OverrideGravityZ/*=0f*/) { return default; }
	public static bool Blueprint_PredictProjectilePath_ByTraceChannel(UObject WorldContextObject,FHitResult OutHit,TArray<FVector> OutPathPositions,FVector OutLastTraceDestination,FVector StartPos,FVector LaunchVelocity,bool bTracePath,float ProjectileRadius,byte TraceChannel,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,float DrawDebugTime,float SimFrequency/*=15.0f*/,float MaxSimTime/*=2.0f*/,float OverrideGravityZ/*=0f*/) { return default; }
	public static bool Blueprint_PredictProjectilePath_Advanced(UObject WorldContextObject,FPredictProjectilePathParams PredictParams,FPredictProjectilePathResult PredictResult) { return default; }
	public static bool SuggestProjectileVelocity_CustomArc(UObject WorldContextObject,FVector OutLaunchVelocity,FVector StartPos,FVector EndPos,float OverrideGravityZ/*=0f*/,float ArcParam/*=0.5f*/) { return default; }
	public static FIntVector GetWorldOriginLocation(UObject WorldContextObject) { return default; }
	public static void SetWorldOriginLocation(UObject WorldContextObject,FIntVector NewLocation) {}
	public static FVector RebaseLocalOriginOntoZero(UObject WorldContextObject,FVector WorldLocation) { return default; }
	public static FVector RebaseZeroOriginOntoLocal(UObject WorldContextObject,FVector WorldLocation) { return default; }
	public static int GrassOverlappingSphereCount(UObject WorldContextObject,UStaticMesh StaticMesh,FVector CenterPosition,float Radius) { return default; }
	public static bool DeprojectScreenToWorld(APlayerController Player,FVector2D ScreenPosition,FVector WorldPosition,FVector WorldDirection) { return default; }
	public static bool DeprojectSceneCaptureToWorld(ASceneCapture2D SceneCapture2D,FVector2D TargetUV,FVector WorldPosition,FVector WorldDirection) { return default; }
	public static bool ProjectWorldToScreen(APlayerController Player,FVector WorldPosition,FVector2D ScreenPosition,bool bPlayerViewportRelative/*=false*/) { return default; }
	public static void GetViewProjectionMatrix(FMinimalViewInfo DesiredView,FMatrix ViewMatrix,FMatrix ProjectionMatrix,FMatrix ViewProjectionMatrix) {}
	public static void GetKeyValue(string Pair,string Key,string Value) {}
	public static string ParseOption(string Options,string Key) { return default; }
	public static bool HasOption(string Options,string InKey) { return default; }
	public static int GetIntOption(string Options,string Key,int DefaultValue) { return default; }
	public static bool HasLaunchOption(string OptionToCheck) { return default; }
	public static void AnnounceAccessibleString(string AnnouncementString) {}
}
