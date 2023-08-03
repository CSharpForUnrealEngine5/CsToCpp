#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>PlayerControllers are used by human players to control Pawns.</summary>
[CppInclude("GameFramework/PlayerController.h")]
public partial class APlayerController : AController {
	public static UClass StaticClass() {return default;}
	///<summary>UPlayer associated with this PlayerController.  Could be a local player or a net connection.</summary>
	public UPlayer Player;
	///<summary>Used in net games so client can acknowledge it possessed a specific pawn.</summary>
	public APawn AcknowledgedPawn;
	///<summary>Heads up display associated with this PlayerController.</summary>
	public AHUD MyHUD;
	///<summary>Camera manager associated with this Player Controller.</summary>
	public APlayerCameraManager PlayerCameraManager;
	///<summary>PlayerCamera class should be set for each game, otherwise Engine.PlayerCameraManager is used</summary>
	public UClass PlayerCameraManagerClass;
	///<summary>True to allow this player controller to manage the camera target for you,</summary>
	public bool bAutoManageActiveCameraTarget;
	///<summary>Used to replicate the view rotation of targets not owned/possessed by this PlayerController.</summary>
	public FRotator TargetViewRotation;
	///<summary>Interp speed for blending remote view rotation for smoother client updates</summary>
	public float SmoothTargetViewRotationSpeed;
	///<summary>The actors which the camera shouldn&#39;t see - e.g. used to hide actors which the camera penetrates</summary>
	public TArray<AActor> HiddenActors;
	///<summary>Explicit components the camera shouldn&#39;t see (helpful for external systems to hide a component from a single player)</summary>
	public TArray<TWeakObjectPtr<UPrimitiveComponent>> HiddenPrimitiveComponents;
	///<summary>Used to make sure the client is kept synchronized when in a spectator state</summary>
	public float LastSpectatorStateSynchTime;
	///<summary>Last location synced on the server for a spectator.</summary>
	public FVector LastSpectatorSyncLocation;
	///<summary>Last rotation synced on the server for a spectator.</summary>
	public FRotator LastSpectatorSyncRotation;
	///<summary>Cap set by server on bandwidth from client to server in bytes/sec (only has impact if &gt;=2600)</summary>
	public int ClientCap;
	///<summary>Object that manages &quot;cheat&quot; commands.</summary>
	public UCheatManager CheatManager;
	///<summary>Class of my CheatManager.</summary>
	public UClass CheatClass;
	///<summary>Object that manages player input.</summary>
	public UPlayerInput PlayerInput;
	///<summary>ActiveForceFeedbackEffects</summary>
	public TArray<FActiveForceFeedbackEffect> ActiveForceFeedbackEffects;
	///<summary>The type of async physics data object to use</summary>
	public UClass AsyncPhysicsDataClass;
	///<summary>Get the async physics data to write to. This data will make its way to the async physics tick on client and server. Should not be used during async tick</summary>
	public  UAsyncPhysicsData GetAsyncPhysicsDataToWrite() { return default; }
	///<summary>Get the async physics data to execute logic off of. This data should not be modified and will NOT make its way back. Must be used during async tick</summary>
	public  UAsyncPhysicsData GetAsyncPhysicsDataToConsume() { return default; }
	///<summary>AsyncPhysicsDataComponent</summary>
	public UAsyncPhysicsInputComponent AsyncPhysicsDataComponent;
	///<summary>OnRep_AsyncPhysicsDataComponent</summary>
	public  void OnRep_AsyncPhysicsDataComponent() {}
	///<summary>True if PlayerController is currently waiting for the match to start or to respawn. Only valid in Spectating state.</summary>
	public bool bPlayerIsWaiting;
	///<summary>Indicate that the Spectator is waiting to join/respawn.</summary>
	public  void ServerSetSpectatorWaiting(bool bWaiting) {}
	///<summary>Indicate that the Spectator is waiting to join/respawn.</summary>
	public  void ClientSetSpectatorWaiting(bool bWaiting) {}
	///<summary>Index identifying players using the same base connection (splitscreen clients)</summary>
	public byte NetPlayerIndex;
	///<summary>This is set on the OLD PlayerController when performing a swap over a network connection</summary>
	public UNetConnection PendingSwapConnection;
	///<summary>The net connection this controller is communicating on, nullptr for local players on server</summary>
	public UNetConnection NetConnection;
	///<summary>Yaw input speed scaling</summary>
	public float InputYawScale_DEPRECATED;
	///<summary>Pitch input speed scaling</summary>
	public float InputPitchScale_DEPRECATED;
	///<summary>Roll input speed scaling</summary>
	public float InputRollScale_DEPRECATED;
	///<summary>GetDeprecatedInputYawScale</summary>
	public  float GetDeprecatedInputYawScale() { return default; }
	///<summary>GetDeprecatedInputPitchScale</summary>
	public  float GetDeprecatedInputPitchScale() { return default; }
	///<summary>GetDeprecatedInputRollScale</summary>
	public  float GetDeprecatedInputRollScale() { return default; }
	///<summary>SetDeprecatedInputYawScale</summary>
	public  void SetDeprecatedInputYawScale(float NewValue) {}
	///<summary>SetDeprecatedInputPitchScale</summary>
	public  void SetDeprecatedInputPitchScale(float NewValue) {}
	///<summary>SetDeprecatedInputRollScale</summary>
	public  void SetDeprecatedInputRollScale(float NewValue) {}
	///<summary>Whether the mouse cursor should be displayed.</summary>
	public bool bShowMouseCursor;
	///<summary>Whether actor/component click events should be generated.</summary>
	public bool bEnableClickEvents;
	///<summary>Whether actor/component touch events should be generated.</summary>
	public bool bEnableTouchEvents;
	///<summary>Whether actor/component mouse over events should be generated.</summary>
	public bool bEnableMouseOverEvents;
	///<summary>Whether actor/component touch over events should be generated.</summary>
	public bool bEnableTouchOverEvents;
	///<summary>bForceFeedbackEnabled</summary>
	public bool bForceFeedbackEnabled;
	///<summary>Whether or not to consider input from motion sources (tilt, acceleration, etc)</summary>
	public bool bEnableMotionControls;
	///<summary>SetMotionControlsEnabled</summary>
	public  void SetMotionControlsEnabled(bool bEnabled) {}
	///<summary>Whether the PlayerController should be used as a World Partiton streaming source.</summary>
	public bool bEnableStreamingSource;
	///<summary>Whether the PlayerController streaming source should activate cells after loading.</summary>
	public bool bStreamingSourceShouldActivate;
	///<summary>Whether the PlayerController streaming source should block on slow streaming.</summary>
	public bool bStreamingSourceShouldBlockOnSlowStreaming;
	///<summary>PlayerController streaming source priority.</summary>
	public EStreamingSourcePriority StreamingSourcePriority;
	///<summary>Color used for debugging.</summary>
	public FColor StreamingSourceDebugColor;
	///<summary>Optional aggregated shape list used to build a custom shape for the streaming source. When empty, fallbacks sphere shape with a radius equal to grid&#39;s loading range.</summary>
	public TArray<FStreamingSourceShape> StreamingSourceShapes;
	///<summary>Scale applied to force feedback values</summary>
	public float ForceFeedbackScale;
	///<summary>List of keys that will cause click events to be forwarded, default to left click</summary>
	public TArray<FKey> ClickEventKeys;
	///<summary>Type of mouse cursor to show by default</summary>
	public EMouseCursor DefaultMouseCursor;
	///<summary>Currently visible mouse cursor</summary>
	public EMouseCursor CurrentMouseCursor;
	///<summary>Default trace channel used for determining what world object was clicked on.</summary>
	public ECollisionChannel DefaultClickTraceChannel;
	///<summary>Trace channel currently being used for determining what world object was clicked on.</summary>
	public ECollisionChannel CurrentClickTraceChannel;
	///<summary>Distance to trace when computing click events</summary>
	public float HitResultTraceDistance;
	///<summary>Counter for this players seamless travels (used along with the below value, to restrict ServerNotifyLoadedWorld)</summary>
	public ushort SeamlessTravelCount;
	///<summary>The value of SeamlessTravelCount, upon the last call to GameModeBase::HandleSeamlessTravelPlayer; used to detect seamless travel</summary>
	public ushort LastCompletedSeamlessTravelCount;
	///<summary>Run from the console to try and manually enable cheats which are disabled by default in multiplayer, games can override this</summary>
	public  void EnableCheats() {}
	///<summary>Set the field of view to NewFOV</summary>
	public  void FOV(float NewFOV) {}
	///<summary>Restarts the current level</summary>
	public  void RestartLevel() {}
	///<summary>Causes the client to travel to the given URL</summary>
	public  void LocalTravel(string URL) {}
	///<summary>RPC used by ServerExec. Not intended to be called directly</summary>
	public  void ServerExecRPC(string Msg) {}
	///<summary>Executes command on server (non shipping builds only)</summary>
	public  void ServerExec(string Msg) {}
	///<summary>ClientReturnToMainMenu</summary>
	public  void ClientReturnToMainMenu(string ReturnReason) {}
	///<summary>Return the client to the main menu gracefully</summary>
	public  void ClientReturnToMainMenuWithTextReason(string ReturnReason) {}
	///<summary>Development RPC for testing object reference replication</summary>
	public  void ClientRepObjRef(UObject Object) {}
	///<summary>Command to try to pause the game.</summary>
	public  void Pause() {}
	///<summary>Tries to set the player&#39;s name to the given name.</summary>
	public  void SetName(string S) {}
	///<summary>SwitchLevel to the given MapURL.</summary>
	public  void SwitchLevel(string URL) {}
	///<summary>GetHitResultUnderCursor</summary>
	public  bool GetHitResultUnderCursor(ECollisionChannel TraceChannel,bool bTraceComplex,FHitResult HitResult) { return default; }
	///<summary>Performs a collision query under the mouse cursor, looking on a trace channel</summary>
	public  bool GetHitResultUnderCursorByChannel(ETraceTypeQuery TraceChannel,bool bTraceComplex,FHitResult HitResult) { return default; }
	///<summary>Performs a collision query under the mouse cursor, looking for object types</summary>
	public  bool GetHitResultUnderCursorForObjects(TArray<EObjectTypeQuery> ObjectTypes,bool bTraceComplex,FHitResult HitResult) { return default; }
	///<summary>GetHitResultUnderFinger</summary>
	public  bool GetHitResultUnderFinger(ETouchIndex FingerIndex,ECollisionChannel TraceChannel,bool bTraceComplex,FHitResult HitResult) { return default; }
	///<summary>Performs a collision query under the finger, looking on a trace channel</summary>
	public  bool GetHitResultUnderFingerByChannel(ETouchIndex FingerIndex,ETraceTypeQuery TraceChannel,bool bTraceComplex,FHitResult HitResult) { return default; }
	///<summary>Performs a collision query under the finger, looking for object types</summary>
	public  bool GetHitResultUnderFingerForObjects(ETouchIndex FingerIndex,TArray<EObjectTypeQuery> ObjectTypes,bool bTraceComplex,FHitResult HitResult) { return default; }
	///<summary>Convert current mouse 2D position to World Space 3D position and direction. Returns false if unable to determine value. *</summary>
	public  bool DeprojectMousePositionToWorld(FVector WorldLocation,FVector WorldDirection) { return default; }
	///<summary>Convert 2D screen position to World Space 3D position and direction. Returns false if unable to determine value. *</summary>
	public  bool DeprojectScreenPositionToWorld(float ScreenX,float ScreenY,FVector WorldLocation,FVector WorldDirection) { return default; }
	///<summary>Convert a World Space 3D position into a 2D Screen Space position.</summary>
	public  bool ProjectWorldLocationToScreen(FVector WorldLocation,FVector2D ScreenLocation,bool bPlayerViewportRelative/*=false*/) { return default; }
	///<summary>Positions the mouse cursor in screen space, in pixels.</summary>
	public  void SetMouseLocation(int X,int Y) {}
	///<summary>Whether the PlayerController should be used as a World Partiton streaming source.</summary>
	public  bool IsStreamingSourceEnabled() { return default; }
	///<summary>Whether the PlayerController streaming source should activate cells after loading.</summary>
	public  bool StreamingSourceShouldActivate() { return default; }
	///<summary>Whether the PlayerController streaming source should block on slow streaming.</summary>
	public  bool StreamingSourceShouldBlockOnSlowStreaming() { return default; }
	///<summary>Gets the streaming source priority.</summary>
	public  EStreamingSourcePriority GetStreamingSourcePriority() { return default; }
	///<summary>Gets the streaming source location and rotation.</summary>
	public  void GetStreamingSourceLocationAndRotation(FVector OutLocation,FRotator OutRotation) {}
	///<summary>Gets the streaming source priority.</summary>
	public  void GetStreamingSourceShapes(TArray<FStreamingSourceShape> OutShapes) {}
	///<summary>Fire the player&#39;s currently selected weapon with the optional firemode.</summary>
	public  void StartFire(byte FireModeNum/*=0*/) {}
	///<summary>Tell the client to enable or disable voice chat (not muting)</summary>
	public  void ClientEnableNetworkVoice(bool bEnable) {}
	///<summary>Acknowledge received LevelVisibilityTransactionId</summary>
	public  void ClientAckUpdateLevelVisibility(string PackageName,FNetLevelVisibilityTransactionId TransactionId,bool bClientAckCanMakeVisible) {}
	///<summary>Toggle voice chat on and off</summary>
	public  void ToggleSpeaking(bool bInSpeaking) {}
	///<summary>Tells the client that the server has all the information it needs and that it</summary>
	public  void ClientVoiceHandshakeComplete() {}
	///<summary>Tell the server to mute a player for this controller</summary>
	public  void ServerMutePlayer(FUniqueNetIdRepl PlayerId) {}
	///<summary>Tell the server to unmute a player for this controller</summary>
	public  void ServerUnmutePlayer(FUniqueNetIdRepl PlayerId) {}
	///<summary>Tell the client to mute a player for this controller</summary>
	public  void ClientMutePlayer(FUniqueNetIdRepl PlayerId) {}
	///<summary>Tell the client to unmute a player for this controller</summary>
	public  void ClientUnmutePlayer(FUniqueNetIdRepl PlayerId) {}
	///<summary>Tell the client to block a player for this controller</summary>
	public  void ServerBlockPlayer(FUniqueNetIdRepl PlayerId) {}
	///<summary>Tell the client to unblock a player for this controller</summary>
	public  void ServerUnblockPlayer(FUniqueNetIdRepl PlayerId) {}
	///<summary>Tell the client to unmute an array of players for this controller</summary>
	public  void ClientUnmutePlayers(TArray<FUniqueNetIdRepl> PlayerIds) {}
	///<summary>Console control commands, useful when remote debugging so you can&#39;t touch the console the normal way</summary>
	public  void ConsoleKey(FKey Key) {}
	///<summary>Sends a command to the console to execute if not shipping version</summary>
	public  void SendToConsole(string Command) {}
	///<summary>Adds a location to the texture streaming system for the specified duration.</summary>
	public  void ClientAddTextureStreamingLoc(FVector InLoc,float Duration,bool bOverrideLocation) {}
	///<summary>Tells client to cancel any pending map change.</summary>
	public  void ClientCancelPendingMapChange() {}
	///<summary>Set CurrentNetSpeed to the lower of its current value and Cap.</summary>
	public  void ClientCapBandwidth(int Cap) {}
	///<summary>Actually performs the level transition prepared by PrepareMapChange().</summary>
	public  void ClientCommitMapChange() {}
	///<summary>Tells the client to block until all pending level streaming actions are complete</summary>
	public  void ClientFlushLevelStreaming() {}
	///<summary>Forces GC at the end of the tick on the client</summary>
	public  void ClientForceGarbageCollection() {}
	///<summary>Replicated function called by GameHasEnded().</summary>
	public  void ClientGameEnded(AActor EndGameFocus,bool bIsWinner) {}
	///<summary>Server uses this to force client into NewState .</summary>
	public  void ClientGotoState(string NewState) {}
	///<summary>Calls IgnoreLookInput on client</summary>
	public  void ClientIgnoreLookInput(bool bIgnore) {}
	///<summary>Calls IgnoreMoveInput on client</summary>
	public  void ClientIgnoreMoveInput(bool bIgnore) {}
	///<summary>Outputs a message to HUD</summary>
	public  void ClientMessage(string S,string Type,float MsgLifeTime) {}
	///<summary>Play Camera Shake</summary>
	public  void ClientStartCameraShake(UClass Shake,float Scale/*=1.0f*/,ECameraShakePlaySpace PlaySpace/*=ECameraShakePlaySpace.CameraLocal*/,FRotator UserPlaySpaceRot/*=FRotator.ZeroRotator*/) {}
	///<summary>Play Camera Shake localized to a given source</summary>
	public  void ClientStartCameraShakeFromSource(UClass Shake,UCameraShakeSourceComponent SourceComponent) {}
	///<summary>Play sound client-side (so only the client will hear it)</summary>
	public  void ClientPlaySound(USoundBase Sound,float VolumeMultiplier,float PitchMultiplier) {}
	///<summary>Play sound client-side at the specified location</summary>
	public  void ClientPlaySoundAtLocation(USoundBase Sound,FVector Location,float VolumeMultiplier,float PitchMultiplier) {}
	///<summary>Asynchronously loads the given level in preparation for a streaming map transition.</summary>
	public  void ClientPrepareMapChange(string LevelName,bool bFirst,bool bLast) {}
	///<summary>Forces the streaming system to disregard the normal logic for the specified duration and</summary>
	public  void ClientPrestreamTextures(AActor ForcedActor,float ForceDuration,bool bEnableStreaming,int CinematicTextureGroups) {}
	///<summary>Tell client to reset the PlayerController</summary>
	public  void ClientReset() {}
	///<summary>Tell client to restart the level</summary>
	public  void ClientRestart(APawn NewPawn) {}
	///<summary>Tells the client to block until all pending level streaming actions are complete.</summary>
	public  void ClientSetBlockOnAsyncLoading() {}
	///<summary>Tell client to fade camera</summary>
	public  void ClientSetCameraFade(bool bEnableFading,FColor FadeColor,FVector2D FadeAlpha,float FadeTime,bool bFadeAudio,bool bHoldWhenFinished) {}
	///<summary>Replicated function to set camera style on client</summary>
	public  void ClientSetCameraMode(string NewCamMode) {}
	///<summary>Called by the server to synchronize cinematic transitions with the client</summary>
	public  void ClientSetCinematicMode(bool bInCinematicMode,bool bAffectsMovement,bool bAffectsTurning,bool bAffectsHUD) {}
	///<summary>Forces the streaming system to disregard the normal logic for the specified duration and</summary>
	public  void ClientSetForceMipLevelsToBeResident(UMaterialInterface Material,float ForceDuration,int CinematicTextureGroups) {}
	///<summary>Set the client&#39;s class of HUD and spawns a new instance of it. If there was already a HUD active, it is destroyed.</summary>
	public  void ClientSetHUD(UClass NewHUDClass) {}
	///<summary>Helper to get the size of the HUD canvas for this player controller.  Returns 0 if there is no HUD</summary>
	public  void GetViewportSize(int SizeX,int SizeY) {}
	///<summary>Gets the HUD currently being used by this player controller</summary>
	public  AHUD GetHUD() { return default; }
	///<summary>Sets the Widget for the Mouse Cursor to display</summary>
	public  void SetMouseCursorWidget(EMouseCursor Cursor,UUserWidget CursorWidget) {}
	///<summary>Set the view target</summary>
	public  void ClientSetViewTarget(AActor A,FViewTargetTransitionParams TransitionParams) {}
	///<summary>Spawn a camera lens effect (e.g. blood).</summary>
	public  void ClientSpawnGenericCameraLensEffect(UClass LensEffectEmitterClass) {}
	///<summary>ClientSpawnCameraLensEffect</summary>
	public  void ClientSpawnCameraLensEffect(UClass LensEffectEmitterClass) {}
	///<summary>Removes all Camera Lens Effects.</summary>
	public  void ClientClearCameraLensEffects() {}
	///<summary>Stop camera shake on client.</summary>
	public  void ClientStopCameraShake(UClass Shake,bool bImmediately/*=true*/) {}
	///<summary>Stop camera shake on client.</summary>
	public  void ClientStopCameraShakesFromSource(UCameraShakeSourceComponent SourceComponent,bool bImmediately/*=true*/) {}
	///<summary>Play a force feedback pattern on the player&#39;s controller</summary>
	public  void K2_ClientPlayForceFeedback(UForceFeedbackEffect ForceFeedbackEffect,string Tag,bool bLooping,bool bIgnoreTimeDilation,bool bPlayWhilePaused) {}
	///<summary>Internal replicated version of client play force feedback event.</summary>
	public  void ClientPlayForceFeedback_Internal(UForceFeedbackEffect ForceFeedbackEffect,FForceFeedbackParameters Params) {}
	///<summary>Stops a playing force feedback pattern</summary>
	public  void ClientStopForceFeedback(UForceFeedbackEffect ForceFeedbackEffect,string Tag) {}
	///<summary>Latent action that controls the playing of force feedback</summary>
	public  void PlayDynamicForceFeedback(float Intensity,float Duration,bool bAffectsLeftLarge,bool bAffectsLeftSmall,bool bAffectsRightLarge,bool bAffectsRightSmall,EDynamicForceFeedbackAction Action,FLatentActionInfo LatentInfo) {}
	///<summary>TestServerLevelVisibilityChange</summary>
	public  void TestServerLevelVisibilityChange(string PackageName,string FileName) {}
	///<summary>Play a haptic feedback curve on the player&#39;s controller</summary>
	public  void PlayHapticEffect(UHapticFeedbackEffect_Base HapticEffect,EControllerHand Hand,float Scale/*=1.0f*/,bool bLoop/*=false*/) {}
	///<summary>Stops a playing haptic feedback curve</summary>
	public  void StopHapticEffect(EControllerHand Hand) {}
	///<summary>Sets the value of the haptics for the specified hand directly, using frequency and amplitude.  NOTE:  If a curve is already</summary>
	public  void SetHapticsByValue(float Frequency,float Amplitude,EControllerHand Hand) {}
	///<summary>Allows the player controller to disable all haptic requests from being fired, e.g. in the case of a level loading</summary>
	public  void SetDisableHaptics(bool bNewDisabled) {}
	///<summary>Sets the light color of the player&#39;s controller</summary>
	public  void SetControllerLightColor(FColor Color) {}
	///<summary>Resets the light color of the player&#39;s controller to default</summary>
	public  void ResetControllerLightColor() {}
	///<summary>Travel to a different map or IP address. Calls the PreClientTravel event before doing anything.</summary>
	public  void ClientTravel(string URL,ETravelType TravelType,bool bSeamless,FGuid MapPackageGuid) {}
	///<summary>Internal clientside implementation of ClientTravel - use ClientTravel to call this</summary>
	public  void ClientTravelInternal(string URL,ETravelType TravelType,bool bSeamless,FGuid MapPackageGuid) {}
	///<summary>Replicated Update streaming status</summary>
	public  void ClientUpdateLevelStreamingStatus(string PackageName,bool bNewShouldBeLoaded,bool bNewShouldBeVisible,bool bNewShouldBlockOnLoad,int LODIndex,FNetLevelVisibilityTransactionId TransactionId,bool bNewShouldBlockOnUnload) {}
	///<summary>Replicated Update streaming status.  This version allows for the streaming state of many levels to be sent in a single RPC.</summary>
	public  void ClientUpdateMultipleLevelsStreamingStatus(TArray<FUpdateLevelStreamingLevelStatus> LevelStatuses) {}
	///<summary>Notify client they were kicked from the server</summary>
	public  void ClientWasKicked(string KickReason) {}
	///<summary>Notify client that the session is starting</summary>
	public  void ClientStartOnlineSession() {}
	///<summary>Notify client that the session is about to start</summary>
	public  void ClientEndOnlineSession() {}
	///<summary>Assign Pawn to player, but avoid calling ClientRestart if we have already accepted this pawn</summary>
	public  void ClientRetryClientRestart(APawn NewPawn) {}
	///<summary>send client localized message id</summary>
	public  void ClientReceiveLocalizedMessage(UClass Message,int Switch,APlayerState RelatedPlayerState_1,APlayerState RelatedPlayerState_2,UObject OptionalObject) {}
	///<summary>acknowledge possession of pawn</summary>
	public  void ServerAcknowledgePossession(APawn P) {}
	///<summary>change mode of camera</summary>
	public  void ServerCamera(string NewMode) {}
	///<summary>Change name of server</summary>
	public  void ServerChangeName(string S) {}
	///<summary>Called to notify the server when the client has loaded a new world via seamless traveling</summary>
	public  void ServerNotifyLoadedWorld(string WorldPackageName) {}
	///<summary>Replicate pause request to the server</summary>
	public  void ServerPause() {}
	///<summary>Attempts to restart this player, generally called from the client upon respawn request.</summary>
	public  void ServerRestartPlayer() {}
	///<summary>When spectating, updates spectator location/rotation and pings the server to make sure spectating should continue.</summary>
	public  void ServerSetSpectatorLocation(FVector NewLoc,FRotator NewRot) {}
	///<summary>Tells the server to make sure the possessed pawn is in sync with the client.</summary>
	public  void ServerCheckClientPossession() {}
	///<summary>Reliable version of ServerCheckClientPossession to be used when there is no likely danger of spamming the network.</summary>
	public  void ServerCheckClientPossessionReliable() {}
	///<summary>Notifies the server that the client has ticked gameplay code, and should no longer get the extended &quot;still loading&quot; timeout grace period</summary>
	public  void ServerShortTimeout() {}
	///<summary>If PlayerCamera.bUseClientSideCameraUpdates is set, client will replicate camera positions to the server. // @TODO - combine pitch/yaw into one int, maybe also send location compressed</summary>
	public  void ServerUpdateCamera(FVector_NetQuantize CamLoc,int CamPitchAndYaw) {}
	///<summary>Called when the client adds/removes a streamed level.</summary>
	public  void ServerUpdateLevelVisibility(FUpdateLevelVisibilityLevelInfo LevelVisibility) {}
	///<summary>Called when the client adds/removes a streamed level.  This version of the function allows you to pass the state of</summary>
	public  void ServerUpdateMultipleLevelsVisibility(TArray<FUpdateLevelVisibilityLevelInfo> LevelVisibilities) {}
	///<summary>Used by client to request server to confirm current viewtarget (server will respond with ClientSetViewTarget() ).</summary>
	public  void ServerVerifyViewTarget() {}
	///<summary>Move camera to next player on round ended or spectating</summary>
	public  void ServerViewNextPlayer() {}
	///<summary>Move camera to previous player on round ended or spectating</summary>
	public  void ServerViewPrevPlayer() {}
	///<summary>Move camera to current user</summary>
	public  void ServerViewSelf(FViewTargetTransitionParams TransitionParams) {}
	///<summary>@todo document</summary>
	public  void ClientTeamMessage(APlayerState SenderPlayerState,string S,string Type,float MsgLifeTime) {}
	///<summary>Used by UGameplayDebuggingControllerComponent to replicate messages for AI debugging in network games.</summary>
	public  void ServerToggleAILogging() {}
	///<summary>Add Pitch (look up) input. This value is multiplied by InputPitchScale.</summary>
	public  void AddPitchInput(float Val) {}
	///<summary>Add Yaw (turn) input. This value is multiplied by InputYawScale.</summary>
	public  void AddYawInput(float Val) {}
	///<summary>Add Roll input. This value is multiplied by InputRollScale.</summary>
	public  void AddRollInput(float Val) {}
	///<summary>Returns true if the given key/button is pressed on the input of the controller (if present)</summary>
	public  bool IsInputKeyDown(FKey Key) { return default; }
	///<summary>Returns true if the given key/button was up last frame and down this frame.</summary>
	public  bool WasInputKeyJustPressed(FKey Key) { return default; }
	///<summary>Returns true if the given key/button was down last frame and up this frame.</summary>
	public  bool WasInputKeyJustReleased(FKey Key) { return default; }
	///<summary>Returns the analog value for the given key/button.  If analog isn&#39;t supported, returns 1 for down and 0 for up.</summary>
	public  float GetInputAnalogKeyState(FKey Key) { return default; }
	///<summary>Returns the vector value for the given key/button.</summary>
	public  FVector GetInputVectorKeyState(FKey Key) { return default; }
	///<summary>Retrieves the X and Y screen coordinates of the specified touch key. Returns false if the touch index is not down</summary>
	public  void GetInputTouchState(ETouchIndex FingerIndex,float LocationX,float LocationY,bool bIsCurrentlyPressed) {}
	///<summary>Retrieves the current motion state of the player&#39;s input device</summary>
	public  void GetInputMotionState(FVector Tilt,FVector RotationRate,FVector Gravity,FVector Acceleration) {}
	///<summary>Retrieves the X and Y screen coordinates of the mouse cursor. Returns false if there is no associated mouse device</summary>
	public  bool GetMousePosition(float LocationX,float LocationY) { return default; }
	///<summary>Returns how long the given key/button has been down.  Returns 0 if it&#39;s up or it just went down this frame.</summary>
	public  float GetInputKeyTimeDown(FKey Key) { return default; }
	///<summary>Retrieves how far the mouse moved this frame.</summary>
	public  void GetInputMouseDelta(float DeltaX,float DeltaY) {}
	///<summary>Retrieves the X and Y displacement of the given analog stick.</summary>
	public  void GetInputAnalogStickState(EControllerAnalogStick WhichStick,float StickX,float StickY) {}
	///<summary>Activates a new touch interface for this player controller</summary>
	public  void ActivateTouchInterface(UTouchInterface NewTouchInterface) {}
	///<summary>Set the virtual joystick visibility.</summary>
	public  void SetVirtualJoystickVisibility(bool bVisible) {}
	///<summary>Change Camera mode</summary>
	public  void Camera(string NewMode) {}
	///<summary>Set the view target blending with variable control</summary>
	public  void SetViewTargetWithBlend(AActor NewViewTarget,float BlendTime/*=0f*/,EViewTargetBlendFunction BlendFunc/*=VTBlend_Linear*/,float BlendExp/*=0f*/,bool bLockOutgoing/*=false*/) {}
	///<summary>InputComponent we use when player is in Inactive state.</summary>
	public UInputComponent InactiveStateInputComponent;
	///<summary>Whether we fully tick when the game is paused, if our tick function is allowed to do so. If false, we do a minimal update during the tick.</summary>
	public bool bShouldPerformFullTickWhenPaused;
	///<summary>The currently set touch interface</summary>
	public UTouchInterface CurrentTouchInterface;
	///<summary>If set, then this UPlayerInput class will be used instead of the Input Settings&#39; DefaultPlayerInputClass</summary>
	public UClass OverridePlayerInputClass;
	///<summary>GetOverridePlayerInputClass</summary>
	public  UClass GetOverridePlayerInputClass() { return default; }
	///<summary>Returns the platform user that is assigned to this Player Controller&#39;s Local Player.</summary>
	public  FPlatformUserId GetPlatformUserId() { return default; }
	///<summary>Used to override the default positioning of the audio listener</summary>
	public  void SetAudioListenerOverride(USceneComponent AttachToComponent,FVector Location,FRotator Rotation) {}
	///<summary>Clear any overrides that have been applied to audio listener</summary>
	public  void ClearAudioListenerOverride() {}
	///<summary>SetAudioListenerAttenuationOverride</summary>
	public  void SetAudioListenerAttenuationOverride(USceneComponent AttachToComponent,FVector AttenuationLocationOVerride) {}
	///<summary>ClearAudioListenerAttenuationOverride</summary>
	public  void ClearAudioListenerAttenuationOverride() {}
	///<summary>Returns true if this controller thinks it&#39;s able to restart. Called from GameModeBase::PlayerCanRestart</summary>
	public  bool CanRestartPlayer() { return default; }
	///<summary>Server/SP only function for changing whether the player is in cinematic mode.  Updates values of various state variables, then replicates the call to the client</summary>
	public  void SetCinematicMode(bool bInCinematicMode,bool bHidePlayer,bool bAffectsHUD,bool bAffectsMovement,bool bAffectsTurning) {}
	///<summary>Notify from server that Visual Logger is recording, to show that information on client about possible performance issues</summary>
	public  void OnServerStartedVisualLogger(bool bIsLogging) {}
	///<summary>Get the Pawn used when spectating. nullptr when not spectating.</summary>
	public  ASpectatorPawn GetSpectatorPawn() { return default; }
	///<summary>Returns the location the PlayerController is focused on.</summary>
	public  FVector GetFocalLocation() { return default; }
	///<summary>The pawn used when spectating (nullptr if not spectating).</summary>
	public ASpectatorPawn SpectatorPawn;
	///<summary>Set during SpawnActor once and never again to indicate the intent of this controller instance (SERVER ONLY)</summary>
	public bool bIsLocalPlayerController;
	///<summary>The location used internally when there is no pawn or spectator, to know where to spawn the spectator or focus the camera on death.</summary>
	public FVector SpawnLocation;
	///<summary>Client says &quot;Here is input frame number X&quot; (and then calls other RPCs to deliver InputCmd payload)</summary>
	public  void ServerRecvClientInputFrame(int RecvClientInputFrame,TArray<byte> Data) {}
	///<summary>We call this in ::SendClientAdjustment to tell the client what the last processed input frame was for it and on what local frame number it was processed</summary>
	public  void ClientRecvServerAckFrame(int LastProcessedInputFrame,int RecvServerFrameNumber,short TimeDilation) {}
	///<summary>ClientRecvServerAckFrameDebug</summary>
	public  void ClientRecvServerAckFrameDebug(byte NumBuffered,float TargetNumBufferedCmds) {}
	///<summary>ServerSendLatestAsyncPhysicsTimestamp</summary>
	public  void ServerSendLatestAsyncPhysicsTimestamp(FAsyncPhysicsTimestamp Timestamp) {}
	///<summary>ClientCorrectionAsyncPhysicsTimestamp</summary>
	public  void ClientCorrectionAsyncPhysicsTimestamp(FAsyncPhysicsTimestamp Timestamp) {}
	///<summary>ClientAckTimeDilation</summary>
	public  void ClientAckTimeDilation(float TimeDilation,int ServerStep) {}
}
