namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraPlayerControllerBase.h")]
public partial class AVirtualCameraPlayerControllerBase : APlayerController {
	public static UClass StaticClass() {return default;}
	///<summary>Allows user to select which tracker input should be used</summary>
	public ETrackerInputSource InputSource;
	///<summary>Controller for level sequence playback</summary>
	public string LiveLinkTargetName;
	///<summary>Offset applied to calculated location before tracker transform is added</summary>
	public FTrackingOffset TrackerPreOffset;
	///<summary>Offset applied to calculated location after tracker transform is added</summary>
	public FTrackingOffset TrackerPostOffset;
	///<summary>Class of CameraActor to spawn to allow user to use their own customized camera</summary>
	public UClass TargetCameraActorClass;
	///<summary>Array of any properties that should be recorded</summary>
	public TArray<string> RequiredSequencerRecorderCameraSettings;
	///<summary>OnOffsetReset</summary>
	public FVirtualCameraResetOffsetsDelegate OnOffsetReset;
	///<summary>RootActor</summary>
	public AVPRootActor RootActor;
	///<summary>Overridable function to allow user to get tracker data from blueprints.</summary>
	public void GetCustomTrackerLocationAndRotation(FVector OutTrackerLocation,FRotator OutTrackerRotation) {}
	///<summary>Blueprint Event for updating position of autofocus reticle.</summary>
	public void UpdateFocusReticle(FVector NewReticleLocation) {}
	///<summary>Blueprint Event for updating if a sequence can be recorded or not.</summary>
	public void OnRecordEnabledStateChanged(bool bIsRecordEnabled) {}
	///<summary>Blueprint Event for when a sequence stops playing.</summary>
	public void OnStopped() {}
	///<summary>Sets the autofocus point to the correct starting location at the center of the screen</summary>
	public void InitializeAutoFocusPoint() {}
	///<summary>Returns the target camera that was spawned for this play</summary>
	public ACineCameraActor GetTargetCamera() { return default; }
	///<summary>Set the input source</summary>
	public void SetInputSource(ETrackerInputSource InInputSource) {}
	///<summary>Blueprint event for when the focus method is changed.</summary>
	public void FocusMethodChanged(EVirtualCameraFocusMethod NewFocusMethod) {}
	///<summary>Converts a distance in unreal units (cm) to other units of measurement for display.</summary>
	public string GetDistanceInDesiredUnits(float InputDistance,EUnit ConversionUnit) { return default; }
	///<summary>Controller for level sequence playback</summary>
	public ULevelSequencePlaybackController LevelSequencePlaybackController;
	///<summary>Target camera that is spawned or possessed on begin play for the sequence controller</summary>
	public ACineCameraActor TargetCameraActor;
	///<summary>Cached value for IsVirtualCameraControlledByRemoteSession()</summary>
	public bool bCachedIsVirtualCameraControlledByRemoteSession;
	///<summary>Cached value for IsVirtualCameraControlledByRemoteSession()</summary>
	public bool bCachedShouldUpdateTargetCameraTransform;
	///<summary>Broadcast offset resets when movement component broadcasts</summary>
	public void BroadcastOffsetReset() {}
	///<summary>* Is this machine should display the Virtual Camera UI and establish a connection with the remote session app.</summary>
	public bool IsVirtualCameraControlledByRemoteSession() { return default; }
	///<summary>* In multi user session, how should we update the information across different sessions.</summary>
	public bool ShouldUpdateTargetCameraTransform() { return default; }
	///<summary>Adds a blendable object to the camera&#39;s post process settings.</summary>
	public void AddBlendableToCamera(object /*BlendableToAdd*/ BlendableToAdd,float Weight) {}
	///<summary>Adjusts the aperture of the camera to an adjacent preset value.</summary>
	public float ChangeAperturePreset(bool bShiftUp) { return default; }
	///<summary>Adjust the focal length of the camera to an adjecent preset value.</summary>
	public float ChangeFocalLengthPreset(bool bShiftUp) { return default; }
	///<summary>Clears the current level sequence player, needed when recording clean takes of something</summary>
	public void ClearActiveLevelSequence() {}
	///<summary>Deletes a preset using its name as the key.</summary>
	public int DeletePreset(string PresetName) { return default; }
	///<summary>Deletes a screenshot, using its name as the key.</summary>
	public int DeleteScreenshot(string ScreenshotName) { return default; }
	///<summary>Deletes a waypoint, using its name as the key.</summary>
	public int DeleteWaypoint(string WaypointName) { return default; }
	///<summary>Returns the asset name of the currently selected sequence</summary>
	public string GetActiveLevelSequenceName() { return default; }
	///<summary>Returns the currently selected sequence</summary>
	public ULevelSequence GetActiveLevelSequence() { return default; }
	///<summary>Gets stabalization scale for a specific axis.</summary>
	public float GetAxisStabilizationScale(EVirtualCameraAxis AxisToRetrieve) { return default; }
	///<summary>Gets movement scale for a specific axis.</summary>
	public float GetAxisMovementScale(EVirtualCameraAxis AxisToRetrieve) { return default; }
	///<summary>Get the current aperture value on the camera.</summary>
	public float GetCurrentAperture() { return default; }
	///<summary>Get the name of the current preset filmback option on the camera.</summary>
	public string GetCurrentFilmbackName() { return default; }
	///<summary>Get the current focal length value on the camera.</summary>
	public float GetCurrentFocalLength() { return default; }
	///<summary>Returns the current focus distance of the camera.</summary>
	public float GetCurrentFocusDistance() { return default; }
	///<summary>Returns the current focus method.</summary>
	public EVirtualCameraFocusMethod GetCurrentFocusMethod() { return default; }
	///<summary>Get the end position of the currently selected sequence</summary>
	public FFrameNumber GetCurrentSequencePlaybackEnd() { return default; }
	///<summary>Get the start position of the currently selected sequence</summary>
	public FFrameNumber GetCurrentSequencePlaybackStart() { return default; }
	///<summary>Gets the locked to camera cut from the active LevelSequence</summary>
	public bool IsSequencerLockedToCameraCut() { return default; }
	///<summary>Sets the locked to camera cut from the active LevelSequence</summary>
	public void SetSequencerLockedToCameraCut(bool bLockView) {}
	///<summary>Get the frame rate of the currently selected sequence</summary>
	public FFrameRate GetCurrentSequenceFrameRate() { return default; }
	///<summary>Returns previously set unit of distance.</summary>
	public EUnit GetDesiredDistanceUnits() { return default; }
	///<summary>Get the current color of the focus plane that should be used</summary>
	public FColor GetFocusPlaneColor() { return default; }
	///<summary>Stores the names of all available filmback presets into an array.</summary>
	public bool GetFilmbackPresetOptions(TArray<string> OutFilmbackPresetsArray) { return default; }
	///<summary>Gets the length of the currently selected level sequence</summary>
	public FFrameNumber GetLevelSequenceLength() { return default; }
	///<summary>Returns the names of each level sequence asset in the project</summary>
	public void GetLevelSequences(TArray<FLevelSequenceData> OutLevelSequenceNames) {}
	///<summary>Returns the current matte aspect ratio.</summary>
	public float GetMatteAspectRatio() { return default; }
	///<summary>Set the matte aspect ratio to a new value.</summary>
	public float GetMatteOpacity() { return default; }
	///<summary>Returns the values of all matte options.</summary>
	public void GetMatteValues(TArray<float> OutMatteValues) {}
	///<summary>Gets the playback position of the level sequence</summary>
	public FFrameTime GetPlaybackPosition() { return default; }
	///<summary>Gets the playback Timecode of the level sequence</summary>
	public FTimecode GetPlaybackTimecode() { return default; }
	///<summary>Returns the information associated with a Screenshot.</summary>
	public void GetScreenshotInfo(string ScreenshotName,FVirtualCameraScreenshot OutScreenshotInfo) {}
	///<summary>Collects a list of existing screenshot names.</summary>
	public void GetScreenshotNames(TArray<string> OutArray) {}
	///<summary>Returns a sorted TMap of the current presets.</summary>
	public TMap<string,FVirtualCameraSettingsPreset> GetSettingsPresets() { return default; }
	///<summary>Sets the current state of touch input.</summary>
	public ETouchInputState GetTouchInputState() { return default; }
	///<summary>Returns the information associated with a waypoint.</summary>
	public void GetWaypointInfo(string WaypointName,FVirtualCameraWaypoint OutWaypointInfo) {}
	///<summary>Collects a list of existing waypoint names.</summary>
	public void GetWaypointNames(TArray<string> OutArray) {}
	///<summary>Checks if an axis is locked.</summary>
	public bool IsAxisLocked(EVirtualCameraAxis AxisToCheck) { return default; }
	///<summary>Checks whether or not focus visualization can activate</summary>
	public bool IsFocusVisualizationAllowed() { return default; }
	///<summary>Check to see if the sequence is playing</summary>
	public bool IsPlaying() { return default; }
	///<summary>Helper to check if touch input state is in a touch focus mode.</summary>
	public bool IsTouchInputInFocusMode() { return default; }
	///<summary>Get whether or not global boom is being used when navigating with the joysticks</summary>
	public bool IsUsingGlobalBoom() { return default; }
	///<summary>Goes to the end of the level sequence and pauses</summary>
	public void JumpToLevelSequenceEnd() {}
	///<summary>Goes to the start of the level sequence and pauses</summary>
	public void JumpToLevelSequenceStart() {}
	///<summary>Sets the playback position of the level sequence.</summary>
	public void JumpToPlaybackPosition(FFrameNumber InFrameNumber) {}
	///<summary>Loads a preset using its name as a string key.</summary>
	public bool LoadPreset(string PresetName) { return default; }
	///<summary>Moves a camera to the location where a screenshot was taken and restores camera settings used for that screenshot.</summary>
	public bool LoadScreenshotView(string ScreenshotName) { return default; }
	///<summary>Pauses the playing of the current level sequence.</summary>
	public void PauseLevelSequence() {}
	///<summary>Plays current level sequence</summary>
	public void PlayLevelSequence() {}
	///<summary>Plays current level sequence in reverse</summary>
	public void PlayLevelSequenceInReverse() {}
	///<summary>Moves the camera back to actor root and aligns rotation with the input tracker.</summary>
	public void ResetCameraOffsetsToTracker() {}
	///<summary>Plays current level sequence from the current time.</summary>
	public void ResumeLevelSequencePlay() {}
	///<summary>Stores the new home waypoint location.</summary>
	public void SaveHomeWaypoint(string NewHomeWaypointName) {}
	///<summary>Saves a preset into the list of presets.</summary>
	public string SavePreset(bool bSaveCameraSettings,bool bSaveStabilization,bool bSaveAxisLocking,bool bSaveMotionScale) { return default; }
	///<summary>Stores the current pawn location as a waypoint.</summary>
	public string SaveWaypoint() { return default; }
	///<summary>Changes the active level sequence to a new level sequence.</summary>
	public bool SetActiveLevelSequence(ULevelSequence InNewLevelSequence) { return default; }
	///<summary>Sets whether or not to use focus visualization</summary>
	public void SetAllowFocusPlaneVisualization(bool bShouldAllowFocusVisualization) {}
	///<summary>Sets the stabilization rate for a given lock.</summary>
	public float SetAxisStabilizationScale(EVirtualCameraAxis AxisToAdjust,float NewStabilizationAmount) { return default; }
	///<summary>Set the current aperture value on the camera.</summary>
	public void SetCurrentAperture(float NewAperture) {}
	///<summary>Sets the current focal length of the cinematic camera to a given value.</summary>
	public void SetCurrentFocalLength(float NewFocalLength) {}
	///<summary>Sets the current focus distance of the cinematic camera to a given value.</summary>
	public void SetCurrentFocusDistance(float NewFocusDistance) {}
	///<summary>Sets unit of distance.</summary>
	public void SetDesiredDistanceUnits(EUnit DesiredUnits) {}
	///<summary>Set the filmback settings to a new filmback preset.</summary>
	public bool SetFilmbackPresetOption(string NewFilmbackPreset) { return default; }
	///<summary>Sets the camera focus method.</summary>
	public void SetFocusMethod(EVirtualCameraFocusMethod NewFocusMethod) {}
	///<summary>Changes focus plane color.</summary>
	public void SetFocusPlaneColor(FColor NewFocusPlaneColor) {}
	///<summary>Toggles focus visualization tools on camera.</summary>
	public void SetFocusVisualization(bool bShowFocusVisualization) {}
	///<summary>Checks whether or not focus visualization is activate</summary>
	public bool IsFocusVisualizationActivated() { return default; }
	///<summary>Set the matte aspect ratio to a new value.</summary>
	public bool SetMatteAspectRatio(float NewMatteAspectRatio) { return default; }
	///<summary>Set the matte aspect ratio to a new value.</summary>
	public void SetMatteOpacity(float NewMatteOpacity) {}
	///<summary>Sets the movement scale of the camera actor.</summary>
	public void SetMovementScale(EVirtualCameraAxis AxisToAdjust,float NewMovementScale) {}
	///<summary>Sets whether or not a preset is favorited</summary>
	public void SetPresetFavoriteStatus(string PresetName,bool bIsFavorite) {}
	///<summary>Sets whether settings should be saved on exit.</summary>
	public void SetSaveSettingsWhenClosing(bool bShouldSettingsSave) {}
	///<summary>Sets whether or not a screenshot is favorited</summary>
	public void SetScreenshotFavoriteStatus(string ScreenshotName,bool bIsFavorite) {}
	///<summary>Sets the current state of touch input.</summary>
	public void SetTouchInputState(ETouchInputState NewInputState) {}
	///<summary>Sets whether or not global boom should be used when navigating with the joysticks</summary>
	public void SetUseGlobalBoom(bool bShouldUseGlobalBoom) {}
	///<summary>Sets whether or not a waypoint is favorited</summary>
	public void SetWaypointFavoriteStatus(string WaypointName,bool bIsFavorite) {}
	///<summary>Set the value for the option to zero out dutch when locking that axis.</summary>
	public void SetZeroDutchOnLock(bool bInValue) {}
	///<summary>Check whether settings should save when closing</summary>
	public bool ShouldSaveSettingsWhenClosing() { return default; }
	///<summary>Stops the currently playing level sequence.</summary>
	public void StopLevelSequencePlay() {}
	///<summary>Takes a screenshot from the current view and saves the location and camera settings.</summary>
	public string TakeScreenshot() { return default; }
	///<summary>Teleports to the current marked home waypoint.</summary>
	public void TeleportToHomeWaypoint() {}
	///<summary>Teleports the pawn to a specific location.</summary>
	public bool TeleportToWaypoint(string WaypointIndex) { return default; }
	///<summary>Toggles the freeze on a given axis; returns new frozen state.</summary>
	public bool ToggleAxisFreeze(EVirtualCameraAxis AxisToToggle) { return default; }
	///<summary>Toggles the lock on a given axis; returns new locked state.</summary>
	public bool ToggleAxisLock(EVirtualCameraAxis AxisToToggle) { return default; }
	///<summary>Helper to bring the game viewport to front.</summary>
	public void ActivateGameViewport() {}
}
