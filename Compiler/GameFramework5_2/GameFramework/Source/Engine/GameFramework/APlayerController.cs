#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/PlayerController.h")]
///<summary>PlayerControllers are used by human players to control Pawns.</summary>
public partial class APlayerController : AController {
// PlayerController
	public UPlayer Player;
	public APawn AcknowledgedPawn;
	public AHUD MyHUD;
	public APlayerCameraManager PlayerCameraManager;
	public UClass PlayerCameraManagerClass;
	public bool bAutoManageActiveCameraTarget;
	public FRotator TargetViewRotation;
	public float SmoothTargetViewRotationSpeed;
	public TArray<AActor> HiddenActors;
	public TArray<TWeakObjectPtr<UPrimitiveComponent>> HiddenPrimitiveComponents;
	public float LastSpectatorStateSynchTime;
	public FVector LastSpectatorSyncLocation;
	public FRotator LastSpectatorSyncRotation;
	public int ClientCap;
	public UCheatManager CheatManager;
	public UClass CheatClass;
	public UPlayerInput PlayerInput;
	public TArray<FActiveForceFeedbackEffect> ActiveForceFeedbackEffects;
	public UClass AsyncPhysicsDataClass;
	public  UAsyncPhysicsData GetAsyncPhysicsDataToWrite() { return default; }
	public  UAsyncPhysicsData GetAsyncPhysicsDataToConsume() { return default; }
	public UAsyncPhysicsInputComponent AsyncPhysicsDataComponent;
	public  void OnRep_AsyncPhysicsDataComponent() {}
	public bool bPlayerIsWaiting;
	public  void ServerSetSpectatorWaiting(bool bWaiting) {}
	public  void ClientSetSpectatorWaiting(bool bWaiting) {}
	public byte NetPlayerIndex;
	public UNetConnection PendingSwapConnection;
	public UNetConnection NetConnection;
	public float InputYawScale_DEPRECATED;
	public float InputPitchScale_DEPRECATED;
	public float InputRollScale_DEPRECATED;
	public  float GetDeprecatedInputYawScale() { return default; }
	public  float GetDeprecatedInputPitchScale() { return default; }
	public  float GetDeprecatedInputRollScale() { return default; }
	public  void SetDeprecatedInputYawScale(float NewValue) {}
	public  void SetDeprecatedInputPitchScale(float NewValue) {}
	public  void SetDeprecatedInputRollScale(float NewValue) {}
	public bool bShowMouseCursor;
	public bool bEnableClickEvents;
	public bool bEnableTouchEvents;
	public bool bEnableMouseOverEvents;
	public bool bEnableTouchOverEvents;
	public bool bForceFeedbackEnabled;
	public bool bEnableMotionControls;
	public  void SetMotionControlsEnabled(bool bEnabled) {}
	public bool bEnableStreamingSource;
	public bool bStreamingSourceShouldActivate;
	public bool bStreamingSourceShouldBlockOnSlowStreaming;
	public EStreamingSourcePriority StreamingSourcePriority;
	public FColor StreamingSourceDebugColor;
	public TArray<FStreamingSourceShape> StreamingSourceShapes;
	public float ForceFeedbackScale;
	public TArray<FKey> ClickEventKeys;
	public byte DefaultMouseCursor;
	public byte CurrentMouseCursor;
	public byte DefaultClickTraceChannel;
	public byte CurrentClickTraceChannel;
	public float HitResultTraceDistance;
	public ushort SeamlessTravelCount;
	public ushort LastCompletedSeamlessTravelCount;
	public  void EnableCheats() {}
	public  void FOV(float NewFOV) {}
	public  void RestartLevel() {}
	public  void LocalTravel(string URL) {}
	public  void ServerExecRPC(string Msg) {}
	public  void ServerExec(string Msg) {}
	public  void ClientReturnToMainMenu(string ReturnReason) {}
	public  void ClientReturnToMainMenuWithTextReason(string ReturnReason) {}
	public  void ClientRepObjRef(UObject Object) {}
	public  void Pause() {}
	public  void SetName(string S) {}
	public  void SwitchLevel(string URL) {}
	public  bool GetHitResultUnderCursor(ECollisionChannel TraceChannel,bool bTraceComplex,FHitResult HitResult) { return default; }
	public  bool GetHitResultUnderCursorByChannel(ETraceTypeQuery TraceChannel,bool bTraceComplex,FHitResult HitResult) { return default; }
	public  bool GetHitResultUnderCursorForObjects(TArray<byte> ObjectTypes,bool bTraceComplex,FHitResult HitResult) { return default; }
	public  bool GetHitResultUnderFinger(ETouchIndex FingerIndex,ECollisionChannel TraceChannel,bool bTraceComplex,FHitResult HitResult) { return default; }
	public  bool GetHitResultUnderFingerByChannel(ETouchIndex FingerIndex,ETraceTypeQuery TraceChannel,bool bTraceComplex,FHitResult HitResult) { return default; }
	public  bool GetHitResultUnderFingerForObjects(ETouchIndex FingerIndex,TArray<byte> ObjectTypes,bool bTraceComplex,FHitResult HitResult) { return default; }
	public  bool DeprojectMousePositionToWorld(FVector WorldLocation,FVector WorldDirection) { return default; }
	public  bool DeprojectScreenPositionToWorld(float ScreenX,float ScreenY,FVector WorldLocation,FVector WorldDirection) { return default; }
	public  bool ProjectWorldLocationToScreen(FVector WorldLocation,FVector2D ScreenLocation,bool bPlayerViewportRelative/*=false*/) { return default; }
	public  void SetMouseLocation(int X,int Y) {}
	public  bool IsStreamingSourceEnabled() { return default; }
	public  bool StreamingSourceShouldActivate() { return default; }
	public  bool StreamingSourceShouldBlockOnSlowStreaming() { return default; }
	public  EStreamingSourcePriority GetStreamingSourcePriority() { return default; }
	public  void GetStreamingSourceLocationAndRotation(FVector OutLocation,FRotator OutRotation) {}
	public  void GetStreamingSourceShapes(TArray<FStreamingSourceShape> OutShapes) {}
	public  void StartFire(byte FireModeNum/*=0*/) {}
	public  void ClientEnableNetworkVoice(bool bEnable) {}
	public  void ClientAckUpdateLevelVisibility(string PackageName,FNetLevelVisibilityTransactionId TransactionId,bool bClientAckCanMakeVisible) {}
	public  void ToggleSpeaking(bool bInSpeaking) {}
	public  void ClientVoiceHandshakeComplete() {}
	public  void ServerMutePlayer(FUniqueNetIdRepl PlayerId) {}
	public  void ServerUnmutePlayer(FUniqueNetIdRepl PlayerId) {}
	public  void ClientMutePlayer(FUniqueNetIdRepl PlayerId) {}
	public  void ClientUnmutePlayer(FUniqueNetIdRepl PlayerId) {}
	public  void ServerBlockPlayer(FUniqueNetIdRepl PlayerId) {}
	public  void ServerUnblockPlayer(FUniqueNetIdRepl PlayerId) {}
	public  void ClientUnmutePlayers(TArray<FUniqueNetIdRepl> PlayerIds) {}
	public  void ConsoleKey(FKey Key) {}
	public  void SendToConsole(string Command) {}
	public  void ClientAddTextureStreamingLoc(FVector InLoc,float Duration,bool bOverrideLocation) {}
	public  void ClientCancelPendingMapChange() {}
	public  void ClientCapBandwidth(int Cap) {}
	public  void ClientCommitMapChange() {}
	public  void ClientFlushLevelStreaming() {}
	public  void ClientForceGarbageCollection() {}
	public  void ClientGameEnded(AActor EndGameFocus,bool bIsWinner) {}
	public  void ClientGotoState(string NewState) {}
	public  void ClientIgnoreLookInput(bool bIgnore) {}
	public  void ClientIgnoreMoveInput(bool bIgnore) {}
	public  void ClientMessage(string S,string Type,float MsgLifeTime) {}
	public  void ClientStartCameraShake(UClass Shake,float Scale/*=1.0f*/,ECameraShakePlaySpace PlaySpace/*=ECameraShakePlaySpace.CameraLocal*/,FRotator UserPlaySpaceRot/*=FRotator.ZeroRotator*/) {}
	public  void ClientStartCameraShakeFromSource(UClass Shake,UCameraShakeSourceComponent SourceComponent) {}
	public  void ClientPlaySound(USoundBase Sound,float VolumeMultiplier,float PitchMultiplier) {}
	public  void ClientPlaySoundAtLocation(USoundBase Sound,FVector Location,float VolumeMultiplier,float PitchMultiplier) {}
	public  void ClientPrepareMapChange(string LevelName,bool bFirst,bool bLast) {}
	public  void ClientPrestreamTextures(AActor ForcedActor,float ForceDuration,bool bEnableStreaming,int CinematicTextureGroups) {}
	public  void ClientReset() {}
	public  void ClientRestart(APawn NewPawn) {}
	public  void ClientSetBlockOnAsyncLoading() {}
	public  void ClientSetCameraFade(bool bEnableFading,FColor FadeColor,FVector2D FadeAlpha,float FadeTime,bool bFadeAudio,bool bHoldWhenFinished) {}
	public  void ClientSetCameraMode(string NewCamMode) {}
	public  void ClientSetCinematicMode(bool bInCinematicMode,bool bAffectsMovement,bool bAffectsTurning,bool bAffectsHUD) {}
	public  void ClientSetForceMipLevelsToBeResident(UMaterialInterface Material,float ForceDuration,int CinematicTextureGroups) {}
	public  void ClientSetHUD(UClass NewHUDClass) {}
	public  void GetViewportSize(int SizeX,int SizeY) {}
	public  AHUD GetHUD() { return default; }
	public  void SetMouseCursorWidget(EMouseCursor Cursor,UUserWidget CursorWidget) {}
	public  void ClientSetViewTarget(AActor A,FViewTargetTransitionParams TransitionParams) {}
	public  void ClientSpawnGenericCameraLensEffect(UClass LensEffectEmitterClass) {}
	public  void ClientSpawnCameraLensEffect(UClass LensEffectEmitterClass) {}
	public  void ClientClearCameraLensEffects() {}
	public  void ClientStopCameraShake(UClass Shake,bool bImmediately/*=true*/) {}
	public  void ClientStopCameraShakesFromSource(UCameraShakeSourceComponent SourceComponent,bool bImmediately/*=true*/) {}
	public  void K2_ClientPlayForceFeedback(UForceFeedbackEffect ForceFeedbackEffect,string Tag,bool bLooping,bool bIgnoreTimeDilation,bool bPlayWhilePaused) {}
	public  void ClientPlayForceFeedback_Internal(UForceFeedbackEffect ForceFeedbackEffect,FForceFeedbackParameters Params) {}
	public  void ClientStopForceFeedback(UForceFeedbackEffect ForceFeedbackEffect,string Tag) {}
	public  void PlayDynamicForceFeedback(float Intensity,float Duration,bool bAffectsLeftLarge,bool bAffectsLeftSmall,bool bAffectsRightLarge,bool bAffectsRightSmall,byte Action,FLatentActionInfo LatentInfo) {}
	public  void TestServerLevelVisibilityChange(string PackageName,string FileName) {}
	public  void PlayHapticEffect(UHapticFeedbackEffect_Base HapticEffect,EControllerHand Hand,float Scale/*=1.0f*/,bool bLoop/*=false*/) {}
	public  void StopHapticEffect(EControllerHand Hand) {}
	public  void SetHapticsByValue(float Frequency,float Amplitude,EControllerHand Hand) {}
	public  void SetDisableHaptics(bool bNewDisabled) {}
	public  void SetControllerLightColor(FColor Color) {}
	public  void ResetControllerLightColor() {}
	public  void ClientTravel(string URL,ETravelType TravelType,bool bSeamless,FGuid MapPackageGuid) {}
	public  void ClientTravelInternal(string URL,ETravelType TravelType,bool bSeamless,FGuid MapPackageGuid) {}
	public  void ClientUpdateLevelStreamingStatus(string PackageName,bool bNewShouldBeLoaded,bool bNewShouldBeVisible,bool bNewShouldBlockOnLoad,int LODIndex,FNetLevelVisibilityTransactionId TransactionId,bool bNewShouldBlockOnUnload) {}
	public  void ClientUpdateMultipleLevelsStreamingStatus(TArray<FUpdateLevelStreamingLevelStatus> LevelStatuses) {}
	public  void ClientWasKicked(string KickReason) {}
	public  void ClientStartOnlineSession() {}
	public  void ClientEndOnlineSession() {}
	public  void ClientRetryClientRestart(APawn NewPawn) {}
	public  void ClientReceiveLocalizedMessage(UClass Message,int Switch,APlayerState RelatedPlayerState_1,APlayerState RelatedPlayerState_2,UObject OptionalObject) {}
	public  void ServerAcknowledgePossession(APawn P) {}
	public  void ServerCamera(string NewMode) {}
	public  void ServerChangeName(string S) {}
	public  void ServerNotifyLoadedWorld(string WorldPackageName) {}
	public  void ServerPause() {}
	public  void ServerRestartPlayer() {}
	public  void ServerSetSpectatorLocation(FVector NewLoc,FRotator NewRot) {}
	public  void ServerCheckClientPossession() {}
	public  void ServerCheckClientPossessionReliable() {}
	public  void ServerShortTimeout() {}
	public  void ServerUpdateCamera(FVector_NetQuantize CamLoc,int CamPitchAndYaw) {}
	public  void ServerUpdateLevelVisibility(FUpdateLevelVisibilityLevelInfo LevelVisibility) {}
	public  void ServerUpdateMultipleLevelsVisibility(TArray<FUpdateLevelVisibilityLevelInfo> LevelVisibilities) {}
	public  void ServerVerifyViewTarget() {}
	public  void ServerViewNextPlayer() {}
	public  void ServerViewPrevPlayer() {}
	public  void ServerViewSelf(FViewTargetTransitionParams TransitionParams) {}
	public  void ClientTeamMessage(APlayerState SenderPlayerState,string S,string Type,float MsgLifeTime) {}
	public  void ServerToggleAILogging() {}
	public  void AddPitchInput(float Val) {}
	public  void AddYawInput(float Val) {}
	public  void AddRollInput(float Val) {}
	public  bool IsInputKeyDown(FKey Key) { return default; }
	public  bool WasInputKeyJustPressed(FKey Key) { return default; }
	public  bool WasInputKeyJustReleased(FKey Key) { return default; }
	public  float GetInputAnalogKeyState(FKey Key) { return default; }
	public  FVector GetInputVectorKeyState(FKey Key) { return default; }
	public  void GetInputTouchState(ETouchIndex FingerIndex,float LocationX,float LocationY,bool bIsCurrentlyPressed) {}
	public  void GetInputMotionState(FVector Tilt,FVector RotationRate,FVector Gravity,FVector Acceleration) {}
	public  bool GetMousePosition(float LocationX,float LocationY) { return default; }
	public  float GetInputKeyTimeDown(FKey Key) { return default; }
	public  void GetInputMouseDelta(float DeltaX,float DeltaY) {}
	public  void GetInputAnalogStickState(EControllerAnalogStick WhichStick,float StickX,float StickY) {}
	public  void ActivateTouchInterface(UTouchInterface NewTouchInterface) {}
	public  void SetVirtualJoystickVisibility(bool bVisible) {}
	public  void Camera(string NewMode) {}
	public  void SetViewTargetWithBlend(AActor NewViewTarget,float BlendTime/*=0f*/,EViewTargetBlendFunction BlendFunc/*=VTBlend_Linear*/,float BlendExp/*=0f*/,bool bLockOutgoing/*=false*/) {}
	public UInputComponent InactiveStateInputComponent;
	public bool bShouldPerformFullTickWhenPaused;
	public UTouchInterface CurrentTouchInterface;
	public UClass OverridePlayerInputClass;
	public  UClass GetOverridePlayerInputClass() { return default; }
	public  FPlatformUserId GetPlatformUserId() { return default; }
	public  void SetAudioListenerOverride(USceneComponent AttachToComponent,FVector Location,FRotator Rotation) {}
	public  void ClearAudioListenerOverride() {}
	public  void SetAudioListenerAttenuationOverride(USceneComponent AttachToComponent,FVector AttenuationLocationOVerride) {}
	public  void ClearAudioListenerAttenuationOverride() {}
	public  bool CanRestartPlayer() { return default; }
	public  void SetCinematicMode(bool bInCinematicMode,bool bHidePlayer,bool bAffectsHUD,bool bAffectsMovement,bool bAffectsTurning) {}
	public  void OnServerStartedVisualLogger(bool bIsLogging) {}
	public  ASpectatorPawn GetSpectatorPawn() { return default; }
	public  FVector GetFocalLocation() { return default; }
	public ASpectatorPawn SpectatorPawn;
	public bool bIsLocalPlayerController;
	public FVector SpawnLocation;
	public  void ServerRecvClientInputFrame(int RecvClientInputFrame,TArray<byte> Data) {}
	public  void ClientRecvServerAckFrame(int LastProcessedInputFrame,int RecvServerFrameNumber,short TimeDilation) {}
	public  void ClientRecvServerAckFrameDebug(byte NumBuffered,float TargetNumBufferedCmds) {}
	public  void ServerSendLatestAsyncPhysicsTimestamp(FAsyncPhysicsTimestamp Timestamp) {}
	public  void ClientCorrectionAsyncPhysicsTimestamp(FAsyncPhysicsTimestamp Timestamp) {}
	public  void ClientAckTimeDilation(float TimeDilation,int ServerStep) {}
}
