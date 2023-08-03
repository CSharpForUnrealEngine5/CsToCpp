#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Static class with useful gameplay utility functions that can be called from both Blueprint and C++</summary>
[CppInclude("Kismet/GameplayStatics.h")]
public partial class UGameplayStatics : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>--- Create Object</summary>
	public static UObject SpawnObject(UClass ObjectClass,UObject Outer) { return default; }
	///<summary>Spawns an instance of a blueprint, but does not automatically run its construction script.</summary>
	public static AActor BeginSpawningActorFromBlueprint(UObject WorldContextObject,UBlueprint Blueprint,FTransform SpawnTransform,bool bNoCollisionFail) { return default; }
	///<summary>Spawns an instance of an actor class, but does not automatically run its construction script.</summary>
	public static AActor BeginDeferredActorSpawnFromClass(UObject WorldContextObject,UClass ActorClass,FTransform SpawnTransform,ESpawnActorCollisionHandlingMethod CollisionHandlingOverride/*=ESpawnActorCollisionHandlingMethod.Undefined*/,AActor Owner/*=nullptr*/,ESpawnActorScaleMethod TransformScaleMethod/*=ESpawnActorScaleMethod.MultiplyWithRoot*/) { return default; }
	///<summary>&#39;Finish&#39; spawning an actor.  This will run the construction script.</summary>
	public static AActor FinishSpawningActor(AActor Actor,FTransform SpawnTransform,ESpawnActorScaleMethod TransformScaleMethod/*=ESpawnActorScaleMethod.MultiplyWithRoot*/) { return default; }
	///<summary>Find the average location (centroid) of an array of Actors</summary>
	public static FVector GetActorArrayAverageLocation(TArray<AActor> Actors) { return default; }
	///<summary>Bind the bounds of an array of Actors</summary>
	public static void GetActorArrayBounds(TArray<AActor> Actors,bool bOnlyCollidingComponents,FVector Center,FVector BoxExtent) {}
	///<summary>Find the first Actor in the world of the specified class.</summary>
	public static AActor GetActorOfClass(UObject WorldContextObject,UClass ActorClass) { return default; }
	///<summary>Find all Actors in the world of the specified class.</summary>
	public static void GetAllActorsOfClass(UObject WorldContextObject,UClass ActorClass,TArray<AActor> OutActors) {}
	///<summary>Find all Actors in the world with the specified interface.</summary>
	public static void GetAllActorsWithInterface(UObject WorldContextObject,UClass Interface,TArray<AActor> OutActors) {}
	///<summary>Find all Actors in the world with the specified tag.</summary>
	public static void GetAllActorsWithTag(UObject WorldContextObject,string Tag,TArray<AActor> OutActors) {}
	///<summary>Find all Actors in the world of the specified class with the specified tag.</summary>
	public static void GetAllActorsOfClassWithTag(UObject WorldContextObject,UClass ActorClass,string Tag,TArray<AActor> OutActors) {}
	///<summary>Returns an Actor nearest to Origin from ActorsToCheck array.</summary>
	public static AActor FindNearestActor(FVector Origin,TArray<AActor> ActorsToCheck,float Distance) { return default; }
	///<summary>Returns the game instance object</summary>
	public static UGameInstance GetGameInstance(UObject WorldContextObject) { return default; }
	///<summary>Returns the number of active player states, there is one player state for every connected player even if they are a remote client.</summary>
	public static int GetNumPlayerStates(UObject WorldContextObject) { return default; }
	///<summary>Returns the player state at the given index in the game state&#39;s PlayerArray.</summary>
	public static APlayerState GetPlayerState(UObject WorldContextObject,int PlayerStateIndex) { return default; }
	///<summary>Returns the player state that matches the passed in online id, or null for an invalid one.</summary>
	public static APlayerState GetPlayerStateFromUniqueNetId(UObject WorldContextObject,FUniqueNetIdRepl UniqueId) { return default; }
	///<summary>Returns the total number of available player controllers, including remote players when called on a server.</summary>
	public static int GetNumPlayerControllers(UObject WorldContextObject) { return default; }
	///<summary>Returns the number of fully initialized local players, this will be 0 on dedicated servers.</summary>
	public static int GetNumLocalPlayerControllers(UObject WorldContextObject) { return default; }
	///<summary>Returns the player controller found while iterating through the local and available remote player controllers.</summary>
	public static APlayerController GetPlayerController(UObject WorldContextObject,int PlayerIndex) { return default; }
	///<summary>Returns the pawn for the player controller at the specified player index.</summary>
	public static APawn GetPlayerPawn(UObject WorldContextObject,int PlayerIndex) { return default; }
	///<summary>Returns the pawn for the player controller at the specified player index, will return null if the pawn is not a character.</summary>
	public static ACharacter GetPlayerCharacter(UObject WorldContextObject,int PlayerIndex) { return default; }
	///<summary>Returns the camera manager for the Player Controller at the specified player index.</summary>
	public static APlayerCameraManager GetPlayerCameraManager(UObject WorldContextObject,int PlayerIndex) { return default; }
	///<summary>Returns the player controller with the specified physical controller ID. This only works for local players.</summary>
	public static APlayerController GetPlayerControllerFromID(UObject WorldContextObject,int ControllerID) { return default; }
	///<summary>Returns the player controller with the specified physical controller ID. This only works for local players.</summary>
	public static APlayerController GetPlayerControllerFromPlatformUser(UObject WorldContextObject,FPlatformUserId UserId) { return default; }
	///<summary>Create a new local player for this game, for cases like local multiplayer.</summary>
	public static APlayerController CreatePlayer(UObject WorldContextObject,int ControllerId/*=-1*/,bool bSpawnPlayerController/*=true*/) { return default; }
	///<summary>Create a new local player for this game, for cases like local multiplayer.</summary>
	public static APlayerController CreatePlayerFromPlatformUser(UObject WorldContextObject,FPlatformUserId UserId,bool bSpawnPlayerController/*=true*/) { return default; }
	///<summary>Removes a local player from this game.</summary>
	public static void RemovePlayer(APlayerController Player,bool bDestroyPawn) {}
	///<summary>Gets what physical controller ID a player is using. This only works for local player controllers.</summary>
	public static int GetPlayerControllerID(APlayerController Player) { return default; }
	///<summary>Sets what physical controller ID a player should be using. This only works for local player controllers.</summary>
	public static void SetPlayerControllerID(APlayerController Player,int ControllerId) {}
	///<summary>Sets what platform user id a player should be using. This only works for local player controllers.</summary>
	public static void SetPlayerPlatformUserId(APlayerController PlayerController,FPlatformUserId UserId) {}
	///<summary>Stream the level (by Name); Calling again before it finishes has no effect</summary>
	public static void LoadStreamLevel(UObject WorldContextObject,string LevelName,bool bMakeVisibleAfterLoad,bool bShouldBlockOnLoad,FLatentActionInfo LatentInfo) {}
	///<summary>Stream the level (by Object Reference); Calling again before it finishes has no effect</summary>
	public static void LoadStreamLevelBySoftObjectPtr(UObject WorldContextObject,TSoftObjectPtr<UWorld> Level,bool bMakeVisibleAfterLoad,bool bShouldBlockOnLoad,FLatentActionInfo LatentInfo) {}
	///<summary>Unload a streamed in level (by Name)</summary>
	public static void UnloadStreamLevel(UObject WorldContextObject,string LevelName,FLatentActionInfo LatentInfo,bool bShouldBlockOnUnload) {}
	///<summary>Unload a streamed in level (by Object Reference)</summary>
	public static void UnloadStreamLevelBySoftObjectPtr(UObject WorldContextObject,TSoftObjectPtr<UWorld> Level,FLatentActionInfo LatentInfo,bool bShouldBlockOnUnload) {}
	///<summary>Returns level streaming object with specified level package name</summary>
	public static ULevelStreaming GetStreamingLevel(UObject WorldContextObject,string PackageName) { return default; }
	///<summary>Flushes level streaming in blocking fashion and returns when all sub-levels are loaded / visible / hidden</summary>
	public static void FlushLevelStreaming(UObject WorldContextObject) {}
	///<summary>Cancels all currently queued streaming packages</summary>
	public static void CancelAsyncLoading() {}
	///<summary>Travel to another level</summary>
	public static void OpenLevel(UObject WorldContextObject,string LevelName,bool bAbsolute/*=true*/,string Options/*=new FString(TEXT(""))*/) {}
	///<summary>Travel to another level</summary>
	public static void OpenLevelBySoftObjectPtr(UObject WorldContextObject,TSoftObjectPtr<UWorld> Level,bool bAbsolute/*=true*/,string Options/*=new FString(TEXT(""))*/) {}
	///<summary>Get the name of the currently-open level.</summary>
	public static string GetCurrentLevelName(UObject WorldContextObject,bool bRemovePrefixString/*=true*/) { return default; }
	///<summary>Returns the current GameModeBase or Null if it can&#39;t be retrieved, such as on the client</summary>
	public static AGameModeBase GetGameMode(UObject WorldContextObject) { return default; }
	///<summary>Returns the current GameStateBase or Null if it can&#39;t be retrieved</summary>
	public static AGameStateBase GetGameState(UObject WorldContextObject) { return default; }
	///<summary>Returns the class of a passed in Object, will always be valid if Object is not NULL</summary>
	public static UClass GetObjectClass(UObject Object) { return default; }
	///<summary>Returns whether or not the object passed in is of (or inherits from) the class type.</summary>
	public static bool ObjectIsA(UObject Object,UClass ObjectClass) { return default; }
	///<summary>Gets the current global time dilation.</summary>
	public static float GetGlobalTimeDilation(UObject WorldContextObject) { return default; }
	///<summary>Sets the global time dilation.</summary>
	public static void SetGlobalTimeDilation(UObject WorldContextObject,float TimeDilation) {}
	///<summary>Sets the game&#39;s paused state</summary>
	public static bool SetGamePaused(UObject WorldContextObject,bool bPaused) { return default; }
	///<summary>Returns the game&#39;s paused state</summary>
	public static bool IsGamePaused(UObject WorldContextObject) { return default; }
	///<summary>Enables split screen</summary>
	public static void SetForceDisableSplitscreen(UObject WorldContextObject,bool bDisable) {}
	///<summary>Returns the split screen state</summary>
	public static bool IsSplitscreenForceDisabled(UObject WorldContextObject) { return default; }
	///<summary>Enabled rendering of the world</summary>
	public static void SetEnableWorldRendering(UObject WorldContextObject,bool bEnable) {}
	///<summary>Returns the world rendering state</summary>
	public static bool GetEnableWorldRendering(UObject WorldContextObject) { return default; }
	///<summary>Returns the current viewport mouse capture mode</summary>
	public static EMouseCaptureMode GetViewportMouseCaptureMode(UObject WorldContextObject) { return default; }
	///<summary>Sets the current viewport mouse capture mode</summary>
	public static void SetViewportMouseCaptureMode(UObject WorldContextObject,EMouseCaptureMode MouseCaptureMode) {}
	///<summary>Hurt locally authoritative actors within the radius. Will only hit components that block the Visibility channel.</summary>
	public static bool ApplyRadialDamage(UObject WorldContextObject,float BaseDamage,FVector Origin,float DamageRadius,UClass DamageTypeClass,TArray<AActor> IgnoreActors,AActor DamageCauser/*=NULL*/,AController InstigatedByController/*=NULL*/,bool bDoFullDamage/*=false*/,ECollisionChannel DamagePreventionChannel/*=ECC_Visibility*/) { return default; }
	///<summary>Hurt locally authoritative actors within the radius. Will only hit components that block the Visibility channel.</summary>
	public static bool ApplyRadialDamageWithFalloff(UObject WorldContextObject,float BaseDamage,float MinimumDamage,FVector Origin,float DamageInnerRadius,float DamageOuterRadius,float DamageFalloff,UClass DamageTypeClass,TArray<AActor> IgnoreActors,AActor DamageCauser/*=NULL*/,AController InstigatedByController/*=NULL*/,ECollisionChannel DamagePreventionChannel/*=ECC_Visibility*/) { return default; }
	///<summary>Hurts the specified actor with the specified impact.</summary>
	public static float ApplyPointDamage(AActor DamagedActor,float BaseDamage,FVector HitFromDirection,FHitResult HitInfo,AController EventInstigator,AActor DamageCauser,UClass DamageTypeClass) { return default; }
	///<summary>Hurts the specified actor with generic damage.</summary>
	public static float ApplyDamage(AActor DamagedActor,float BaseDamage,AController EventInstigator,AActor DamageCauser,UClass DamageTypeClass) { return default; }
	///<summary>Plays an in-world camera shake that affects all nearby local players, with distance-based attenuation. Does not replicate.</summary>
	public static void PlayWorldCameraShake(UObject WorldContextObject,UClass Shake,FVector Epicenter,float InnerRadius,float OuterRadius,float Falloff/*=1.0f*/,bool bOrientShakeTowardsEpicenter/*=false*/) {}
	///<summary>Plays the specified effect at the given location and rotation, fire and forget. The system will go away when the effect is complete. Does not replicate.</summary>
	public static UParticleSystemComponent SpawnEmitterAtLocation(UObject WorldContextObject,UParticleSystem EmitterTemplate,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,FVector Scale/*=new FVector(1.0f)*/,bool bAutoDestroy/*=true*/,EPSCPoolMethod PoolingMethod/*=EPSCPoolMethod.None*/,bool bAutoActivateSystem/*=true*/) { return default; }
	///<summary>Plays the specified effect attached to and following the specified component. The system will go away when the effect is complete. Does not replicate.</summary>
	public static UParticleSystemComponent SpawnEmitterAttached(UParticleSystem EmitterTemplate,USceneComponent AttachToComponent,string AttachPointName/*=NAME_None*/,FVector Location/*=new FVector(ForceInit)*/,FRotator Rotation/*=FRotator.ZeroRotator*/,FVector Scale/*=new FVector(1.0f)*/,EAttachLocation LocationType/*=EAttachLocation.KeepRelativeOffset*/,bool bAutoDestroy/*=true*/,EPSCPoolMethod PoolingMethod/*=EPSCPoolMethod.None*/,bool bAutoActivate/*=true*/) { return default; }
	///<summary>Determines if any audio listeners are within range of the specified location</summary>
	public static bool AreAnyListenersWithinRange(UObject WorldContextObject,FVector Location,float MaximumRange) { return default; }
	///<summary>Finds and returns the position of the closest listener to the specified location</summary>
	public static bool GetClosestListenerLocation(UObject WorldContextObject,FVector Location,float MaximumRange,bool bAllowAttenuationOverride,FVector ListenerPosition) { return default; }
	///<summary>Sets a global pitch modulation scalar that will apply to all non-UI sounds</summary>
	public static void SetGlobalPitchModulation(UObject WorldContextObject,float PitchModulation,float TimeSec) {}
	///<summary>Linearly interpolates the attenuation distance scale value from it&#39;s current attenuation distance override value</summary>
	public static void SetSoundClassDistanceScale(UObject WorldContextObject,USoundClass SoundClass,float DistanceAttenuationScale,float TimeSec/*=0.0f*/) {}
	///<summary>Sets the global listener focus parameters, which will scale focus behavior of sounds based on their focus azimuth</summary>
	public static void SetGlobalListenerFocusParameters(UObject WorldContextObject,float FocusAzimuthScale/*=1.0f*/,float NonFocusAzimuthScale/*=1.0f*/,float FocusDistanceScale/*=1.0f*/,float NonFocusDistanceScale/*=1.0f*/,float FocusVolumeScale/*=1.0f*/,float NonFocusVolumeScale/*=1.0f*/,float FocusPriorityScale/*=1.0f*/,float NonFocusPriorityScale/*=1.0f*/) {}
	///<summary>Plays a sound directly with no attenuation, perfect for UI sounds.</summary>
	public static void PlaySound2D(UObject WorldContextObject,USoundBase Sound,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,USoundConcurrency ConcurrencySettings/*=nullptr*/,AActor OwningActor/*=nullptr*/,bool bIsUISound/*=true*/) {}
	///<summary>This function allows users to create Audio Components with settings specifically for non-spatialized,</summary>
	public static UAudioComponent SpawnSound2D(UObject WorldContextObject,USoundBase Sound,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,USoundConcurrency ConcurrencySettings/*=nullptr*/,bool bPersistAcrossLevelTransition/*=false*/,bool bAutoDestroy/*=true*/) { return default; }
	///<summary>This function allows users to create Audio Components in advance of playback with settings specifically for non-spatialized,</summary>
	public static UAudioComponent CreateSound2D(UObject WorldContextObject,USoundBase Sound,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,USoundConcurrency ConcurrencySettings/*=nullptr*/,bool bPersistAcrossLevelTransition/*=false*/,bool bAutoDestroy/*=true*/) { return default; }
	///<summary>Plays a sound at the given location. This is a fire and forget sound and does not travel with any actor.</summary>
	public static void PlaySoundAtLocation(UObject WorldContextObject,USoundBase Sound,FVector Location,FRotator Rotation,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,USoundAttenuation AttenuationSettings/*=nullptr*/,USoundConcurrency ConcurrencySettings/*=nullptr*/,AActor OwningActor/*=nullptr*/,UInitialActiveSoundParams InitialParams/*=nullptr*/) {}
	///<summary>Spawns a sound at the given location. This does not travel with any actor. Replication is also not handled at this point.</summary>
	public static UAudioComponent SpawnSoundAtLocation(UObject WorldContextObject,USoundBase Sound,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,USoundAttenuation AttenuationSettings/*=nullptr*/,USoundConcurrency ConcurrencySettings/*=nullptr*/,bool bAutoDestroy/*=true*/) { return default; }
	///<summary>This function allows users to create and play Audio Components attached to a specific Scene Component.</summary>
	public static UAudioComponent SpawnSoundAttached(USoundBase Sound,USceneComponent AttachToComponent,string AttachPointName/*=NAME_None*/,FVector Location/*=new FVector(ForceInit)*/,FRotator Rotation/*=FRotator.ZeroRotator*/,EAttachLocation LocationType/*=EAttachLocation.KeepRelativeOffset*/,bool bStopWhenAttachedToDestroyed/*=false*/,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,USoundAttenuation AttenuationSettings/*=nullptr*/,USoundConcurrency ConcurrencySettings/*=nullptr*/,bool bAutoDestroy/*=true*/) { return default; }
	///<summary>Plays a dialogue directly with no attenuation, perfect for UI.</summary>
	public static void PlayDialogue2D(UObject WorldContextObject,UDialogueWave Dialogue,FDialogueContext Context,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/) {}
	///<summary>Spawns a DialogueWave, a special type of Asset that requires Context data in order to resolve a specific SoundBase,</summary>
	public static UAudioComponent SpawnDialogue2D(UObject WorldContextObject,UDialogueWave Dialogue,FDialogueContext Context,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,bool bAutoDestroy/*=true*/) { return default; }
	///<summary>Plays a dialogue at the given location. This is a fire and forget sound and does not travel with any actor.</summary>
	public static void PlayDialogueAtLocation(UObject WorldContextObject,UDialogueWave Dialogue,FDialogueContext Context,FVector Location,FRotator Rotation,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,USoundAttenuation AttenuationSettings/*=nullptr*/) {}
	///<summary>Spawns a DialogueWave, a special type of Asset that requires Context data in order to resolve a specific SoundBase,</summary>
	public static UAudioComponent SpawnDialogueAtLocation(UObject WorldContextObject,UDialogueWave Dialogue,FDialogueContext Context,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,USoundAttenuation AttenuationSettings/*=nullptr*/,bool bAutoDestroy/*=true*/) { return default; }
	///<summary>Spawns a DialogueWave, a special type of Asset that requires Context data in order to resolve a specific SoundBase,</summary>
	public static UAudioComponent SpawnDialogueAttached(UDialogueWave Dialogue,FDialogueContext Context,USceneComponent AttachToComponent,string AttachPointName/*=NAME_None*/,FVector Location/*=new FVector(ForceInit)*/,FRotator Rotation/*=FRotator.ZeroRotator*/,EAttachLocation LocationType/*=EAttachLocation.KeepRelativeOffset*/,bool bStopWhenAttachedToDestroyed/*=false*/,float VolumeMultiplier/*=1.0f*/,float PitchMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,USoundAttenuation AttenuationSettings/*=nullptr*/,bool bAutoDestroy/*=true*/) { return default; }
	///<summary>Plays a force feedback effect at the given location. This is a fire and forget effect and does not travel with any actor. Replication is also not handled at this point.</summary>
	public static UForceFeedbackComponent SpawnForceFeedbackAtLocation(UObject WorldContextObject,UForceFeedbackEffect ForceFeedbackEffect,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,bool bLooping/*=false*/,float IntensityMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,UForceFeedbackAttenuation AttenuationSettings/*=nullptr*/,bool bAutoDestroy/*=true*/) { return default; }
	///<summary>Plays a force feedback effect attached to and following the specified component. This is a fire and forget effect. Replication is also not handled at this point.</summary>
	public static UForceFeedbackComponent SpawnForceFeedbackAttached(UForceFeedbackEffect ForceFeedbackEffect,USceneComponent AttachToComponent,string AttachPointName/*=NAME_None*/,FVector Location/*=new FVector(ForceInit)*/,FRotator Rotation/*=FRotator.ZeroRotator*/,EAttachLocation LocationType/*=EAttachLocation.KeepRelativeOffset*/,bool bStopWhenAttachedToDestroyed/*=false*/,bool bLooping/*=false*/,float IntensityMultiplier/*=1.0f*/,float StartTime/*=0.0f*/,UForceFeedbackAttenuation AttenuationSettings/*=nullptr*/,bool bAutoDestroy/*=true*/) { return default; }
	///<summary>Will set subtitles to be enabled or disabled.</summary>
	public static void SetSubtitlesEnabled(bool bEnabled) {}
	///<summary>Returns whether or not subtitles are currently enabled.</summary>
	public static bool AreSubtitlesEnabled() { return default; }
	///<summary>Set the sound mix of the audio system for special EQing</summary>
	public static void SetBaseSoundMix(UObject WorldContextObject,USoundMix InSoundMix) {}
	///<summary>Primes the sound, caching the first chunk of streamed audio.</summary>
	public static void PrimeSound(USoundBase InSound) {}
	///<summary>Get list of available Audio Spatialization Plugin names</summary>
	public static TArray<string> GetAvailableSpatialPluginNames(UObject WorldContextObject) { return default; }
	///<summary>Get currently active Audio Spatialization Plugin name</summary>
	public static string GetActiveSpatialPluginName(UObject WorldContextObject) { return default; }
	///<summary>Get list of available Audio Spatialization Plugins</summary>
	public static bool SetActiveSpatialPluginByName(UObject WorldContextObject,string InPluginName) { return default; }
	///<summary>Primes the sound waves in the given USoundClass, caching the first chunk of streamed audio.</summary>
	public static void PrimeAllSoundsInSoundClass(USoundClass InSoundClass) {}
	///<summary>Iterate through all sound waves and releases handles to retained chunks. (If the chunk is not being played it will be up for eviction)</summary>
	public static void UnRetainAllSoundsInSoundClass(USoundClass InSoundClass) {}
	///<summary>Overrides the sound class adjuster in the given sound mix. If the sound class does not exist in the input sound mix,</summary>
	public static void SetSoundMixClassOverride(UObject WorldContextObject,USoundMix InSoundMixModifier,USoundClass InSoundClass,float Volume/*=1.0f*/,float Pitch/*=1.0f*/,float FadeInTime/*=1.0f*/,bool bApplyToChildren/*=true*/) {}
	///<summary>Clears any existing override of the Sound Class Adjuster in the given Sound Mix</summary>
	public static void ClearSoundMixClassOverride(UObject WorldContextObject,USoundMix InSoundMixModifier,USoundClass InSoundClass,float FadeOutTime/*=1.0f*/) {}
	///<summary>Push a sound mix modifier onto the audio system</summary>
	public static void PushSoundMixModifier(UObject WorldContextObject,USoundMix InSoundMixModifier) {}
	///<summary>Pop a sound mix modifier from the audio system</summary>
	public static void PopSoundMixModifier(UObject WorldContextObject,USoundMix InSoundMixModifier) {}
	///<summary>Clear all sound mix modifiers from the audio system</summary>
	public static void ClearSoundMixModifiers(UObject WorldContextObject) {}
	///<summary>Activates a Reverb Effect without the need for an Audio Volume</summary>
	public static void ActivateReverbEffect(UObject WorldContextObject,UReverbEffect ReverbEffect,string TagName,float Priority/*=0.0f*/,float Volume/*=0.5f*/,float FadeTime/*=2.0f*/) {}
	///<summary>Deactivates a Reverb Effect that was applied outside of an Audio Volume</summary>
	public static void DeactivateReverbEffect(UObject WorldContextObject,string TagName) {}
	///<summary>Returns the highest priority reverb settings currently active from any source (Audio Volumes or manual settings).</summary>
	public static UReverbEffect GetCurrentReverbEffect(UObject WorldContextObject) { return default; }
	///<summary>Sets the max number of voices (also known as &quot;channels&quot;) dynamically by percentage. E.g. if you want to temporarily</summary>
	public static void SetMaxAudioChannelsScaled(UObject WorldContextObject,float MaxChannelCountScale) {}
	///<summary>Retrieves the max voice count currently used by the audio engine.</summary>
	public static int GetMaxAudioChannelCount(UObject WorldContextObject) { return default; }
	///<summary>Spawns a decal at the given location and rotation, fire and forget. Does not replicate.</summary>
	public static UDecalComponent SpawnDecalAtLocation(UObject WorldContextObject,UMaterialInterface DecalMaterial,FVector DecalSize,FVector Location,FRotator Rotation/*=new FRotator(-90,0,0)*/,float LifeSpan/*=0f*/) { return default; }
	///<summary>Spawns a decal attached to and following the specified component. Does not replicate.</summary>
	public static UDecalComponent SpawnDecalAttached(UMaterialInterface DecalMaterial,FVector DecalSize,USceneComponent AttachToComponent,string AttachPointName/*=NAME_None*/,FVector Location/*=new FVector(ForceInit)*/,FRotator Rotation/*=FRotator.ZeroRotator*/,EAttachLocation LocationType/*=EAttachLocation.KeepRelativeOffset*/,float LifeSpan/*=0f*/) { return default; }
	///<summary>Extracts data from a HitResult.</summary>
	public static void BreakHitResult(FHitResult Hit,bool bBlockingHit,bool bInitialOverlap,float Time,float Distance,FVector Location,FVector ImpactPoint,FVector Normal,FVector ImpactNormal,UPhysicalMaterial PhysMat,AActor HitActor,UPrimitiveComponent HitComponent,string HitBoneName,string BoneName,int HitItem,int ElementIndex,int FaceIndex,FVector TraceStart,FVector TraceEnd) {}
	///<summary>Create a HitResult struct</summary>
	public static FHitResult MakeHitResult(bool bBlockingHit,bool bInitialOverlap,float Time,float Distance,FVector Location,FVector ImpactPoint,FVector Normal,FVector ImpactNormal,UPhysicalMaterial PhysMat,AActor HitActor,UPrimitiveComponent HitComponent,string HitBoneName,string BoneName,int HitItem,int ElementIndex,int FaceIndex,FVector TraceStart,FVector TraceEnd) { return default; }
	///<summary>Returns the EPhysicalSurface type of the given Hit.</summary>
	public static EPhysicalSurface GetSurfaceType(FHitResult Hit) { return default; }
	///<summary>Try and find the UV for a collision impact. Note this ONLY works if &#39;Support UV From Hit Results&#39; is enabled in Physics Settings.</summary>
	public static bool FindCollisionUV(FHitResult Hit,int UVChannel,FVector2D UV) { return default; }
	///<summary>Create a new, empty SaveGame object to set data on and then pass to SaveGameToSlot.</summary>
	public static USaveGame CreateSaveGameObject(UClass SaveGameClass) { return default; }
	///<summary>Save the contents of the SaveGameObject to a platform-specific save slot/file.</summary>
	public static bool SaveGameToSlot(USaveGame SaveGameObject,string SlotName,int UserIndex) { return default; }
	///<summary>See if a save game exists with the specified name.</summary>
	public static bool DoesSaveGameExist(string SlotName,int UserIndex) { return default; }
	///<summary>Load the contents from a given slot.</summary>
	public static USaveGame LoadGameFromSlot(string SlotName,int UserIndex) { return default; }
	///<summary>Delete a save game in a particular slot.</summary>
	public static bool DeleteGameInSlot(string SlotName,int UserIndex) { return default; }
	///<summary>Returns the frame delta time in seconds, adjusted by time dilation.</summary>
	public static double GetWorldDeltaSeconds(UObject WorldContextObject) { return default; }
	///<summary>Returns time in seconds since world was brought up for play, adjusted by time dilation and IS stopped when game pauses</summary>
	public static double GetTimeSeconds(UObject WorldContextObject) { return default; }
	///<summary>Returns time in seconds since world was brought up for play, adjusted by time dilation and IS NOT stopped when game pauses</summary>
	public static double GetUnpausedTimeSeconds(UObject WorldContextObject) { return default; }
	///<summary>Returns time in seconds since world was brought up for play, does NOT stop when game pauses, NOT dilated/clamped</summary>
	public static double GetRealTimeSeconds(UObject WorldContextObject) { return default; }
	///<summary>Returns time in seconds since world was brought up for play, IS stopped when game pauses, NOT dilated/clamped.</summary>
	public static double GetAudioTimeSeconds(UObject WorldContextObject) { return default; }
	///<summary>Returns time in seconds since the application was started. Unlike the other time functions this is accurate to the exact time this function is called instead of set once per frame.</summary>
	public static void GetAccurateRealTime(int Seconds,double PartialSeconds) {}
	///<summary>Toggle live DVR streaming.</summary>
	public static void EnableLiveStreaming(bool Enable) {}
	///<summary>Returns the string name of the current platform, to perform different behavior based on platform.</summary>
	public static string GetPlatformName() { return default; }
	///<summary>Calculates an launch velocity for a projectile to hit a specified point.</summary>
	public static bool BlueprintSuggestProjectileVelocity(UObject WorldContextObject,FVector TossVelocity,FVector StartLocation,FVector EndLocation,float LaunchSpeed,float OverrideGravityZ,ESuggestProjVelocityTraceOption TraceOption,float CollisionRadius,bool bFavorHighArc,bool bDrawDebug) { return default; }
	///<summary>Predict the arc of a virtual projectile affected by gravity with collision checks along the arc. Returns a list of positions of the simulated arc and the destination reached by the simulation.</summary>
	public static bool Blueprint_PredictProjectilePath_ByObjectType(UObject WorldContextObject,FHitResult OutHit,TArray<FVector> OutPathPositions,FVector OutLastTraceDestination,FVector StartPos,FVector LaunchVelocity,bool bTracePath,float ProjectileRadius,TArray<EObjectTypeQuery> ObjectTypes,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,float DrawDebugTime,float SimFrequency/*=15.0f*/,float MaxSimTime/*=2.0f*/,float OverrideGravityZ/*=0f*/) { return default; }
	///<summary>Predict the arc of a virtual projectile affected by gravity with collision checks along the arc. Returns a list of positions of the simulated arc and the destination reached by the simulation.</summary>
	public static bool Blueprint_PredictProjectilePath_ByTraceChannel(UObject WorldContextObject,FHitResult OutHit,TArray<FVector> OutPathPositions,FVector OutLastTraceDestination,FVector StartPos,FVector LaunchVelocity,bool bTracePath,float ProjectileRadius,ECollisionChannel TraceChannel,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,float DrawDebugTime,float SimFrequency/*=15.0f*/,float MaxSimTime/*=2.0f*/,float OverrideGravityZ/*=0f*/) { return default; }
	///<summary>Predict the arc of a virtual projectile affected by gravity with collision checks along the arc.</summary>
	public static bool Blueprint_PredictProjectilePath_Advanced(UObject WorldContextObject,FPredictProjectilePathParams PredictParams,FPredictProjectilePathResult PredictResult) { return default; }
	///<summary>Returns the launch velocity needed for a projectile at rest at StartPos to land on EndPos.</summary>
	public static bool SuggestProjectileVelocity_CustomArc(UObject WorldContextObject,FVector OutLaunchVelocity,FVector StartPos,FVector EndPos,float OverrideGravityZ/*=0f*/,float ArcParam/*=0.5f*/) { return default; }
	///<summary>Returns world origin current location.</summary>
	public static FIntVector GetWorldOriginLocation(UObject WorldContextObject) { return default; }
	///<summary>Requests a new location for a world origin.</summary>
	public static void SetWorldOriginLocation(UObject WorldContextObject,FIntVector NewLocation) {}
	///<summary>Returns origin based position for local world location.</summary>
	public static FVector RebaseLocalOriginOntoZero(UObject WorldContextObject,FVector WorldLocation) { return default; }
	///<summary>Returns local location for origin based position.</summary>
	public static FVector RebaseZeroOriginOntoLocal(UObject WorldContextObject,FVector WorldLocation) { return default; }
	///<summary>Counts how many grass foliage instances overlap a given sphere.</summary>
	public static int GrassOverlappingSphereCount(UObject WorldContextObject,UStaticMesh StaticMesh,FVector CenterPosition,float Radius) { return default; }
	///<summary>Transforms the given 2D screen space coordinate into a 3D world-space point and direction.</summary>
	public static bool DeprojectScreenToWorld(APlayerController Player,FVector2D ScreenPosition,FVector WorldPosition,FVector WorldDirection) { return default; }
	///<summary>Transforms the given 2D UV coordinate into a 3D world-space point and direction.</summary>
	public static bool DeprojectSceneCaptureToWorld(ASceneCapture2D SceneCapture2D,FVector2D TargetUV,FVector WorldPosition,FVector WorldDirection) { return default; }
	///<summary>Transforms the given 3D world-space point into a its 2D screen space coordinate.</summary>
	public static bool ProjectWorldToScreen(APlayerController Player,FVector WorldPosition,FVector2D ScreenPosition,bool bPlayerViewportRelative/*=false*/) { return default; }
	///<summary>Returns the View Matrix, Projection Matrix and the View x Projection Matrix for a given view</summary>
	public static void GetViewProjectionMatrix(FMinimalViewInfo DesiredView,FMatrix ViewMatrix,FMatrix ProjectionMatrix,FMatrix ViewProjectionMatrix) {}
	///<summary>Break up a key=value pair into its key and value.</summary>
	public static void GetKeyValue(string Pair,string Key,string Value) {}
	///<summary>Find an option in the options string and return it.</summary>
	public static string ParseOption(string Options,string Key) { return default; }
	///<summary>Returns whether a key exists in an options string.</summary>
	public static bool HasOption(string Options,string InKey) { return default; }
	///<summary>Find an option in the options string and return it as an integer.</summary>
	public static int GetIntOption(string Options,string Key,int DefaultValue) { return default; }
	///<summary>Checks the commandline to see if the desired option was specified on the commandline (e.g. -demobuild)</summary>
	public static bool HasLaunchOption(string OptionToCheck) { return default; }
	///<summary>If accessibility is enabled, have the platform announce a string to the player.</summary>
	public static void AnnounceAccessibleString(string AnnouncementString) {}
}
